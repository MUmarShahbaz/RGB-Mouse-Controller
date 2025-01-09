#include <EEPROM.h>

#define TRP 3
#define TGP 5
#define TBP 6
#define BRP 9
#define BGP 10
#define BBP 11

int TRed;
int TGreen;
int TBlue;
int BRed;
int BGreen;
int BBlue;

void setup() {
  // Start serial communication
  Serial.begin(9600);

  // Initialize PWM pins
  pinMode(TRP, OUTPUT);
  pinMode(TGP, OUTPUT);
  pinMode(TBP, OUTPUT);
  pinMode(BRP, OUTPUT);
  pinMode(BGP, OUTPUT);
  pinMode(BBP, OUTPUT);

  TRed = EEPROM.read(0);
  TGreen = EEPROM.read(1);
  TBlue = EEPROM.read(2);
  BRed = EEPROM.read(3);
  BGreen = EEPROM.read(4);
  BBlue = EEPROM.read(5);

  analogWrite(TRP, TRed);
  analogWrite(TGP, TGreen);
  analogWrite(TBP, TBlue);
  analogWrite(BRP, BRed);
  analogWrite(BGP, BGreen);
  analogWrite(BBP, BBlue);

  // Print the values
  Serial.print("TRed: "); Serial.println(TRed);
  Serial.print("TGreen: "); Serial.println(TGreen);
  Serial.print("TBlue: "); Serial.println(TBlue);
  Serial.print("BRed: "); Serial.println(BRed);
  Serial.print("BGreen: "); Serial.println(BGreen);
  Serial.print("BBlue: "); Serial.println(BBlue);
}

void loop() {
  // Check if data is available on the serial port
  if (Serial.available()) {
    String colors = Serial.readStringUntil("/n");
    if (colors[0] == '#'){
      TRed = 16*htd(colors[1]) + htd(colors[2]);
      TGreen = 16*htd(colors[3]) + htd(colors[4]);
      TBlue = 16*htd(colors[5]) + htd(colors[6]);
      BRed = 16*htd(colors[8]) + htd(colors[9]);
      BGreen = 16*htd(colors[10]) + htd(colors[11]);
      BBlue = 16*htd(colors[12]) + htd(colors[13]);
    }
    if (colors[0] == 'S') {
      TRed = 16*htd(colors[2]) + htd(colors[3]);
      TGreen = 16*htd(colors[4]) + htd(colors[5]);
      TBlue = 16*htd(colors[6]) + htd(colors[7]);
      BRed = 16*htd(colors[9]) + htd(colors[10]);
      BGreen = 16*htd(colors[11]) + htd(colors[12]);
      BBlue = 16*htd(colors[13]) + htd(colors[14]);

      EEPROM.write(0, TRed);
      EEPROM.write(1, TGreen);
      EEPROM.write(2, TBlue);
      EEPROM.write(3, BRed);
      EEPROM.write(4, BGreen);
      EEPROM.write(5, BBlue);
    }
    // Print the values
    Serial.print("TRed: "); Serial.println(TRed);
    Serial.print("TGreen: "); Serial.println(TGreen);
    Serial.print("TBlue: "); Serial.println(TBlue);
    Serial.print("BRed: "); Serial.println(BRed);
    Serial.print("BGreen: "); Serial.println(BGreen);
    Serial.print("BBlue: "); Serial.println(BBlue);

    // Map the extracted RGB values to PWM outputs
    analogWrite(TRP, TRed);
    analogWrite(TGP, TGreen);
    analogWrite(TBP, TBlue);
    analogWrite(BRP, BRed);
    analogWrite(BGP, BGreen);
    analogWrite(BBP, BBlue);
  }
}

int htd(char c){
  if (c >= '0' && c <= '9') {
    return int(c - '0');
  } else if (c >= 'A') {
    return (c - 'A' + 10);  // Convert letter character to its integer value
  }
}