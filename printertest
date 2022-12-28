#include "Adafruit_Thermal.h"
#include "SoftwareSerial.h"
#define TX_PIN 5
#define RX_PIN 6

int prnt = 0;
SoftwareSerial mySerial(RX_PIN, TX_PIN);
Adafruit_Thermal printer(&mySerial);
String oldinput;
void setup() {
  pinMode(7, OUTPUT);
  digitalWrite(7, LOW);
  mySerial.begin(9600);
  Serial.begin(57600);
  delay(1000);
  Serial.println("Print test 1");
  printer.begin();
  printer.setFont('A');
  printer.println("Normal Print");
  delay(2000);
  Serial.println("Big print");
  printer.begin();
  printer.doubleHeightOn();
  printer.setFont('L');
  printer.println("Big print");
  printer.doubleHeightOff();
  delay(2500);
  Serial.print("feed 5");
  printer.feed(5);
  delay(2500);
  printer.begin();
  printer.setBarcodeHeight(100);
  printer.printBarcode("TEST", UPC_A);
  Serial.println("Loop Break 6!");
  printer.setDefault();
}

void loop() {
}
