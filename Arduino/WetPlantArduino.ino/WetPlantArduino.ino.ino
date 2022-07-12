#include <DHT.h>
#include <DHT_U.h>
#include <Adafruit_Sensor.h>
#define LAMP 9
#define BOM 10
#define VENT 11
#define LDR A1
#define sensHum A0
#define DHTTYPE DHT22
#define lampState states[0]
#define bomState states[1]
#define ventState states[2]
#define lightThresh 60
#define humThresh 40
#define tempThresh 30
const int DHTPin = 8;
unsigned long previousMillis = 0, currentMillis;
const long interval = 1000, PrintInterval = 500;
DHT dht(DHTPin, DHTTYPE);
int vals[3];
int threshs[3] = {lightThresh, humThresh, tempThresh};
int states[3];
void setup() {
  Serial.begin(9600);
  dht.begin();
  pinMode(LDR, INPUT);
  pinMode(sensHum, INPUT);
  pinMode(LAMP, OUTPUT);
  pinMode(BOM, OUTPUT);
  pinMode(VENT, OUTPUT);
  digitalWrite(BOM, LOW);
  digitalWrite(VENT, LOW);
  digitalWrite(LAMP, LOW);
}
void loop() {
  currentMillis = millis();
  vals[0] = map(analogRead(LDR), 0, 1023, 0, 100); // Luz
  vals[1] = map(analogRead(sensHum), 1023, 0, 0, 100); // Humedad
  vals[2] = round(dht.readTemperature()); // Temp
  if (isnan(vals[2]))
  {
    Serial.println("Failed to read from DHT sensor!");
    delay(500);
    return;
  }
  if(currentMillis - previousMillis >= PrintInterval)
  {
    Serial.print(vals[0]);
    Serial.print(" ");
    Serial.print(vals[1]);
    Serial.print(" ");
    Serial.print(vals[2]);
    Serial.print(" ");
    Serial.print(states[2]);
    Serial.print(" ");
    Serial.print(states[0]);
    Serial.print(" ");
    Serial.println(states[1]);
    previousMillis = currentMillis;
  }
  vals[0] = map(vals[0], 0, 100, 100, 0);
  vals[1] = map(vals[1], 0, 100, 100, 0);
  for (int i = 0; i<3; i++)
  {
    if (vals[i] >= threshs[i]) 
    {
      states[i] = HIGH;
      delay(200);
    }
    if (states[i] == HIGH && vals[i] < threshs[i])
    {
      states[i] = LOW;
      delay(200);
    }
  }
  digitalWrite(BOM, bomState);
  digitalWrite(VENT, ventState);
  digitalWrite(LAMP, lampState);
}
