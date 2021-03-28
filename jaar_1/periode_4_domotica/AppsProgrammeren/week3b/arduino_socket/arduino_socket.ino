#include <SPI.h>
#include <Ethernet.h>

#define sensorPin     0   // sensor on channel A0 

// network configuration.  gateway and subnet are optional.
byte mac[] = { 0xDE, 0xAD, 0xBE, 0xEF, 0xFE, 0xED };  
IPAddress ip(192, 168, 1, 10);  //fallback ipadress
EthernetServer server(8000);   //server port

void setup()
{
  Serial.begin(9600);
  //no dhcp >> use ip given above
  if (Ethernet.begin(mac) == 0) {
    Serial.println("No DHCP");
    Ethernet.begin(mac, ip);
  }
  
  server.begin();
  Serial.print("Server ip is: "); Serial.println(Ethernet.localIP());
}

void loop()
{
int sensorValue = analogRead(sensorPin);
  
  // if an incoming client connects, there will be bytes available to read:
  EthernetClient client = server.available();
  while(client.connected()){
    if(client.available()){
      char buffer[256];
      sprintf(buffer,"<TEMP> %d",sensorValue);
      Serial.println(buffer);
      server.write(buffer);
      client.stop();
    } 
  }
}
