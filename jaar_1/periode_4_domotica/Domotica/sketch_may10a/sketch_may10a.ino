#include <Servo.h>

Servo myservo;  // create servo object to control a servo
int potpin = 0;  // analog pin used to connect the potentiometer
int val;    // variable to read the value from the analog pin

int sensorPin1 = A0;    // select the input pin for the potentiometer
int sensorPin2 = A1;    // select the input pin for the potentiometer
int sensorPin3 = A2;    // select the input pin for the potentiometer

int ledPin12 = 12;      // select the pin for the LED
int ledPin11 = 11;      // select the pin for the LED
int ledPin10 = 10;      // select the pin for the LED

int sensorValue1 = 0;  // variable to store the value coming from the sensor
int sensorValue2 = 0;  // variable to store the value coming from the sensor
int sensorValue3 = 0;  // variable to store the value coming from the sensor


void setup() {
  // declare the ledPin as an OUTPUT:
  Serial.begin(9600);
  pinMode(ledPin12, OUTPUT);
  pinMode(ledPin11, OUTPUT);
  pinMode(ledPin10, OUTPUT);
}

void loop() {
  // read the value from the sensor:
  sensorValue1 = analogRead(sensorPin1);
  sensorValue2 = analogRead(sensorPin2);
  sensorValue3 = analogRead(sensorPin3);

//  Serial.println(sensorValue1);
//  Serial.println(sensorValue2);
//  Serial.println(sensorValue3);

  if (sensorValue1 == 0 || sensorValue1 == 1023) {
    digitalWrite(ledPin12, HIGH);   // turn the LED on (HIGH is the voltage level)
    delay(400);                         // wait for a second
    digitalWrite(ledPin12, LOW);    // turn the LED off by making the voltage LOW
    delay(400);                       // wait for a second
  }
  if (sensorValue2 == 0 || sensorValue2 == 1023) {
    digitalWrite(ledPin11, HIGH);   // turn the LED on (HIGH is the voltage level)
    delay(400);                         // wait for a second
    digitalWrite(ledPin11, LOW);    // turn the LED off by making the voltage LOW
    delay(400);                         // wait for a second
  }
  if (sensorValue3 == 0) {
    digitalWrite(ledPin10, HIGH);   // turn the LED on (HIGH is the voltage level)
    delay(400);                         // wait for a second
    digitalWrite(ledPin10, LOW);    // turn the LED off by making the voltage LOW
    delay(400);                          // wait for a second
  }
}
