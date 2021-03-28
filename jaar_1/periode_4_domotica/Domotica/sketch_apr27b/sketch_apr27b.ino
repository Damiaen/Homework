int ledPin12 = 12;

// the setup function runs once when you press reset or power the board
void setup() {
  // initialize digital pin LED_BUILTIN as an output.
  pinMode(LED_BUILTIN, OUTPUT);
  Serial.begin(9600);
  Serial.println("Hello World!");
  pinMode(ledPin12, OUTPUT);
}

// the loop function runs over and over again forever
void loop() {
  digitalWrite(ledPin12, HIGH);   // turn the LED on (HIGH is the voltage level)
  delay(4000);                       // wait for a second

  for (int i = 1; i <= 10; i++) {
      float res = calcareaOfCircle(i);
      Serial.println(res);
  }

  digitalWrite(ledPin12, LOW);    // turn the LED off by making the voltage LOW
  delay(4000);                       // wait for a second

//  digitalWrite(ledPin12, HIGH);   // turn the LED on (HIGH is the voltage level)
//  delay(5000);                       // wait for a second
//  digitalWrite(ledPin12, LOW);    // turn the LED off by making the voltage LOW
//  delay(5000);                       // wait for a second
}

// Calculates and returns area of circle
float calcareaOfCircle(int radius) {
  float areaOfCircle = radius * radius * PI;
  return areaOfCircle;
}
