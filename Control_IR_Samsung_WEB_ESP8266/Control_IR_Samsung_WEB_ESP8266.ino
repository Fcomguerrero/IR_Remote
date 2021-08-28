
/***************************************
*                                      *
*  Control Remoto Samsung AA59-00602A  *  
*                                      *
****************************************/        
#include <IRremoteESP8266.h>
#include <IRsend.h>
#include <ESP8266WiFi.h>

const char* ssid = "MiMa";
const char* password = "1a4P8*.47-45.5";
char key[1];

WiFiServer server(80);
IRsend irsend(4);  //   el IR LED es controlado por GPIO pin 4 (D2)

void setup() {
  Serial.begin(9600);
  irsend.begin();
  delay(10);
  IPAddress ip(192, 168, 0, 102);       //IP interna
  IPAddress gateway(192,168,0,1);
  IPAddress subnet (255,255,255,0);     
  WiFi.begin(ssid, password);    // Connect to WiFi network
  WiFi.config(ip,gateway,subnet);      
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  server.begin();
  Serial.print("Conectar a IP: ");
  Serial.println(WiFi.localIP());
}

void loop() {
  // Check if a client has connected
  WiFiClient client = server.available();
  if (!client) {return;}

  // Wait until the client sends some data
//  Serial.println("new client");
//  while(!client.available()){
//    delay(1);
//  }

  // Read the first line of the request
  String request = client.readStringUntil('\r');
 
  client.flush(); 
  // Match the request
  if (request.indexOf("/codeO") != -1){  //on/off
    irsend.sendSAMSUNG(0xE0E040BF, 32);  
  } 
  if (request.indexOf("/codeb") != -1){  //baja vol-
    irsend.sendSAMSUNG(0xE0E0D02F, 32);
  }
  if (request.indexOf("/codes") != -1){  //sube Vol+
    irsend.sendSAMSUNG(0xE0E0E01F, 32);  
  }
  if (request.indexOf("/codem") != -1){  //mute
    irsend.sendSAMSUNG(0xE0E0F00F, 32);  
  }
  if (request.indexOf("/codeMenu") != -1){ //menu
    irsend.sendSAMSUNG(0xE0E058A7, 32);  
  }
  //-----------------------------------------
  if (request.indexOf("/code1") != -1){  //1
    irsend.sendSAMSUNG(0xE0E020DF, 32);  
  } 
  if (request.indexOf("/code2") != -1){  //2
    irsend.sendSAMSUNG(0xE0E0A05F, 32);
  }
  if (request.indexOf("/code3") != -1){  //3 
    irsend.sendSAMSUNG(0xE0E0609F, 32);  
  }
  if (request.indexOf("/code4") != -1){  //4 
    irsend.sendSAMSUNG(0xE0E010EF, 32);  
  }
  if (request.indexOf("/code5") != -1){  //5 
    irsend.sendSAMSUNG(0xE0E0906F, 32);  
  }
  if (request.indexOf("/code6") != -1){  //6   
    irsend.sendSAMSUNG(0xE0E050AF, 32);  
  } 
  if (request.indexOf("/code7") != -1){  //7 
    irsend.sendSAMSUNG(0xE0E030CF, 32);
  }
  if (request.indexOf("/code8") != -1){  //8 
    irsend.sendSAMSUNG(0xE0E0B04F, 32);  
  }
  if (request.indexOf("/code9") != -1){  //9 
    irsend.sendSAMSUNG(0xE0E0708F, 32);  
  }
  if (request.indexOf("/code0") != -1){  //0 
    irsend.sendSAMSUNG(0xE0E08877, 32);
  }
  //-----------------------------------------------
  if (request.indexOf("/codeS") != -1){  //Sube P+
    irsend.sendSAMSUNG(0xE0E048B7, 32);  
  }
  if (request.indexOf("/codeB") != -1){  //Baja P-
    irsend.sendSAMSUNG(0xE0E008F7, 32);
  } 
  if (request.indexOf("/codeL") != -1){  //Listar Canales
    irsend.sendSAMSUNG(0xE0E0D629, 32);
  } 
  if (request.indexOf("/codep") != -1){  //Canal previo
    irsend.sendSAMSUNG(0xE0E0C837, 32);
  }
  if (request.indexOf("/codeu") != -1){  //Cursor Up   
    irsend.sendSAMSUNG(0xE0E006F9, 32);
  }   
  if (request.indexOf("/codel") != -1){  //Cusor left 
    irsend.sendSAMSUNG(0xE0E0A659, 32);  
  }
  if (request.indexOf("/coder") != -1){  //Cursor right
    irsend.sendSAMSUNG(0xE0E046B9, 32);
  }
  if (request.indexOf("/coded") != -1){  //Cursor Down
    irsend.sendSAMSUNG(0xE0E08679, 32);
  }   
  if (request.indexOf("/codee") != -1){  //ENTER OK
    irsend.sendSAMSUNG(0xE0E016E9, 32);  
  }
  if (request.indexOf("/codeRet") != -1){  //Return
    irsend.sendSAMSUNG(0xE0E01AE5, 32);  
  }
  if (request.indexOf("/codex") != -1){  //Exit   
    irsend.sendSAMSUNG(0xE0E0B44B, 32);
  }
  if (request.indexOf("/codef") != -1){  //fuente
    irsend.sendSAMSUNG(0xE0E0807F, 32);
  } 

  // Return the response
  client.println("HTTP/1.1 200 OK");
  client.println("Content-Type: text/html");
  client.println(""); //  do not forget this one
  client.println("<!DOCTYPE HTML>");
  client.println("<html>");

  client.println("<html>");
  client.println("<head>");
  client.println("</head>");
  client.println("<body>");
  client.println("<h1 align='center'>Control Remoto Samsung AA59-00602A</h1><h3 align='center'></h3>");
  client.println("<div style='text-align:center;'>");
  client.println("<button onClick=location.href='./codeO\' style='margin:auto;background-color: #F93005;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("ON/OFF");
  client.println("</button>"); 
  client.println("<button onClick=location.href='./codef\' style='margin:auto;background-color: #969a99;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:135px;'>");
  client.println("Source");
  client.println("</button>"); 
  client.println("<br /><br />"); 
  client.println("<button onClick=location.href='./code1\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("1");
  client.println("</button>");
  client.println("<button onClick=location.href='./code2\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("2");
  client.println("</button>");
  client.println("<button onClick=location.href='./code3\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("3");
  client.println("</button>"); 
  client.println("<br />");
  client.println("<button onClick=location.href='./code4\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("4");
  client.println("</button>");
  client.println("<button onClick=location.href='./code5\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("5");
  client.println("</button>");
  client.println("<button onClick=location.href='./code6\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("6");
  client.println("</button>"); 
  client.println("<br />");
  client.println("<button onClick=location.href='./code7\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("7");
  client.println("</button>");
  client.println("<button onClick=location.href='./code8\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("8");
  client.println("</button>");
  client.println("<button onClick=location.href='./code9\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("9");
  client.println("</button>"); 
  client.println("<br />"); 
  client.println("<button onClick=location.href='./code0\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("0");
  client.println("</button>");  
  client.println("<button onClick=location.href='./codep\' style='margin:auto; background-color: #0509F9;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:135px;'>");
  client.println("Pre CH");
  client.println("</button>");
  client.println("<br /><br />");
  client.println("<button onClick=location.href='./codes\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("Vol+");
  client.println("</button>");
  client.println("<button onClick=location.href='./codem\' style='margin:auto;background-color: #86D7C3;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("MUTE");
  client.println("</button>");
  client.println("<button onClick=location.href='./codeS\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("Ch+");
  client.println("</button>");  
  client.println("<br />"); 
  client.println("<button onClick=location.href='./codeb\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("Vol-");
  client.println("</button>");
  client.println("<button onClick=location.href='./codeL\' style='margin:auto;background-color: #86D7C3;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("CHList");
  client.println("</button>");
  client.println("<button onClick=location.href='./codeB\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("Ch-");
  client.println("</button>"); 
  client.println("<br /><br />");
  client.println("<button onClick=location.href='./codeMenu\' style='margin:auto;background-color: #055830;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:205px;'>");
  client.println("MENU");
  client.println("</button>");
  client.println("<br /><br />");
  client.println("<button onClick=location.href='./codeu\' style='margin:auto;background-color: #06904e;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("Up");
  client.println("</button>");
  client.println("<br />");
  client.println("<button onClick=location.href='./codel\' style='margin:auto;background-color: #06904e;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("Left");
  client.println("</button>");
  client.println("<button onClick=location.href='./codee\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("OK");
  client.println("</button>");
  client.println("<button onClick=location.href='./coder\' style='margin:auto;background-color: #06904e;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("Right");
  client.println("</button>");
  client.println("<br />");
  client.println("<button onClick=location.href='./codeRet\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("Return");
  client.println("</button>");
  client.println("<button onClick=location.href='./coded\' style='margin:auto;background-color: #06904e;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("Down");
  client.println("</button>");
  client.println("<button onClick=location.href='./codex\' style='margin:auto;background-color: #84B1FF;color: snow;padding: 10px;border: 1px solid #3F7CFF;width:65px;'>");
  client.println("Exit");
  client.println("</button>");     
       
  client.println("</b></body>");
  client.println("</html>");

  delay(1);
  Serial.println("Client disconnected");
  Serial.println("");

}
