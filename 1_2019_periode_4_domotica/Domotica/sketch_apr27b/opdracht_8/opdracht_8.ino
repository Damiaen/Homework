int ledPin13 = 13;
int ledPin12 = 12;
int ledPin11 = 11;
int ledPin10 = 10;
int ledPin9 = 9;
int ledPin8 = 8;

void setup() {
  // put your setup code here, to run once:
//  pinMode(ledPin13, OUTPUT);
//  pinMode(ledPin12, OUTPUT);
//  pinMode(ledPin11, OUTPUT);
//  pinMode(ledPin10, OUTPUT);
//  pinMode(ledPin9, OUTPUT);
//  pinMode(ledPin8, OUTPUT);

  DDRB = 0x3F;

}

void loop() {
//    digitalWrite(ledPin13, HIGH);
//    delay(500);
//    digitalWrite(ledPin13, LOW);
//    delay(500);
//    digitalWrite(ledPin12, HIGH);
//    delay(500);
//    digitalWrite(ledPin12, LOW);
//    delay(500);
//    digitalWrite(ledPin11, HIGH);
//    delay(500);
//    digitalWrite(ledPin11, LOW);
//    delay(500);
//    digitalWrite(ledPin10, HIGH);
//    delay(500);
//    digitalWrite(ledPin10, LOW);
//    delay(500);
//    digitalWrite(ledPin9, HIGH);
//    delay(500);
//    digitalWrite(ledPin9, LOW);
//    delay(500);
//    digitalWrite(ledPin8, HIGH);
//    delay(500);
//    digitalWrite(ledPin8, LOW);
//    delay(500);
//  
//    digitalWrite(ledPin13, HIGH);
//    digitalWrite(ledPin12, HIGH);
//    digitalWrite(ledPin11, HIGH);
//    digitalWrite(ledPin10, HIGH);
//    digitalWrite(ledPin9, HIGH);
//    digitalWrite(ledPin8, HIGH);
//    delay(1000);
//    digitalWrite(ledPin13, LOW);
//    digitalWrite(ledPin12, LOW);
//    digitalWrite(ledPin11, LOW);
//    digitalWrite(ledPin10, LOW);
//    digitalWrite(ledPin9, LOW);
//    digitalWrite(ledPin8, LOW);
//    delay(1000);

    //  Knipperen van ledjes
    PORTB = 0x1;
    delay(500);
    PORTB = 0x0; 
    delay(500);

    PORTB = B00000010;
    delay(500);
    PORTB = 0x0; 
    delay(500);

    PORTB = B00000100;
    delay(500);
    PORTB = 0x0; 
    delay(500);

    PORTB = B00001000;
    delay(500);
    PORTB = 0x0; 
    delay(500);

    PORTB = B00010000;
    delay(500);
    PORTB = 0x0; 
    delay(500);

    PORTB = 0x20;
    delay(500);
    PORTB = 0x0; 
    delay(500);

    // Alle ledjes aan en uit doen
    PORTB = 0x3F;
    delay(1000);
    PORTB = 0x0; 
    delay(1000);

}
