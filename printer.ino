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
}

void loop() {
  while (Serial.available() == 0) {
  }
  if (Serial.available()) {
    long input = Serial.parseInt();
    Serial.print("Raw => ");
    Serial.println(input);
    if (input == 1) {
      long input = 0;
      Serial.println("Menu 1 !");
      while (true) {
        String input2 = Serial.readString();
        if (input2.length() > 2) {
          Serial.print("Raw => ");
          Serial.println(input2);
          printer.begin();
          printer.setFont('A');
          printer.println(input2);
          Serial.println("Loop Break 1!");
          break;
        }
      }
    }
    if (input == 2) {
      long input = 0;
      Serial.println("Menu 2 !");
      while (true) {
        String input2 = Serial.readString();
        if (input2.length() > 2) {
          Serial.print("Raw => ");
          Serial.println(input2);
          printer.boldOn();
          printer.begin();
          printer.setFont('L');
          printer.println(input2);
          printer.boldOff();
          Serial.println("Loop Break 2!");
          break;
        }
      }
    }
    if (input == 3) {
      long input = 0;
      Serial.println("Menu 3 !");
      while (true) {
        String input2 = Serial.readString();
        if (input2.length() > 2) {
          Serial.print("Raw => ");
          Serial.println(input2);
          printer.begin();
          printer.doubleHeightOn();
          printer.setFont('L');
          printer.println(input2);
          printer.doubleHeightOff();
          Serial.println("Loop Break 3!");
          break;
        }
      }
    }
    if (input == 4) {
      long input = 0;
      Serial.println("Menu 4 !");

      printer.begin();
      printer.feed(2);
      Serial.println("Loop Break 4!");
    }
    if (input == 5) {
      long input = 0;
      Serial.println("Menu 5 !");
      while (true) {
        String input2 = Serial.readString();
        if (input2.length() > 2) {
          Serial.print("Raw => ");
          Serial.println(input2);
          printer.justify('C');
          printer.boldOn();
          printer.begin();
          printer.setFont('L');
          printer.println(input2);
          printer.boldOff();
          printer.justify('L');

          Serial.println("Loop Break 5!");
          break;
        }
      }
    }
    if (input == 6) {
      long input = 0;
      Serial.println("Menu 6 !");
      while (true) {
        String input2 = Serial.readString();
        if (input2.length() > 2) {
          Serial.print("Raw => ");
          Serial.println(input2);

          printer.begin();

          printer.setBarcodeHeight(100);
          printer.printBarcode(input2.c_str(), UPC_A);
          Serial.println("Loop Break 6!");
          printer.setDefault();
          break;
        }
      }
    }
    if (input == 7) {
      long input = 0;
      Serial.println("Menu 7 !");
      while (true) {
        String input2 = Serial.readString();
        if (input2.length() > 2) {
          Serial.print("Raw => ");
          Serial.println(input2);

          printer.begin();

          printer.setBarcodeHeight(100);
          printer.printBarcode(input2.c_str(), CODE93);
          Serial.println("Loop Break 7!");
          printer.setDefault();
          break;
        }
      }
    }
    if (input == 97) {
      long input = 0;
      printer.sleep();
      delay(3000);
    }
    if (input == 98) {
      long input = 0;
      printer.wake();
      printer.setDefault();
      delay(1500);
    }
    if (input == 99) {
      long input = 0;
      Serial.println("1 = Normal,2 = Big,3 = Double height text | Tiegertropfen119");
    }
  }
}