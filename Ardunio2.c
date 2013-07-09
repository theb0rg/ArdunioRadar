#define echoPin 7 // Echo Pin
﻿#define trigPin 8 // Trigger Pin
 //#define LEDPin 13 // Onboard LED

void setup() {
	// initialize serial communication:
	Serial.begin(9600);
	pinMode(trigPin, OUTPUT);
        pinMode(echoPin, INPUT);
        //pinMode(LEDPin, OUTPUT); // Use LED indicator (if required)
}

void loop()
{
	long cm = microsecondsToCentimeters(Scan());
	Serial.println(cm);
	delay(50);
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
