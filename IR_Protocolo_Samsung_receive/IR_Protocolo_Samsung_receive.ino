/***************************************
*                                      *
*  Control Remoto Samsung AA59-00602A  *  
*                                      *
****************************************/  
#include <IRremote.h>      //including infrared remote header file
#define DECODE_SAMSUNG  

int IR_RECEIVE_PIN = 2;   //PIN para sensor (IR receptor) receiver
 
void setup()
{
  Serial.begin(9600);
  IrReceiver.begin(IR_RECEIVE_PIN, ENABLE_LED_FEEDBACK, USE_DEFAULT_FEEDBACK_LED_PIN);
  Serial.println("IR Receiver... Started");
}
 
void loop() 
{
  if (IrReceiver.decode())
  {   
    // Print summary of received data
    Serial.println("-------------------------Short-summary-----------------------------------------");
    IrReceiver.printIRResultShort(&Serial);
    Serial.println("-------------------------RawFormatted------------------------------------------");
    IrReceiver.printIRResultRawFormatted(&Serial);
    Serial.println("-------------------------------------------------------------------------------");
    
    if (IrReceiver.decodedIRData.protocol == UNKNOWN) {
        // We have an unknown protocol here, print more info
        Serial.println("--------------Protocolo UNKNOWN------------------------");
        IrReceiver.printIRResultRawFormatted(&Serial, true);
    }
    
    //Finally, check the received data and perform actions according to the received command         
    if (IrReceiver.decodedIRData.command == 0x2) {  //command 0x2 es ON
        Serial.println("---------ON/OFF--------");
    } else if (IrReceiver.decodedIRData.command == 0x7) {   //command 0x7 es V+
        Serial.println("---------V+---------");
    } else if (IrReceiver.decodedIRData.command == 0xB) {   //command 0xB es V-
        Serial.println("-------- V- ---------");
    } else if (IrReceiver.decodedIRData.command == 0x12) {  //command 0x12 es P+
        Serial.println("---------Prg+---------");
    } else if (IrReceiver.decodedIRData.command == 0x10) {  //command 0x10 es P-
        Serial.println("--------- Prg- ------");
    } else if (IrReceiver.decodedIRData.command == 0x1A) {  //command 0x1A es Menu
        Serial.println("---------Menu---------");
    } else if (IrReceiver.decodedIRData.command == 0x60) {  //command 0x60 es Arriba
        Serial.println("---------Arriba-----------");
    } else if (IrReceiver.decodedIRData.command == 0x62) {  //command 0x62 es Derecha
        Serial.println("---------Derecha---------");
    } else if (IrReceiver.decodedIRData.command == 0x61) {  //command 0x61 es Abajo
        Serial.println("---------Abajo-----------");
    } else if (IrReceiver.decodedIRData.command == 0x65) {  //command 0x65 es Izquierda
        Serial.println("---------Izquierda---------");
    } else if (IrReceiver.decodedIRData.command == 0x68) {  //command 0x68 es OK
        Serial.println("-------------OK-----------");
    } else if (IrReceiver.decodedIRData.command == 0x58) {  //command 0x58 es Return
        Serial.println("-----------Return---------");
    } else if (IrReceiver.decodedIRData.command == 0x2D) {  //command 0x2D es Exit
        Serial.println("-----------Exit-----------");
    } else if (IrReceiver.decodedIRData.command == 0xF) {  //command 0xF es mute
        Serial.println("-----------mute-----------");
    } else if (IrReceiver.decodedIRData.command == 0x6B) {  //command 0x6B es CH-List
        Serial.println("--------CH List-----------");
    } else if (IrReceiver.decodedIRData.command == 0x13) {  //command 0x13 es PRE-CH
        Serial.println("---------Pre CH-----------");
    } else if (IrReceiver.decodedIRData.command == 0x1) {  //command 0x1 es Source
        Serial.println("---------Source-----------");
    } else if (IrReceiver.decodedIRData.command == 0x11) {  //command 0x es 0
        Serial.println("----------0----------");
    } else if (IrReceiver.decodedIRData.command == 0x4) {  //command 0x es 1
        Serial.println("----------1----------");
    } else if (IrReceiver.decodedIRData.command == 0x5) {  //command 0x es 2
        Serial.println("----------2----------");
    } else if (IrReceiver.decodedIRData.command == 0x6) {  //command 0x es 3
        Serial.println("----------3----------");
    } else if (IrReceiver.decodedIRData.command == 0x8) {  //command 0x es 4
        Serial.println("----------4----------");
    } else if (IrReceiver.decodedIRData.command == 0x9) {  //command 0x es 5
        Serial.println("----------5----------");
    } else if (IrReceiver.decodedIRData.command == 0xA) {  //command 0x es 6
        Serial.println("----------6----------");
    } else if (IrReceiver.decodedIRData.command == 0xC) {  //command 0x es 7
        Serial.println("----------7----------");
    } else if (IrReceiver.decodedIRData.command == 0xD) {  //command 0x es 8
        Serial.println("----------8----------");
    } else if (IrReceiver.decodedIRData.command == 0xE) {  //command 0x es 9
        Serial.println("----------9----------");
    }
    //---------------------------------------------------------------------------------
    else {
      Serial.println("--------command-Unknown--------");
    }    
         
    IrReceiver.resume(); // Enable receiving of the next value
    
    Serial.println("");
    Serial.println("**********************************************************************************");
   }
}
