int mx = 3;
int my = 4;
int mz = 2;

int px = 6;
int py = 8;
int pz = 4;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Serial.println("Hello World!");
  pinMode(LED_BUILTIN, OUTPUT);

}

void loop() {
  digitalWrite(LED_BUILTIN, HIGH);
  delay(2000);                       

  for (int i = 1; i <= 10; i++) {
    float res = calcareaOfCircle(i);
    Serial.println(res);
  }
  opdrachtB();
  
  digitalWrite(LED_BUILTIN, LOW); 
  delay(4000);                   
}

// Calculates and returns area of circle
float calcareaOfCircle(int radius) {
  float areaOfCircle = radius * radius * PI;
  return areaOfCircle;
}

float opdrachtB() {
  float sqR = sq(px-mx) + sq(py-my) + sq(pz-mz);
  Serial.print(sqrt(sqR));
}
