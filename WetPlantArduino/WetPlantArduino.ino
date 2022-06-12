#include <DHT.h>
#include <DHT_U.h>
#include <Adafruit_Sensor.h>
#define LAMP 7   //high es prendido
#define BOM 3   //low es prendido
#define VENT 10  //low es prendido
#define LDR A1
#define sensHum A0
#define DHTTYPE DHT22
#define lampState states[0]
#define bomState states[1]
#define ventState states[2]
const int DHTPin = 8;
unsigned long previousMillis = 0, currentMillis;
const long interval = 1000;
const int lightThresh = 400, humThresh = 50, tempThresh = 30;
DHT dht(DHTPin, DHTTYPE);
int humidity, temp;
int humVal, humPrcnt, LIGHT;
void setup() {
  Serial.begin(9600);
  dht.begin();
  pinMode(LDR, INPUT);
  pinMode(LAMP, OUTPUT);
  pinMode(BOM, OUTPUT);
  pinMode(VENT, OUTPUT);
  digitalWrite(BOM, HIGH);
  digitalWrite(VENT, HIGH);
  digitalWrite(LAMP, LOW);
  //delay(15000);
}
void loop() {
  currentMillis = millis();
  humidity = round(dht.readHumidity()), temp = round(dht.readTemperature(;
  humVal = analogRead(sensHum), humPrcnt = map(humVal, 1023, 0, 0, 100);
  LIGHT = analogRead(LDR);
  int vals[3] = {LIGHT, humPrcnt, temp};
  int threshs[3] = {lightThresh, humThresh, tempThresh};
  int states[3];
  if (isnan(humidity) || isnan(temp)) {
    Serial.println("Failed to read from DHT sensor!");
    delay(500);
    return;
  }
  Serial.print("LDR: ");
  //delay(200);
  Serial.print(LIGHT);
  //delay(200);
  Serial.print(" SensHum: ");
  //delay(200);
  Serial.print(humPrcnt);
  //delay(200);
  Serial.print(" DHT22 ");
  //delay(200);
  Serial.print(temp);
  Serial.println("");
  //delay(200);

  if (Serial.available() > 0) {

    //int config = Serial.read();
    for (int i = 0; i<3; i++)
    {
      if (vals[i] >= threshs[i]) 
      {
        states[i] = HIGH;
      }
      if (states[i] == HIGH && currentMillis - previousMillis >= interval && vals[i] < threshs[i])
      {
        previousMillis = currentMillis;
        states[i] = LOW;
      }
    }
    digitalWrite(BOM, bomState);
    digitalWrite(VENT, ventState);
    digitalWrite(LAMP, lampState);
  }
}
