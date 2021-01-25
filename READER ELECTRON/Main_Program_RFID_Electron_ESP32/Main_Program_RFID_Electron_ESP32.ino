#include "Arduino.h"    //library default
#include <WiFi.h>     //library untuk koneksi dengan wifi
#include <WiFiClient.h> //library untuk menjadikan esp32 sebagai client
#include <PubSubClient.h> //library mqtt

const char* ssid = "M2fleet";
const char* password = "logika9119";
const char* mqtt_server = "202.154.58.25";  //deklarasi untuk server mqtt
const char* mqtt_user = "logika";             //deklarasi untuk username server mqtt
const char* mqtt_password = "pratama";  //deklarasi untuk password server mqtt

//char json [1024];
WiFiClient espClient;     //deklarasi untuk variabel wifi
PubSubClient client(espClient);   

#define RXD2 16     //deklarasi pin serial2
#define TXD2 17     //deklarasi untuk pin serial2

unsigned char incomingByte;   //data masuk dari serial 
String karakter ;   //variabel menghitung jumlah karakter
String Str1;        //variabel untuk konvert ke string
int Panjang;      //variabel menghitung jumlah karakter yang masuk
String Data;      //variabel mengelompokkan data yang bertipe string
String IDReader = "1111";   //penomoran setiap Reader
String Kirim;       //variabel untuk mengirim data ke mqtt

long lastMsg = 0;   //variabel bawaan mqtt
char msg[300];      //variabel bawaan mqtt

void sendIdentifyCmd ()     //fungsi untuk menjadikan data yang masuk menjadi hexadecimal
{
  Serial2.write (0x7c);    
  Serial2.write (0xff);
  Serial2.write (0xff);  
  Serial2.write (0x01);                  
  Serial2.write (0x08);                  
  Serial2.write (0x7d);              
#ifdef DEBUG
  Serial.print (0x7c);
  Serial.print (0xff);
  Serial.print (0xff);
  Serial.print (0x01);
  Serial.print (0x08);
  Serial.print (0x7d);
  Serial.println ();
#endif
}

void receivedCallback(char* topic, byte* payload, unsigned int length) {          //fungsi untuk koneksi ke mqtt berdasarkan topic yang digunakan
  Serial.print("Message received: ");
  Serial.println(topic);
  String payloadtemp;
  Serial.print("payload: ");
  for (int i = 0; i < length; i++) {
    Serial.print((char)payload[i]);
  }
  Serial.println(); 
}
void mqttconnect() {                //fungsi untuk menghubungkan esp32 ke server mqtt

  while (!client.connected()) {
    Serial.print("MQTT connecting ...");
    String clientId = "ESP32Client";
    if (client.connect(clientId.c_str(), mqtt_user, mqtt_password)) {
      Serial.println("connected");
    } else{
      Serial.print("failed, status code =");
      Serial.print(client.state());
      Serial.println("try again in 5 seconds");
      delay(5000);
    }
  }
}

void setup ()
{
  Serial.begin (57600);             //baudrate untuk serial monitor arduino
  Serial2.begin(57600, SERIAL_8N1, RXD2, TXD2);     //baudrate untuk data yang masuk dari RFID Reader
  Serial.print("Connecting to ");
  Serial.println(ssid);
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
  delay(500);    
  Serial.print(".");}
  Serial.println("");
  Serial.println("WiFi connected");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
  client.setServer(mqtt_server, 1883);
  client.setCallback(receivedCallback);
  
  Serial2.println("serial2test");
  Serial.println ("begin initial Serial!\n");
}
void loop ()
{
  if (!client.connected()) {
  mqttconnect();
  }
  client.loop();
  
  sendIdentifyCmd (); 
  delay (1);
  while(Serial2.available () > 0)         //looping untuk data yang masuk
  {
      incomingByte=Serial2.read ();
      karakter = String(incomingByte,HEX);
      Panjang = karakter.length();
      if(Panjang == 1){
        Str1="0"+karakter;
      }else{
      Str1=karakter;
      } 
      Data = Data + Str1;
  Kirim = Data + IDReader;
  }   
  if(Data != ""){
  Serial.println(Kirim);
  client.publish("reader/reader", String(Kirim).c_str(), true);     //semua data yang ada di variabel Kirim akan mempublish menuju mqtt
  Data="";}
  delay (1000);

  long now = millis();
  if (now - lastMsg > 3000) {
  lastMsg = now;
  }
}
