/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; Copyright (c) 2021 STMicroelectronics.
  * All rights reserved.</center></h2>
  *
  * This software component is licensed by ST under BSD 3-Clause license,
  * the "License"; You may not use this file except in compliance with the
  * License. You may obtain a copy of the License at:
  *                        opensource.org/licenses/BSD-3-Clause
  *
  ******************************************************************************
  */
/* USER CODE END Header */
/* Includes ------------------------------------------------------------------*/
#include "main.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
#include <stdlib.h>
#include <stdio.h>
#include <math.h>

float reductor_rate=100;
int a=0;	
int count_2=0;	
int count_3=0;
float shaft_count=0;	
uint32_t time[2]={0};									
int indis=0;
double rpm=0;
float desired_rpm=0;
float Kp_speed=0.1;
float error_speed=0;
float PWM_Out_speed=0;
int cw_ccw_speed=0;
float position_degree=0;																									
float Kp=3;	//Kp for position control	
float Ki=0.01;	//Ki for position control
float Kd=0.1;	//Kd for position control
float desired_angle = 0;								
float error=0 , new_error = 0;
float error_prior;
float PWM_Out=0;
float integration_sum=0;
float derivative=0;
int cw_ccw=2;  	//clock wise=0 // counter clock wise=1
uint8_t RxBuffer[5] ,Position_Str[6],Pulse_Str1[5],ERROR_Str[5],Pulse_Str4[5];
int iteration_time=2; 	//iteration time in msec
float temp=0;
int only_once=2;
int only_once_speed=2;
int first_zero=0;
float saiso=0;
int heso=0;
int kichtu=5;
int doisaiso=350;
int solan=0;
volatile short encoder_x4 = 0;
volatile short  encoder_x1 = 0;
int mode = 2;	//mode=0 -> position // mode=1 -> speed
/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */
 void IntToStr5_position(uint16_t u, uint8_t *y)
{	
	uint16_t a;
	a=u;
	y[5] = 'p';
	y[4] = a%10 + 0x30;
	a =  a/10;
	y[3] = '.';
	y[2] = a%10 +0x30;
	a =  a/10;
	y[1] = a%10 + 0x30;
	a =  a/10;
	y[0] = a%10 + 0x30;	
}
 void IntToStr5_pulse1(uint16_t u, uint8_t *y)
{
	uint16_t a;
	a=u;
	y[4] = 'a';
	y[3] = a%10 + 0x30;
	a =  a/10;
	y[2] = a%10 + 0x30;
	a =  a/10;
	y[1] = a%10 +0x30;
	a =  a/10;
	y[0] = a + 0x30;
}
	void IntToStr5_pulse4(uint16_t u, uint8_t *y)
{
	uint16_t a;
	a=u;
	y[4] = 'b';
	y[3] = a%10 + 0x30;
	a =  a/10;
	y[2] = a%10 + 0x30;
	a =  a/10;
	y[1] = a%10 +0x30;
	a =  a/10;
	y[0] = a + 0x30;	
}
void IntToStr5_error(uint16_t u, uint8_t *y)
{
	uint16_t a;
	a=u;
	y[4] = 'e';
	y[3] = a%10 + 0x30;
	a =  a/10;
	y[2] ='.';
	y[1] = a%10 +0x30;
	a =  a/10;
	y[0] = a + 0x30;
}
/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/
TIM_HandleTypeDef htim2;
TIM_HandleTypeDef htim3;

UART_HandleTypeDef huart4;
DMA_HandleTypeDef hdma_uart4_tx;
DMA_HandleTypeDef hdma_uart4_rx;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
/* USER CODE BEGIN PV */

