using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ZedGraph;

namespace READ_COMPORT
{
    
    public partial class Form1 : Form
    {
        string dataOut;
        string Pulse1, Pulse4, Position, Error, Negative_Position,Pos,In;
        bool Draw = false; 
        bool Draw1 = false;
        bool CLEAR = false;       
        int Tickstart;      
        PointPairList list3 = new PointPairList();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBOX_COMPORT.Items.AddRange(ports);

            btnCLOSE.Enabled = false;
            btnOPEN.Enabled = true;
            chBoxAlwaysUpdate.Checked = true;
            chBoxAddtoOldData.Checked = false;

            GraphPane mypane = z2.GraphPane;            
            mypane.Title.Text = "System";
            mypane.XAxis.Title.Text = "Time (s)";
            mypane.YAxis.Title.Text = "Angle ";

            RollingPointPairList list1 = new RollingPointPairList(60000);
            RollingPointPairList list2 = new RollingPointPairList(60000);
            LineItem Curve1 = mypane.AddCurve("OutPut", list1, Color.Red, SymbolType.None);
            LineItem Curve2 = mypane.AddCurve("InPut", list2, Color.Blue, SymbolType.None);
            Curve1.Line.Width = 2;
            Curve2.Line.Width = 2;              
            mypane.XAxis.Scale.Min = 0; 
            mypane.XAxis.Scale.Max = 10;
            mypane.YAxis.Scale.Min = -360;
            mypane.YAxis.Scale.Max = 360;

            z2.AxisChange();          

        }
        private void DrawGraph(string setpoint1, string setpoint2, PointPairList list4)
        {
            double intsetpoint1;
            double intsetpoint2;
            double time;
            double.TryParse(setpoint1, out intsetpoint1);
            double.TryParse(setpoint2, out intsetpoint2);
                                              
                LineItem curve1 = z2.GraphPane.CurveList[0] as LineItem;
                LineItem curve2 = z2.GraphPane.CurveList[1] as LineItem;
                if (curve1 == null)
                    return;
                if (curve1 == null)
                    return;

                IPointListEdit list1 = curve1.Points as IPointListEdit;
                IPointListEdit list2 = curve2.Points as IPointListEdit;
                
                if (list1 == null)
                    return;

                time = (Environment.TickCount - Tickstart) / 1000.0;
                list4.Add(time, intsetpoint1);               
                list1.Add(time, intsetpoint1);
                list2.Add(time, intsetpoint2);

                Scale xScale = z2.GraphPane.XAxis.Scale;
                Scale yScale = z2.GraphPane.YAxis.Scale;
                if (time > xScale.Max - xScale.MajorStep)
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = xScale.Max - 10.0;
                }
                if (CLEAR)
                        {                     
                            curve1.Clear();
                            curve2.Clear();
                            Tickstart = Environment.TickCount;
                            xScale.Max = 10;
                            xScale.Min = 0;
                            z2.AxisChange();
                            z2.Invalidate();
                            list1.Clear();
                            list2.Clear();
                            list4.Clear();
                            CLEAR = false;
                         }                                              

