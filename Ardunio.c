#include <Servo.h>
#include <NewPing.h>

#define LeftMotorForward 6
#define LeftMotorBackward 5
#define RightMotorForward 8
#define RightMotorBackward 9
#define USTrigger 3
#define USEcho 2
#define MaxDistance 100
#define LED 13

Servo servo;
NewPing sonar(USTrigger, USEcho, MaxDistance);

unsigned int duration;
unsigned int distance;
unsigned int FrontDistance;
unsigned int LeftDistance;
unsigned int RightDistance;
unsigned int Time;

void setup()                                           
{
  pinMode(LeftMotorForward, OUTPUT);
  pinMode(LeftMotorBackward, OUTPUT);
  pinMode(RightMotorForward, OUTPUT);
  pinMode(RightMotorBackward, OUTPUT);
  pinMode(LED, OUTPUT);
  servo.attach(4);                                    //The servo pin 4
}

void loop()                                          
{
  delay(500);
  servo.write(90);                                    //Rotate  servo to face front                 
  scan();                                             //Go to scan function
  FrontDistance = distance;                           //FrontDistance =distance returned from scan function

  if(FrontDistance > 40 || FrontDistance == 0)      
  {
   moveForward();                                     //Go to moveForward function
  }
  else                                               
  {
    moveStop();                                       //Go to moveStop function
    servo.write(167);                                
    delay(500);                                      
    scan();                                           //Go to scan function
    LeftDistance = distance;
    servo.write(0);                                
    delay(500);                                      
    scan();                                           //Go to  scan function
    RightDistance = distance;                       
    if(RightDistance < LeftDistance)                
    {
     moveLeft();                                    
     delay(500);                                    
    }
    else if(LeftDistance < RightDistance)            
    {
     moveRight();                                    
     delay(500);                                   
    }
    else                                             
    {
     moveBackward();                                 
     delay(200);                                     
     moveRight();                                    
     delay(200);                                     
    }
  }
}

void moveForward()                                  
{
  digitalWrite(LeftMotorBackward, LOW);
  digitalWrite(LeftMotorForward, HIGH);
  digitalWrite(RightMotorBackward, LOW);
  digitalWrite(RightMotorForward, HIGH);
}

void moveBackward()                                 
{
  digitalWrite(LeftMotorForward, LOW);
  digitalWrite(LeftMotorBackward, HIGH);
  digitalWrite(RightMotorForward, LOW);
  digitalWrite(RightMotorBackward, HIGH);
}

void moveLeft()                                    
{
  digitalWrite(LeftMotorForward, LOW);
  digitalWrite(LeftMotorBackward, HIGH);
  digitalWrite(RightMotorBackward, LOW);
  digitalWrite(RightMotorForward, HIGH);
 
}

void moveRight()                                  
{
  digitalWrite(LeftMotorBackward, LOW);
  digitalWrite(LeftMotorForward, HIGH);
  digitalWrite(RightMotorForward, LOW);
  digitalWrite(RightMotorBackward, HIGH);
}

void moveStop()                                    
{
  digitalWrite(LeftMotorBackward, LOW);
  digitalWrite(LeftMotorForward, LOW);
  digitalWrite(RightMotorForward, LOW);
  digitalWrite(RightMotorBackward, LOW);
}
void scan()                                      
{
  delay(50);
  Time = sonar.ping();
  distance = Time / US_ROUNDTRIP_CM;
}