/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
static void MX_GPIO_Init(void);
static void MX_DMA_Init(void);
static void MX_TIM2_Init(void);
static void MX_TIM3_Init(void);
static void MX_UART4_Init(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */

/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
	{
  /* USER CODE BEGIN 1 */

  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  MX_DMA_Init();
  MX_TIM2_Init();
  MX_TIM3_Init();
  MX_UART4_Init();
  /* USER CODE BEGIN 2 */
	HAL_TIM_PWM_Start(&htim2,TIM_CHANNEL_2);
	HAL_TIM_PWM_Start(&htim2,TIM_CHANNEL_3);
	HAL_TIM_PWM_Start(&htim2,TIM_CHANNEL_4);
	HAL_TIM_PWM_Start_IT(&htim2,TIM_CHANNEL_2);
	HAL_TIM_PWM_Start_IT(&htim2,TIM_CHANNEL_3);
	HAL_TIM_PWM_Start_IT(&htim2,TIM_CHANNEL_4);	
	HAL_TIM_Encoder_Start(&htim3,TIM_CHANNEL_1);
	HAL_TIM_Encoder_Start(&htim3,TIM_CHANNEL_2);
	HAL_TIM_IC_Start_IT(&htim3,TIM_CHANNEL_1);
	HAL_TIM_IC_Start_IT(&htim3,TIM_CHANNEL_2); 	
	HAL_UART_Receive_IT(&huart4,&RxBuffer[count_3],1); //In every 1 byte(1 character in ASCII table) received interrupt will be triggered.				
	
  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {
    error = (desired_angle - (float)(position_degree / 10));	//Error calculation based on 360 degrees
		
		if(error>180)  //Actual error calculation
		{
		error=error-360;	
		}
	else if(error <= -180){		
		
	error = error+360;	
		
	}
	
	if(kichtu != 0){heso = 50; kichtu--;} else {heso = 15;}
	if(doisaiso > 300){saiso = 20;doisaiso--;} else if (doisaiso > 200){saiso = 15;doisaiso--;} else if(doisaiso > 100){saiso = 6;doisaiso--;} else if(doisaiso >= 0) {saiso = 1;doisaiso--;} 
	if(doisaiso == 0 && (error > 1 || error < -1)){doisaiso = 200;kichtu = 3;}
	temp = error * iteration_time;
	temp /= 1000;
	integration_sum += temp;
	derivative = error - error_prior;
	derivative *= 1000;
	derivative /= iteration_time;
	encoder_x4 = __HAL_TIM_GET_COUNTER(&htim3);

	if(integration_sum > 500){			//Limiting integration sum for integral anti wind-up.
		
	integration_sum = 500;	
		
	}
	else if(integration_sum < -500){	
		
	integration_sum = -500;		
		
	}
	if(kichtu!=0){PWM_Out=20;} else {
	PWM_Out=Kp*error+Ki*integration_sum+Kd*derivative; //PWM calculation with PID control.	
	}
	
	if(PWM_Out>100){PWM_Out=100;}else if(PWM_Out<-100){PWM_Out=-100;}		//Since PWM_Out can be maximum 1000 it limited to it.
	
	if (error<saiso && error>-saiso){
		
	HAL_TIM_PWM_Stop_IT(&htim2,TIM_CHANNEL_2);
	HAL_TIM_PWM_Stop_IT(&htim2,TIM_CHANNEL_3);
	HAL_TIM_PWM_Stop_IT(&htim2,TIM_CHANNEL_4);
		
	__HAL_TIM_SetCompare(&htim2, TIM_CHANNEL_2, 0);
	__HAL_TIM_SetCompare(&htim2, TIM_CHANNEL_3, 0);
	__HAL_TIM_SetCompare(&htim2, TIM_CHANNEL_4, 0);
		PWM_Out=0;
		integration_sum=0;
		derivative=0;
	only_once=2;
	
	}
	else if(PWM_Out>0){				//Positive PWM means counter clock wise direction.
	
	if(only_once!=1){				//To perform the start/stop operation once, unless the direction of rotation changes.
			
	
		HAL_TIM_PWM_Start_IT(&htim2,TIM_CHANNEL_2);
		HAL_TIM_PWM_Start_IT(&htim2,TIM_CHANNEL_3);
		HAL_TIM_PWM_Start_IT(&htim2,TIM_CHANNEL_4);
		only_once=1;	
			
	}
	__HAL_TIM_SetCompare(&htim2, TIM_CHANNEL_4, (heso*PWM_Out));
	__HAL_TIM_SetCompare(&htim2, TIM_CHANNEL_3, (heso*PWM_Out));	
	__HAL_TIM_SetCompare(&htim2, TIM_CHANNEL_2, (heso*PWM_Out));	//Sets PWM value to Timer's register.
	
	}
	else if(PWM_Out<0){  				//Negative PWM means clock wise direction.

	if(only_once!=0){				//To perform the start/stop operation once, unless the direction of rotation changes.
			
	HAL_TIM_PWM_Start_IT(&htim2,TIM_CHANNEL_4);
		HAL_TIM_PWM_Start_IT(&htim2,TIM_CHANNEL_3);
	HAL_TIM_PWM_Start_IT(&htim2,TIM_CHANNEL_2);
	only_once=0;	
			
	}
		__HAL_TIM_SetCompare(&htim2, TIM_CHANNEL_4, (-heso*PWM_Out));
	__HAL_TIM_SetCompare(&htim2, TIM_CHANNEL_3, (-heso*PWM_Out));
	__HAL_TIM_SetCompare(&htim2, TIM_CHANNEL_2, (-heso*PWM_Out)); //Sets PWM value to Timer's register.

	}
		
	error_prior=error;	//Error saved for derivative calculation.
	HAL_Delay(iteration_time); //Iteration time delay.
		
    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
	
	// Transmit Data to GUI
	a++;
	if (a == 100)
	{
		new_error = round(error*10);
		if (new_error < 0)
			{ 
			new_error *= -1;
			}
		IntToStr5_pulse1(encoder_x1, Pulse_Str1);
		IntToStr5_pulse4(encoder_x4, Pulse_Str4);// Xung
		IntToStr5_error(new_error, ERROR_Str); //sai so
		HAL_UART_Transmit(&huart4,(uint8_t*) Position_Str,6,100);
		HAL_UART_Transmit(&huart4,(uint8_t*) Pulse_Str1,5,100);
		HAL_UART_Transmit(&huart4,(uint8_t*) Pulse_Str4,5,100);
		HAL_UART_Transmit(&huart4,(uint8_t*) ERROR_Str,5,100);
		a = 0;	
	}

  }
	
  /* USER CODE END 3 */
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};

  /** Configure the main internal regulator output voltage
  */
  __HAL_RCC_PWR_CLK_ENABLE();
  __HAL_PWR_VOLTAGESCALING_CONFIG(PWR_REGULATOR_VOLTAGE_SCALE1);
  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSE;
  RCC_OscInitStruct.HSEState = RCC_HSE_ON;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSE;
  RCC_OscInitStruct.PLL.PLLM = 8;
  RCC_OscInitStruct.PLL.PLLN = 336;
  RCC_OscInitStruct.PLL.PLLP = RCC_PLLP_DIV2;
  RCC_OscInitStruct.PLL.PLLQ = 4;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }
  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV4;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV2;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_5) != HAL_OK)
  {
    Error_Handler();
  }
}

