 #define LAMP 7   //high es prendido
 #define BOMB 3 //low es prendido
 #define VENT 10 //low es prendido
 #include <Adafruit_Sensor.h>
 #include <DHT.h>
 #include <DHT_U.h>
 #define DHTTYPE DHT21
 const int DHTPin = 8;
 int LIGHT = 0;
 int pSensorHA = A0;
 int lectura;
 DHT dht(DHTPin, DHTTYPE);
void setup()
{
   Serial.begin(9600);
   pinMode(A1, INPUT);
   pinMode(7, OUTPUT);
   pinMode(10, OUTPUT);
   pinMode(3, OUTPUT);
   dht.begin();
   digitalWrite(3, HIGH);
   digitalWrite(10, HIGH);
   digitalWrite(7, LOW);
   delay(15000);
   
}
void loop() 
{  
   float h = dht.readHumidity();
   float t = dht.readTemperature();
   int lectura = analogRead(A0);
   int lecturaPorcentaje = map(lectura, 1023, 0, 0, 100);
   LIGHT = analogRead (A1);

   if (isnan(h) || isnan(t)) 
   {
      Serial.println("Failed to read from DHT sensor!");
      delay(500);
      return;
   }

  lectura = analogRead(pSensorHA);

  Serial.print("LDR: ");
  delay(200);
  Serial.print(LIGHT);
  delay(200);
  Serial.print(" SensHum: ");
  delay(200);
  Serial.print(lecturaPorcentaje);
  delay(200);
  Serial.print(" DHT22 ");
  delay(200);
  Serial.print(t);
  Serial.println("");
  delay(200);

   if (Serial.available() > 0)
   {
    
      int option = Serial.read();
      
      if (option == 'L')
      {
         digitalWrite(LAMP, HIGH);
         delay(10000);
         digitalWrite(LAMP, LOW);

      }
      
      if (option == 'B')
      {
        digitalWrite(BOMB, LOW);
        delay(10000);
        digitalWrite(BOMB, HIGH);
      }
      
      if (option == 'V')
      {
        digitalWrite(VENT, LOW);
        delay(10000);
        digitalWrite(VENT, HIGH);
      }
      
      if(option == 'A') //L+B
      {
        digitalWrite(LAMP, HIGH);
        digitalWrite(BOMB, LOW);
        delay(2000);
        digitalWrite(LAMP, LOW);
        digitalWrite(BOMB, HIGH);
        
      }
      
      if (option == 'C')//L+V
      {
        digitalWrite(LAMP, HIGH);
        digitalWrite(VENT, LOW);
        delay(10000);
        digitalWrite(LAMP, LOW);
        digitalWrite(VENT, HIGH);
      }
      
      if (option == 'D')//B+V
      {
        digitalWrite(BOMB, LOW);
        digitalWrite(VENT, LOW);
        delay(10000);
        digitalWrite(BOMB, HIGH);
        digitalWrite(VENT, HIGH);
      }
      if (option == 'X')//L+B+V
      {
        digitalWrite(LAMP, HIGH);
        digitalWrite(BOMB, LOW);
        digitalWrite(VENT, LOW);
        delay(10000);
        digitalWrite(LAMP, LOW);
        digitalWrite(BOMB, HIGH);
        digitalWrite(VENT, HIGH);
      } 
  }
}  
