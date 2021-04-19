#include <Servo.h>
Servo servo1;
int analogPin = 0;
int val;
  
void setup() {
   Serial.begin(9600);
   servo1.attach(9);
}

void loop() {
  val = analogRead(analogPin);
  val = map(val, 0, 1023, 0, 179);
  Serial.println(val);
  servo1.write(val);
  delay(15);
}
