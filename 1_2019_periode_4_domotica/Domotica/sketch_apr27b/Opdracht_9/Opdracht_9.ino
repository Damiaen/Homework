String s1 = "0123456789"; // a constant String
String c1 = "a"; // a constant String
String s2 = String("bcdefghij"); // a String object
String c2 = String(c1); // a String object

int state;
byte pins[] = {8, 9, 10, 11, 12, 13};

void setup() {
  DDRD = 0xFF;
  Serial.begin(9600);
  Serial.println(s1);
  Serial.println(c1);
  Serial.println(s2);
  Serial.println(c2);
  Serial.println(c1 + s2);
}

void loop() {
//  Serial.println(s1[0]);
//  Serial.println(s1[s1.length() -1]);
  for (int i = 0; i <= s1.length() - 1; i++) {
    Serial.print(s1[i]);
    Serial.print(" ");
    Serial.print(int(s1[i]));
    Serial.print(" ");
    Serial.print(s1[i], HEX);
    Serial.print(" ");
    Serial.print(s1[i], BIN);
    Serial.println(" ");
    delay(1000);
    // Turn leds on based on binary value
    blinkLeds(String(s1[i], BIN));
  }
  // Turn all leds off again and repeat untill length of string has been met
  PORTB = 0x0; 
  delay(2000);

}

void blinkLeds(String bin) {
  for(int i = 0; i <= 5; i++) { 
      if(bin[i] == '0') state = LOW;
      if(bin[i] == '1') state = HIGH;
      Serial.println(state);
      digitalWrite(pins[i], state);
    }
  delay(1000);
}
