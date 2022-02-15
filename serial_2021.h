/* UART Self made Library
Author: Guillermo J. Ramires
Student nr: 464852 */
#define F_CPU 16000000UL
#define BAUD 9600
#define BAUD_pre ((F_CPU/16/BAUD) - 1)

//volatile bool transmitComplete = false;

void USART_init(void)
{
	UBRR0H = (BAUD_pre>>8);
	UBRR0L = (BAUD_pre);
	UCSR0B = (1<<TXEN0) | (1<<TXCIE0); //status n ctrl register tx
	UCSR0C = (1<<UCSZ00) | (1<<UCSZ01); //sets to 8bit
}

void USART_send( unsigned char data[] )
{	
	while(!(UCSR0A & (1<<UDRE0)));
	UDR0 = data;
}
