
int sensorPin1 = A0;    // select the input pin for the potentiometer
int sensorPin2 = A1;    // select the input pin for the potentiometer
int sensorPin3 = A2;    // select the input pin for the potentiometer

int sensorValue1 = 0;  // variable to store the value coming from the sensor
int sensorValue2 = 0;  // variable to store the value coming from the sensor
int sensorValue3 = 0;  // variable to store the value coming from the sensor

byte pins[] = {8, 9, 10, 11, 12, 13};

void setup() {
  // declare the ledPin as an OUTPUT:
  for(int i = 0; i < 6; i++) {
    pinMode(pins[i], OUTPUT);
  }
  Serial.begin(9600);
}

void loop() {
  // read the value from the sensor:
  sensorValue1 = analogRead(sensorPin1);
  sensorValue2 = analogRead(sensorPin2);
  sensorValue3 = analogRead(sensorPin3);

  int test = map(sensorValue1, 0, 1023, 0, 250);

  writeValToLed(test, sensorValue2, sensorValue3);

  delay(1);
    
//    if (sensorValue1 < 100) {
//      blinkLeds(5);
//    }
//
//    if (sensorValue1 < 200) {
//      blinkLeds(4);
//    }
//    
//    if (sensorValue1 < 300) {
//      blinkLeds(3);
//    }
//
//    if (sensorValue1 < 400) {
//      blinkLeds(2);
//    }
//
//    if (sensorValue1 < 500) {
//      blinkLeds(1);
//    }
//
//    if (sensorValue1 > 500 || sensorValue1 < 600) {
//      blinkLeds(0);
//    }
//
//    if (sensorValue1 > 600) {
//      blinkLeds(1);
//    }
//
//    if (sensorValue1 > 700) {
//      blinkLeds(2);
//    }
//
//    if (sensorValue1 > 800) {
//      blinkLeds(3);
//    }
//
//    if (sensorValue1 > 900) {
//      blinkLeds(4);
//    }
//
//    if (sensorValue1 > 1000) {
//      blinkLeds(5);
//    }

//  if (sensorValue1 == 0 || sensorValue1 == 1023) {
//    digitalWrite(ledPin12, HIGH);   // turn the LED on (HIGH is the voltage level)
//    delay(400);                         // wait for a second
//    digitalWrite(ledPin12, LOW);    // turn the LED off by making the voltage LOW
//    delay(400);                       // wait for a second
//  }
//  if (sensorValue2 == 0 || sensorValue2 == 1023) {
//    digitalWrite(ledPin11, HIGH);   // turn the LED on (HIGH is the voltage level)
//    delay(400);                         // wait for a second
//    digitalWrite(ledPin11, LOW);    // turn the LED off by making the voltage LOW
//    delay(400);                         // wait for a second
//  }
//  if (sensorValue3 == 0) {
//    digitalWrite(ledPin10, HIGH);   // turn the LED on (HIGH is the voltage level)
//    delay(400);                         // wait for a second
//    digitalWrite(ledPin10, LOW);    // turn the LED off by making the voltage LOW
//    delay(400);                          // wait for a second
//  }
}

void blinkLeds (int anmount){
    for(int i = 0; i < 6; i++) { 
        if (i < anmount) {
          digitalWrite(pins[i], HIGH);
        } else {
          digitalWrite(pins[i], LOW);
        }
  }
}

void writeValToLed (int analog_1, int analog_2, int analog_3) {
  Serial.println(analog_1);
  if (analog_1 < 120) {
    for(int i = 0; i < 6; i++) { 
        if (i < (analog_1 / 20)) {
          digitalWrite(pins[i], HIGH);
          PORTB = 0x[i];
        } else {
          digitalWrite(pins[i], LOW);
      }
    }
  } else {
    PORTB = 0x0;
  }
}
