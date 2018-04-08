#include <Servo.h>

Servo myservo;

int val;

void setup (){
  Serial.begin(9600);
  myservo.attach(9);
  
  
  
  }

  void loop(){

    
  }


void serialEvent(){

  val  = Serial.parseInt();
  if(val= 0){

    myservo.write(val);
  }
  
}



