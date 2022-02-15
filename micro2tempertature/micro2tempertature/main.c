/*
 * micro2tempertature.c
 *
 * Author : Guillermo J. Ramires
 */ 
#define F_CPU 16000000UL
#define BAUD 9600
#define BAUD_pre ((F_CPU/16/BAUD) - 1)

#include <avr/io.h>
#include <stdio.h>

//Custom libraries
#include "TempAndCommsLibraries/ds18b20_2021.h" //temperature sensor
#include "TempAndCommsLibraries/i2c_2021.h" //I2C  
#include "TempAndCommsLibraries/serial_2021.h" //UART

#define GPIOA 0x12				//---General Purpose I/O Register A
#define GPIOB 0x13				//---General Purpose I/O Register B

int calcTemp;
unsigned char calcTemps[2];
char newLineUSART = '\n';

int main(void)
{
	// Sets up UART with BAUD 9600
    USART_init();
															//char buffer[6];
    
    // Sets up I2C's GPIO as output
    i2c_init();
    mcp_write(MCP23017_IODIRA, 0x00);
    
    // Sets up DS18B20
    DDRB = 0x01;
    PORTB |= (1 << PORTB0);
    uint8_t temperature[2];
    uint8_t temp;
    uint8_t half;
	
    while (1) {
	    // Tells sensor to read temperature
	    ds_init();
	    ds_writebyte(SKIP_ROM);
	    ds_writebyte(CONVERT_T);
		
	    // Waits for conversion to complete
	    while(!ds_readbit());
	    
	    // Reads temperature from scratchpad
	    ds_init();
	    ds_writebyte(SKIP_ROM);
	    ds_writebyte(READ_SCRATCHPAD);
	    temperature[0] = ds_readbyte();
	    temperature[1] = ds_readbyte();
					
	    // Sends reset to stop reading scratchpad
	    ds_init(); //resets
	    
		// Saves temperature accordingly and formats into string
		temp = temperature[0] >> 4;
		temp |= (temperature[1] & 0x7) << 4;
		half = temperature[0] & 0xF;
		half *= 625;
		if (half > 99)
		{
			half /= 10;
		}
		
		//Converts integer to char
		calcTemp = temp;
		for(int i = 0; i < sizeof(calcTemps); i++){			
			
			int mod = calcTemp % 10;  //split last digit from number
			
			calcTemps[i] = mod + '0'; //print the digit.
			calcTemp = calcTemp / 10;    //divide num by 10. num /= 10 also a valid one		
		}
		
	    //Transmits temp to serial
		USART_send(calcTemps[1]);
		USART_send(calcTemps[0]);
		USART_send(newLineUSART);
		
		// Transmits temperature to I2C
	    switch (temp){ 
		    case 18:
		    mcp_write(GPIOA,0b00010000);
		    break;
		    case 19:
		    mcp_write(GPIOA,0b00110000);
		    break;
		    case 20:
		    mcp_write(GPIOA,0b01110000);
		    break;
		    case 21:
		    mcp_write(GPIOA,0b11110000);
		    break;
		    case 22:
		    mcp_write(GPIOB,0b00000001);
		    break;
		    case 23:
		    mcp_write(GPIOB,0b00000011);
		    break;
		    case 24:
		    mcp_write(GPIOB,0b00000111);
		    break;
		    default:
		    mcp_write(GPIOA,0b10101010);
		    break;
	    }
	    _delay_ms(1000); // Waits 10 seconds between readings
    } 
}