                z2.AxisChange();
                z2.Invalidate();
                            
        }

        private void btnOPEN_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBOX_COMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBOX_BAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataBits.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParityBits.Text);
                serialPort1.Open();
                progressBar1.Value = 100;
                btnCLOSE.Enabled = true;
                btnOPEN.Enabled = false;
                lblStatusCOM.Text = "ON";

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCLOSE.Enabled = false;
                btnOPEN.Enabled = true;
                lblStatusCOM.Text = "OFF";
            }
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                btnCLOSE.Enabled = false;
                btnOPEN.Enabled = true;
                lblStatusCOM.Text = "OFF";
                Draw = false;
                Draw1 = false;
                timer1.Enabled = false;
                cBoxModeDC.Enabled = true;
                btnDrawGraph.Text = "START";
            }
        }
        int check = 0;
        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                double doudataOut;
                dataOut = tBoxDataOut.Text;
                if (dataOut.Length == 3)
                {
                    if (cBoxModeDC.Text == "+")
                    {
                        serialPort1.Write("+");
                    }
                    else if (cBoxModeDC.Text == "-")
                    {
                        serialPort1.Write("-");
                    }
                    serialPort1.Write(dataOut);
                    serialPort1.Write("p");
                    double.TryParse(dataOut, out doudataOut);
                    if (doudataOut > 360)
                    {

                        txBoxData.Text = (doudataOut % 360).ToString();
                    }
                    else if (cBoxModeDC.Text == "-")
                    {
                        doudataOut = -doudataOut;
                        txBoxData.Text = (doudataOut).ToString();
                    }
                    else
                    {
                        txBoxData.Text = (doudataOut).ToString();
                    }
                    timer1.Enabled = true;
                    cBoxModeDC.Enabled = false;
                    btnDrawGraph.Text = "STOP";
                    Draw1 = true;
                    if (check == 0) { Tickstart = Environment.TickCount; check = 1; }
                    Draw = true;
                }
                else 
                {
                    MessageBox.Show("String length must be 3 character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                                     
                }

            }

        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClearDataOUT_Click(object sender, EventArgs e)
        {
            if (tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = "";
            }
        }

        private void tBoxDataOut_TextChanged(object sender, EventArgs e)
        {
            int dataOUTlenght = tBoxDataOut.TextLength;
            lblDataOUTlength.Text = string.Format("{0:00}", dataOUTlenght);
        }

        private void chBoxUsingBUTTON_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBOXusingEnter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBOXusingEnter_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            try
            {
                while (serialPort1.BytesToRead > 0)
                    {
                   
                    Position = serialPort1.ReadTo("p");
                    Pulse1 = serialPort1.ReadTo("a");
                    Pulse4 = serialPort1.ReadTo("b");
                    Error = serialPort1.ReadTo("e");
                    
                }
            }
            catch { }
           
        }

       

        private void chBoxAlwaysUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAlwaysUpdate.Checked)
            {
                chBoxAlwaysUpdate.Checked = true;
                chBoxAddtoOldData.Checked = false;               
            }
        }

        private void chBoxAddtoOldData_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxAddtoOldData.Checked)
            {
                chBoxAlwaysUpdate.Checked = false;
                chBoxAddtoOldData.Checked = true;
            }
        }

        private void btnClearDataIn_Click(object sender, EventArgs e)
        {
            if (tBoxDataIN.Text != "")
            {
                tBoxDataIN.Text = "";
                txBoxPulseIn.Text = "";
                txBoxSpeed.Text = "";
                txBoxMode.Text = "";
            }
        }     

        private void button1_Click(object sender, EventArgs e)
        {
            GC.Collect();
            Application.Exit();
            
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Draw)
            {
                double intPosition;
                
                if (chBoxAddtoOldData.Checked)
                {
                    if (cBoxModeDC.Text == "-")
                    {
                        double.TryParse(Position, out intPosition);
                        intPosition = -intPosition;
                        Negative_Position = intPosition.ToString();
                        tBoxDataIN.Text = Negative_Position;
                    }
                    else tBoxDataIN.Text = Position;
                    if (cBoxMode.Text == "x1")
                        txBoxPulseIn.Text = Pulse1;
                    else txBoxPulseIn.Text = Pulse4;
                    txBoxSpeed.Text = Error;
                    if (cBoxMode.Text == "x1")
                        txBoxMode.Text = "x1";
                    else txBoxMode.Text = "x4";
                }
                else if (chBoxAlwaysUpdate.Checked)
                {

                    if (cBoxMode.Text == "x1")
                        txBoxPulseIn.Text = Pulse1;
                    else txBoxPulseIn.Text = Pulse4;
                    txBoxSpeed.Text = Error;
                    if (cBoxModeDC.Text == "-")
                    {
                        double.TryParse(Position, out intPosition);
                        intPosition = intPosition-360;
                        Negative_Position = intPosition.ToString();
                        tBoxDataIN.Text = Negative_Position;
                    }
                    else tBoxDataIN.Text = Position;
                    if (cBoxMode.Text == "x1")
                        txBoxMode.Text = "x1";
                    else txBoxMode.Text = "x4";
                }
                             
            }                
            if (Draw1)
            
            {
                Pos = txBoxData.Text;
                In = tBoxDataIN.Text;
                DrawGraph(In, Pos, list3); 
            }

        }

        private void btnDrawGraph_Click(object sender, EventArgs e)
        {
            if (btnDrawGraph.Text == "START")
            {
                cBoxModeDC.Enabled = false;
                timer1.Enabled = true;
                btnDrawGraph.Text = "STOP";
                Draw1 = true;
                if (check == 0) { Tickstart = Environment.TickCount; check = 1; }
                
            }
            else 
            {
                timer1.Enabled = false;
                cBoxModeDC.Enabled = true;
                btnDrawGraph.Text = "START";
               

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {         
            CLEAR = true;          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void txBoxData_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRESET_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("r");
                txBoxData.Text = "0";
                tBoxDataOut.Text = "0";
            }
                    
        }                       
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txBoxPulseIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
    

