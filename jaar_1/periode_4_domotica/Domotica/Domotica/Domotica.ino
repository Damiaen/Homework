#define RFPin 3 // pin to control RF-transmitter
#define unitCode 32122670 // replace with your own code
#include <NewRemoteTransmitter.h> // Remote Control, APA3,
NewRemoteTransmitter apa3Transmitter(unitCode, RFPin, 260, 3);

void setup() {
  // put your setup code here, to run once:
  pinMode(RFPin, OUTPUT); // RFPin is output
}

void loop() {
  // put your main code here, to run repeatedly:
  apa3Transmitter.sendUnit(0, true); // switch on unit 0
  delay(1000);
  apa3Transmitter.sendUnit(0, false);// switch off unit 0
  delay(1000);
}