/**
  * @brief TIM2 Initialization Function
  * @param None
  * @retval None
  */
static void MX_TIM2_Init(void)
{

  /* USER CODE BEGIN TIM2_Init 0 */

  /* USER CODE END TIM2_Init 0 */

  TIM_MasterConfigTypeDef sMasterConfig = {0};
  TIM_OC_InitTypeDef sConfigOC = {0};

  /* USER CODE BEGIN TIM2_Init 1 */

  /* USER CODE END TIM2_Init 1 */
  htim2.Instance = TIM2;
  htim2.Init.Prescaler = 84;
  htim2.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim2.Init.Period = 999;
  htim2.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
  htim2.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_DISABLE;
  if (HAL_TIM_PWM_Init(&htim2) != HAL_OK)
  {
    Error_Handler();
  }
  sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim2, &sMasterConfig) != HAL_OK)
  {
    Error_Handler();
  }
  sConfigOC.OCMode = TIM_OCMODE_PWM1;
  sConfigOC.Pulse = 100;
  sConfigOC.OCPolarity = TIM_OCPOLARITY_HIGH;
  sConfigOC.OCFastMode = TIM_OCFAST_DISABLE;
  if (HAL_TIM_PWM_ConfigChannel(&htim2, &sConfigOC, TIM_CHANNEL_1) != HAL_OK)
  {
    Error_Handler();
  }
  if (HAL_TIM_PWM_ConfigChannel(&htim2, &sConfigOC, TIM_CHANNEL_2) != HAL_OK)
  {
    Error_Handler();
  }
  if (HAL_TIM_PWM_ConfigChannel(&htim2, &sConfigOC, TIM_CHANNEL_3) != HAL_OK)
  {
    Error_Handler();
  }
  if (HAL_TIM_PWM_ConfigChannel(&htim2, &sConfigOC, TIM_CHANNEL_4) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN TIM2_Init 2 */

  /* USER CODE END TIM2_Init 2 */
  HAL_TIM_MspPostInit(&htim2);

}

