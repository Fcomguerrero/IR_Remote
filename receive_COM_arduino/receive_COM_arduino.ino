/***************************************
*                                      *
*  Control Remoto Samsung AA59-00602A  *  
*                                      *
****************************************/  
#include <Arduino.h>      
#include <IRremote.h>

#define vcc 8
#define IR_SEND_PIN 9
#define gnd 10

String comando;

void setup() {   
  Serial.begin(9600);
  delay(10);
  
  pinMode(vcc,OUTPUT);
  digitalWrite(vcc,HIGH);
  pinMode(gnd,OUTPUT);
  digitalWrite(gnd,LOW);
  pinMode(IR_SEND_PIN,OUTPUT);
  
  IrSender.begin(IR_SEND_PIN, ENABLE_LED_FEEDBACK); //Specify send pin and enable feedback LED at default feedback LED pin

}
//*******************************************************************
void loop()
{  
  if (Serial.available() > 0)
  {
    comando = Serial.readStringUntil('\n');    
  } 
    if (comando.equals("on") == true) // Si el comando "on" es verdadero.
    {            
      Serial.println("ON/OFF"); // Envía mensaje por el pin IR_SEND_PIN.
        IrSender.sendSAMSUNG(0xE0E040BF, 32);
    }          
    if (comando.equals("volS") == true) // Si el comando "volS" es verdadero. //Volumen+
    {            
      Serial.println("Volumen+"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E0E01F, 32);
    }
    if (comando.equals("volb") == true) // Si el comando "volb" es verdadero. //Volumen-
    {            
      Serial.println("Volumen-"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E0D02F, 32);
    }
    if (comando.equals("prgS") == true) // Si el comando "prgS" es verdadero. //Programa+
    {            
      Serial.println("Prog+"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E048B7, 32);
    }
    if (comando.equals("prgb") == true) // Si el comando "prgb" es verdadero. //Programa-
    {            
      Serial.println("Prog-"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E008F7, 32);
    }
    if (comando.equals("menu") == true) // Si el comando "menu" es verdadero. //Menu
    {            
      Serial.println("Menu"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E058A7, 32);
    }
    if (comando.equals("flechaS") == true) // Si el comando "flechaS" es verdadero. //Arriba
    {            
      Serial.println("Flecha-Subir"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E006F9, 32);
    }
    if (comando.equals("flechaZ") == true) // Si el comando "flechaZ" es verdadero. //Izquierda
    {            
      Serial.println("Flecha-Izquierda"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E0A659, 32);
    }
    if (comando.equals("ok") == true) // Si el comando "ok" es verdadero. //OK
    {            
      Serial.println("OK"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E016E9, 32);
    }
    if (comando.equals("flechaD") == true) // Si el comando "flechaD" es verdadero. //Derecha
    {            
      Serial.println("Flecha-Derecha"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E046B9, 32);
    }
    if (comando.equals("flechaA") == true) // Si el comando "flechaA" es verdadero. //Abajo
    {            
      Serial.println("Flecha-Abajo"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E08679, 32);
    }
    if (comando.equals("return") == true) // Si el comando "return" es verdadero. //Return
    {            
      Serial.println("Return"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E01AE5, 32);
    }
    if (comando.equals("exit") == true) // Si el comando "exit" es verdadero. //Exit
    {            
      Serial.println("Exit"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E0B44B, 32);
    }
     if (comando.equals("mute") == true) // Si el comando "mute" es verdadero. //mute
    {            
      Serial.println("Mute"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E0F00F, 32);
    }
    if (comando.equals("chlist") == true) // Si el comando "chlist" es verdadero. //CH list
    {            
      Serial.println("Channel-list"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E0D629, 32);
    }
    if (comando.equals("prech") == true) // Si el comando "prech" es verdadero. //Pre CH
    {            
      Serial.println("Pre-CH"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E0C837, 32);
    }
    if (comando.equals("source") == true) // Si el comando "source" es verdadero. //Source
    {            
      Serial.println("Source"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E0807F, 32);
    }
    //---------------------------------------------------------------------------------
     if (comando.equals("cero") == true) // Si el comando "cero" es verdadero. //0
    {            
      Serial.println("0"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E08877, 32);
    }
    if (comando.equals("uno") == true) // Si el comando "uno" es verdadero. //1
    {            
      Serial.println("1"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E020DF, 32);
    }
    if (comando.equals("dos") == true) // Si el comando "dos" es verdadero. //2
    {            
      Serial.println("2"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E0A05F, 32);
    }
    if (comando.equals("tres") == true) // Si el comando "tres" es verdadero. //3
    {            
      Serial.println("3"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E0609F, 32);
    }
    if (comando.equals("cuatro") == true) // Si el comando "cuatro" es verdadero. //4
    {            
      Serial.println("4"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E010EF, 32);
    }
    if (comando.equals("cinco") == true) // Si el comando "cinco" es verdadero. //5
    {            
      Serial.println("5"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E0906F, 32);
    }
    if (comando.equals("seis") == true) // Si el comando "seis" es verdadero. //6
    {            
      Serial.println("6"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E050AF, 32);
    }
    if (comando.equals("siete") == true) // Si el comando "siete" es verdadero. //7
    {            
      Serial.println("7"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E030CF, 32);
    }
    if (comando.equals("ocho") == true) // Si el comando "ocho" es verdadero. //8
    {            
      Serial.println("8"); // Envía mensaje por el pin IR_SEND_PIN.
       IrSender.sendSAMSUNG(0xE0E0B04F, 32);
    }
    if (comando.equals("nueve") == true) // Si el comando "nueve" es verdadero. //9
    {            
      Serial.println("9"); // Envía mensaje por el pin IR_SEND_PIN.
        IrSender.sendSAMSUNG(0xE0E0708F, 32);
    }
    //---------------------------------------------------------------------------------
 // }//while
  // Limpiamos la cadena para volver a recibir el siguiente comando.
  comando = "";
}//loop
