int pwmPin11 = 11;

void setup() {
  // put your setup code here, to run once:
  pinMode(pwmPin11, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  analogWrite(pwmPin11, 0);
  delay(500);
  analogWrite(pwmPin11, 25);
  delay(500);
  analogWrite(pwmPin11, 50);
  delay(500);
  analogWrite(pwmPin11, 75);
  delay(500);
  analogWrite(pwmPin11, 100);
  delay(500);
  analogWrite(pwmPin11, 125);
  delay(500);
  analogWrite(pwmPin11, 150);
  delay(500);
  analogWrite(pwmPin11, 175);
  delay(500);
  analogWrite(pwmPin11, 200);
  delay(500);
  analogWrite(pwmPin11, 225);
  delay(500);
  analogWrite(pwmPin11, 250);
  delay(2000);

}
