// Arduino pinnnen configureren
const int trigPin = 12;
const int echoPin = 11;

const int ledPin10 = 10;
const int ledPin9 = 9;

void setup() {
    // Zet IN- en UITgang voor digitale pinnen
    pinMode(trigPin, OUTPUT);
    pinMode(echoPin, INPUT);
    pinMode(ledPin10, OUTPUT);
    pinMode(ledPin9, OUTPUT);
    // Seriele poort aanzetten
    Serial.begin(9600);
}
 
void loop()
{
    // Variabelen configureren
    long echo, distanceCm;
 
    // De sensor wordt getriggerd bij 10 us, geef eerst een lage puls om een schone hoge puls te krijgen
    digitalWrite(trigPin, LOW);
    delayMicroseconds(2);
    digitalWrite(trigPin, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin, LOW);
 
    // Wacht op een hoge puls en meet de tijd
    echo = pulseIn(echoPin, HIGH);
    distanceCm = distance(echo);
    ledController(distanceCm);
    // Print de gegevens naar de seriële monitor
    Serial.print("afstand in cm: ");
    Serial.print(distanceCm);
    Serial.println();
    delay(1000);
}

int distance(int echo) {
    int cm = echo / 29 / 2;

    if (cm < 200) {
      return cm;
    }
    return -1;
}

void ledController(int cm) {
  if (cm < 100 && cm > 0) {
    digitalWrite(ledPin10, HIGH);
    digitalWrite(ledPin9, LOW);
  } else if (cm > 100 && cm < 200) {
    digitalWrite(ledPin10, HIGH);
    digitalWrite(ledPin9, HIGH);
  } else {
    digitalWrite(ledPin10, LOW);
    digitalWrite(ledPin9, LOW);
  }
}
