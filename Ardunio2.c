#include <Servo.h>

#define echoPin 7 // Echo Pin
﻿#define trigPin 8 // Trigger Pin

const short DegreesToMove = 25;
const short ExtraDelay    = 0;
const short ServoMax = 160;
const short ServoMin = 10;
short CurrentPosition = 90;
short CurrentDirection = 1;

Servo ScannerModule;
Servo LeftEngine;
Servo RightEngine;

void setup() {
	//Initialize serial
	Serial.begin(9600);

	//Initialize scanner
	ScannerModule.attach(4);
	pinMode(trigPin, OUTPUT);
    pinMode(echoPin, INPUT);

	//Initialize warpengine
    //LeftEngine.attach(0);
    //RightEngine.attach(1);

	ScannerModule.write(CurrentPosition);
	delay(150);
}

void loop()
{
	//Go to next position.
	NextPosition(DegreesToMove);

	//Wait for the servo to go to position.
	delay(CalculateMicrosecondsServo(DegreesToMove));

	//Scan and convert to centimeters.
	long cm = microsecondsToCentimeters(Scan());

	//Write value to serialport.
	Serial.println(cm + ";" + CurrentPosition);

	//Optional extra delay:
	Delay(ExtraDelay);
}

//Subjective analysis is 300ms for 160 degrees. 300 / 160 = 1,875 MS Per degree?
int CalculateMicrosecondsServo(short degrees)
{
	return 1.875 * degrees;
}


void NextPosition(int degrees)
{
	if(CurrentDirection == 1)
	{	

		if(CurrentPosition < ServoMax)
		{
			CurrentPosition += degrees;
			ScannerModule.write(CurrentPosition);

			if(CurrentPosition > ServoMax)
			{
				ScannerModule.write(ServoMax);
				delay(CalculateMicrosecondsServo((degrees - (degrees - CurrentPosition + ServoMax))));
				ScannerModule.write(ServoMax - (degrees - CurrentPosition + ServoMax) );
				CurrentDirection = 0;

			}
			else{
				ScannerModule.write(CurrentPosition);
			}
		}
	}
	else if(CurrentDirection == 0){
		if(CurrentPosition > ServoMin)
		{
			CurrentPosition -= degrees;
			ScannerModule.write(CurrentPosition);

			if(CurrentPosition < ServoMin)
			{
				ScannerModule.write(ServoMin);
				delay(CalculateMicrosecondsServo((degrees - CurrentPosition - ServoMin) - ServoMin));
				ScannerModule.write(degrees - CurrentPosition - ServoMin);
				CurrentDirection = 1;

			}
			else{
				ScannerModule.write(CurrentPosition);
			}
		}
	}
}

long Scan()
{
	digitalWrite(trigPin, LOW); 
 	delayMicroseconds(2); 

 	digitalWrite(trigPin, HIGH);
 	delayMicroseconds(5); 
 
 	digitalWrite(trigPin, LOW);

	return pulseIn(echoPin, HIGH,38000);
}

long microsecondsToCentimeters(long microseconds)
{
	// The speed of sound is 340 m/s or 29 microseconds per centimeter.
	// The ping travels out and back, so to find the distance of the
	// object we take half of the distance travelled.
	return microseconds / 29 / 2;
}