/**
  * @brief TIM3 Initialization Function
  * @param None
  * @retval None
  */
static void MX_TIM3_Init(void)
{

  /* USER CODE BEGIN TIM3_Init 0 */

  /* USER CODE END TIM3_Init 0 */

  TIM_Encoder_InitTypeDef sConfig = {0};
  TIM_MasterConfigTypeDef sMasterConfig = {0};

  /* USER CODE BEGIN TIM3_Init 1 */

  /* USER CODE END TIM3_Init 1 */
  htim3.Instance = TIM3;
  htim3.Init.Prescaler = 0;
  htim3.Init.CounterMode = TIM_COUNTERMODE_UP;
  htim3.Init.Period = 65535;
  htim3.Init.ClockDivision = TIM_CLOCKDIVISION_DIV1;
  htim3.Init.AutoReloadPreload = TIM_AUTORELOAD_PRELOAD_DISABLE;
  sConfig.EncoderMode = TIM_ENCODERMODE_TI12;
  sConfig.IC1Polarity = TIM_ICPOLARITY_RISING;
  sConfig.IC1Selection = TIM_ICSELECTION_DIRECTTI;
  sConfig.IC1Prescaler = TIM_ICPSC_DIV1;
  sConfig.IC1Filter = 0;
  sConfig.IC2Polarity = TIM_ICPOLARITY_RISING;
  sConfig.IC2Selection = TIM_ICSELECTION_DIRECTTI;
  sConfig.IC2Prescaler = TIM_ICPSC_DIV1;
  sConfig.IC2Filter = 0;
  if (HAL_TIM_Encoder_Init(&htim3, &sConfig) != HAL_OK)
  {
    Error_Handler();
  }
  sMasterConfig.MasterOutputTrigger = TIM_TRGO_RESET;
  sMasterConfig.MasterSlaveMode = TIM_MASTERSLAVEMODE_DISABLE;
  if (HAL_TIMEx_MasterConfigSynchronization(&htim3, &sMasterConfig) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN TIM3_Init 2 */

  /* USER CODE END TIM3_Init 2 */

}

/**
  * @brief UART4 Initialization Function
  * @param None
  * @retval None
  */
static void MX_UART4_Init(void)
{

  /* USER CODE BEGIN UART4_Init 0 */

  /* USER CODE END UART4_Init 0 */

  /* USER CODE BEGIN UART4_Init 1 */

  /* USER CODE END UART4_Init 1 */
  huart4.Instance = UART4;
  huart4.Init.BaudRate = 115200;
  huart4.Init.WordLength = UART_WORDLENGTH_8B;
  huart4.Init.StopBits = UART_STOPBITS_1;
  huart4.Init.Parity = UART_PARITY_NONE;
  huart4.Init.Mode = UART_MODE_TX_RX;
  huart4.Init.HwFlowCtl = UART_HWCONTROL_NONE;
  huart4.Init.OverSampling = UART_OVERSAMPLING_16;
  if (HAL_UART_Init(&huart4) != HAL_OK)
  {
    Error_Handler();
  }
  /* USER CODE BEGIN UART4_Init 2 */

  /* USER CODE END UART4_Init 2 */

}

/**
  * Enable DMA controller clock
  */
static void MX_DMA_Init(void)
{

  /* DMA controller clock enable */
  __HAL_RCC_DMA1_CLK_ENABLE();

  /* DMA interrupt init */
  /* DMA1_Stream2_IRQn interrupt configuration */
  HAL_NVIC_SetPriority(DMA1_Stream2_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(DMA1_Stream2_IRQn);
  /* DMA1_Stream4_IRQn interrupt configuration */
  HAL_NVIC_SetPriority(DMA1_Stream4_IRQn, 0, 0);
  HAL_NVIC_EnableIRQ(DMA1_Stream4_IRQn);

}

/**
  * @brief GPIO Initialization Function
  * @param None
  * @retval None
  */
static void MX_GPIO_Init(void)
{

  /* GPIO Ports Clock Enable */
  __HAL_RCC_GPIOH_CLK_ENABLE();
  __HAL_RCC_GPIOA_CLK_ENABLE();
  __HAL_RCC_GPIOC_CLK_ENABLE();

}

/* USER CODE BEGIN 4 */
void HAL_TIM_IC_CaptureCallback(TIM_HandleTypeDef *htim) //This callback function called when encoder pulses' rising or falling edge detected.
{
  /* Prevent unused argument(s) compilation warning */
  UNUSED(htim);

	cw_ccw = __HAL_TIM_IS_TIM_COUNTING_DOWN(&htim3); //This function returns the direction of rotation(1 for counter cw. 0 for cw.).
	
	if(cw_ccw==1){		//Pulses counted according to direction of rotation.
		
	encoder_x1--;
		
	}
	else if(cw_ccw==0){
		
	encoder_x1++;
		
	}
	
	///////////////position degree calculation///////////////////
	
	if(encoder_x1<0){	         //Position degree calculated using count value.
		
	shaft_count=-1*encoder_x1;
	position_degree=360*shaft_count/(reductor_rate*7);
	position_degree=fmod(position_degree,360);
	position_degree = round((360-position_degree)*10); 
	IntToStr5_position(position_degree, Position_Str);	
		
	}
	else if(encoder_x1 > 0){			//Position degree calculated using count value.
		
	shaft_count=encoder_x1;
	position_degree=360*shaft_count/(reductor_rate*7);
	position_degree=round(fmod(position_degree,360)*10);
	IntToStr5_position(position_degree, Position_Str);								
}
}
	void HAL_UART_RxCpltCallback(UART_HandleTypeDef *huart)	 //This callback function called when 1 byte data received from serial port.
{
  /* Prevent unused argument(s) compilation warning */
  UNUSED(huart);
	if(huart->Instance == UART4)
		{	
	if(RxBuffer[count_3]==114){	//Checks if 'r' received. If yes it makes current position 0.
	count_3=0;	
	htim3.Instance->CNT = 0;
	encoder_x1=0;	
	desired_angle=0; //Made 0 for prevent rotation to last desired_angle
	only_once=2;
	first_zero=0;
	RxBuffer[0]=0; RxBuffer[1]=0; RxBuffer[2]=0; RxBuffer[3]=0; RxBuffer[4]=0;
	goto end;	
	}
	count_3++;
		
	if(count_3==5){		//Looks whether 5byte data taken into RxBuffer array.
	count_3=0;
	htim3.Instance->CNT = 0;
	encoder_x1=0;
	if(RxBuffer[4]==112){ //Position Control Mode	//'p' corresponds 112 in ASCII and that indicate position mode selected.
	only_once=2;
	desired_angle=(RxBuffer[1]-48)*100+(RxBuffer[2]-48)*10+(RxBuffer[3]-48);	//Desired angle calculated according to ASCII table.
	
	if(RxBuffer[0]==45){	desired_angle *= -1;}	//'-' corresponds 45 in ASCII table and it means negative angle received.
	
	if(desired_angle==0){desired_angle=0.1;}		
	
	if (desired_angle>=360)
	{			//Actual value of received value calculated here(if necessary).		
	desired_angle=(int)desired_angle%360;	
	}
	else if (desired_angle<=-360)
		{
		desired_angle*=-1;
		desired_angle=(int)desired_angle%360;	
		desired_angle*=-1;
		}	
	
	first_zero=0;					        //Indicates new angle received.
}	
}
		end: HAL_UART_Receive_IT(&huart4,&RxBuffer[count_3],1);	
}
	}


	
/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  __disable_irq();
  while (1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */#define 
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
