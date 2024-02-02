//Librerie
#include <IRremote.h>
#include <Servo.h>
#include "SR04.h"
#include <SimpleDHT.h>
#include <LiquidCrystal.h>

//variabili globali per il sensore 
#define TRIG_PIN 12
#define ECHO_PIN 13


// initialize the library with the numbers of the interface pins
LiquidCrystal lcd(2,3,4,5,6,7);

//variabili led
int ledRosso = A2;
int led = A1;

//variabili Allarme
SR04 sr04 = SR04(ECHO_PIN,TRIG_PIN);  //sensor ultra sonic
long a; //acquisisce il valore ottenuto tramite sr04
const int buzzer = A3;
int ledDelay = 50; // ritarda di 50ms

bool isCasa = false;
bool apriMenu = true;
bool casaAttivo = false;
bool cancelloAttivo = false;


//variabili Password
const int irPin = A4; //IR in pin
IRrecv irrecv (irPin); //Crea un ricevitore IR 
decode_results results; //oggetti in irPin 
char irnum[4] = {'0', '1', '2', '3'}; //i possibili numeri da poter inserire
char psw[3];   //array che acquisisce la password inserita
int oldVal = 0; //Queste due variabili ottengono
int val = 0; //i numeri decodificati dal remoto
int irnumCodes[4] = { 
  0xFF6897, //0
  0xFF30CF, //1 
  0xFF18E7, //2  
  0xFF7A85  //3 
};

//variabili Cancello
Servo ServoMotor;
int pos;

//variabili temperatura e umidità
int pinDHT11 = A5;
SimpleDHT11 dht11;

//variabili globali pr la ventola
#define ENABLE 10  
#define DIRA 8     
#define DIRB 9     

//variabili per la ventola
int i;
int controlloSetPoint;
String x;

//variabili per comunicazione arduino-Gui
String dati;
char primocarattere;


//TASTI dEL TELECOMANDO
#define BUTTON_ON_OFF  0xFFA25D
#define BUTTON_UP      0xFF906F
#define BUTTON_DOWN    0xFFE01F
#define BUTTON_PAUSE   0xFF02FD
#define BUTTON_4       0xFF10EF
#define BUTTON_5       0xFF38C7
#define BUTTON_6       0xFF5AA5

void setup()
{
  Serial.begin (9600);
  irrecv.enableIRIn(); // Start the receiver
  lcd.begin(16, 2);
  pinMode(ledRosso, OUTPUT);
  pinMode(led, OUTPUT);
  pinMode(buzzer, OUTPUT);
  pinMode(ENABLE,OUTPUT);
  pinMode(DIRA,OUTPUT);
  pinMode(DIRB,OUTPUT);
  ServoMotor.attach(11);
}

void loop() 
{
    
    if(isCasa)  //IsCasa è false, si entra nel caso in cui siamo dentro la casa
    { 
      menu(); //funzione per visualizzare il menu
      if(casaAttivo)  
      {
        if(Serial.available())  //legge i dati per l'interfaccia
        {
          dati = Serial.readString();  
          primocarattere = dati.charAt(0);
          switch(primocarattere)
          {
            case 'A': digitalWrite(led, HIGH);  //accende la luce quando si è in casa
            break;
            case 'B': digitalWrite(led, LOW);  //spegne la luce quando si esce dalla casa
            break;
            case 'S': 
            x = dati.substring(1);
            controlloSetPoint = x.toInt();
            lcd.clear();  //nel display viene scritto il setpoint attuale
            lcd.setCursor(0, 0);
            lcd.print("New setpoint");
            lcd.setCursor(13, 0);
            lcd.print(controlloSetPoint);
            delay(1000);
            break;
          }
        }
        controlloVentola(); //funzione per il controllo della ventola
        controlloLed(); //funzione per il controllo delle luci
        checkTempHum(); //funzione per il controllo della temperatura e umidità
        if (irrecv.decode(&results)) // se abbiamo ricevuto un segnale ir, serve per ritornare al menu
        {
          irrecv.resume(); 
          switch(results.value)
          {
            case BUTTON_PAUSE:   //pausa, tasto del telecomando per andare al menu
              lcd.clear();
              lcd.setCursor(0, 0);
              lcd.print("Ritorno al");
              lcd.setCursor(0, 1);
              lcd.print("menu casa ");
              apriMenu = true;
              casaAttivo = false;
              digitalWrite(led, LOW);
              Serial.println("w");
            break;
            case BUTTON_ON_OFF:  //On, utilizzato per accendere/spegnere la tv
              Serial.println("b");
            break;
          
          }
        }
      }
      else if(cancelloAttivo)
      {
        controlloCancello();
      }

    }else if(!isCasa) ///se IsCasa è true, allora si attiva il sistema di allarme
    {
      allarme();
    }
  
}

void menu()
{
  if(apriMenu) //per visualizzare le opzioni all'interno del menu nel display
  { 
    delay(2000);
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("CASA DOMOTICA:");
    lcd.setCursor(0, 1);
    lcd.print("4 - ALLARME");
    delay(2000);
    lcd.clear();
    lcd.setCursor(0, 0);
    lcd.print("5 - CASA");           
    lcd.setCursor(0, 1);
    lcd.print("6 - CANCELLO"); 
    apriMenu = false;
  }
  //parte per accedere alle diverse opzioni del menu
      if (irrecv.decode(&results)) // se abbiamo ricevuto un segnale ir
      {
            irrecv.resume();
            lcd.setCursor(0, 0);
            switch(results.value){
                //--------------Se si è inserito 4, si attiva l'allarme
                case BUTTON_4:
                {
                  lcd.clear();
                  lcd.print("Allarme attivato");
                  Serial.print("a");
                  isCasa = false; 
                  cancelloAttivo = false;
                  casaAttivo = false;
                  break;
                }
              //-----------------Se si è inserito 5, si entra nella funzione Casa, incorporata nel loop
              case BUTTON_5:
                {
                  lcd.clear();
                  lcd.print("Bentornata"); 
                  Serial.print("d");
                  lcd.setCursor(0, 1);
                  lcd.print("a casa!");
                  casaAttivo = true;
                  cancelloAttivo = false;
                  isCasa = true; 
                  break;
                }
              //------------------Se si è inserito 6, si può controllare il cancello 
              case BUTTON_6:   //cancello
                {
                  digitalWrite(ledRosso, LOW); 
                  lcd.clear();
                  lcd.print("Controllo"); 
                  lcd.setCursor(0, 1);
                  lcd.print("cancello:");
                  cancelloAttivo = true;
                  casaAttivo = false;
                  isCasa = true; 
                  break;
                }
           
            }
      }
}

/***
*** FUNZIONI PER L'ALLARME
****/


void allarme()
{
  bool attivato = false;
  lcd.clear();
  lcd.print("ALLARME ATTIVATO");
  while(!isCasa)
  {
   if (irrecv.decode(&results)) // se abbiamo ricevuto un segnale ir, serve per ritornare al menu
        {
          irrecv.resume(); 
          if(results.value == BUTTON_PAUSE) //tasto pausa, si usa per bloccare l'allarme
          {  
              lcd.clear();          
              passwordCheckAllarme();  //funzione check della password per disattivare l'allarme
          } 
        }
        else{
              a=sr04.Distance();
              Serial.println((String)a);
              if(a < 6 || attivato)  
              {
                lcd.clear();   //se la distanza registrata è minore di 5 cm si attiva l'allarme
                lcd.setCursor(0, 0);
                lcd.print("  *** ALARM *** ");
                delay(500);
                attivato = true;
                StrokeLight();    //funzione che continua finchè non si inserisce la password            
              }
            }
        }
        attivato = false;

}

/***
*** FUNZIONE PER ACQUISIZIONE DEGLI INPUT DA TELECOMANDO
****/
char* enterPassword() 
{
  int x = 0; //long increment
  while (x <= 2)
  {   
    if (irrecv.decode (&results)) 
	  { //controlla se si ha ricevuta una segnale ir
      val = results.value; //Se si, val prende il valore del segnale
      irrecv.resume (); //continua il controllo
      if (val != oldVal) 
		  { //per non bloccare valori
			  for (int i = 0; i <= 4; i++) 
			  {
				  if (val == irnumCodes[i]) 
				  { //controllare se val è uguale a un carattere presente in irumCodes         
					lcd.print(irnum[i]); //Se si, mostrare nel display il carattere
					psw[x] = irnum[i]; //passw prende il valore
					x++;
					delay(200);
				  }
			  }
		  }
      oldVal = val;
    }  
  } 
    psw[x] = '\0';
 return psw;
}

/****
*** FUNZIONE PER IL CONTROLLO DELLA PASSWORD
****/
void passwordCheckAllarme()
{
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Inserire la"); 
      lcd.setCursor(0, 1);
      lcd.print("password: ");
      char* correct = enterPassword();
      //password corretta
      if(strcmp(psw, "111") == 0)
	    { 
        lcd.clear(); 
        lcd.setCursor(0, 0);   
        lcd.print("Password");
        lcd.setCursor(0, 1); 
        lcd.print("corretta");
        isCasa = true;
        apriMenu = true;
        Serial.println("d");   //allarme disattivato
        digitalWrite(buzzer,LOW);
        digitalWrite(ledRosso, LOW); 
      }
      //password non corretta
       if(strcmp(psw, "111") != 0)
      {  
        lcd.clear();
        lcd.setCursor(0, 0);     
        lcd.print("Password");
        lcd.setCursor(0, 1); 
        lcd.print("non corretta");
        isCasa = false;
        digitalWrite(ledRosso, HIGH);  
        digitalWrite(buzzer, HIGH);
        lcd.clear();   
        lcd.setCursor(0, 0);
        lcd.print("Riprovare:");
        passwordCheckAllarme();   //si potrà reinserire la password 
      }
}

/***
*** FUNZIONI PER L ALLARME
****/

///funzione per intermittenza luce rossa e buzzer, 50 ms di pausa
void StrokeLight()
{                                                    
    digitalWrite(ledRosso, HIGH);       
    delay(ledDelay);
    digitalWrite(ledRosso, LOW);        
    delay(ledDelay); 
    digitalWrite(ledRosso, HIGH);        
    delay(ledDelay); 
    digitalWrite(ledRosso, LOW);         
    delay(ledDelay); 
    digitalWrite(ledRosso, HIGH);       
    delay(ledDelay); 
    digitalWrite(ledRosso, LOW);         
    delay(ledDelay); 
     digitalWrite(buzzer, HIGH);       
    delay(ledDelay); 
    digitalWrite(buzzer, LOW);        
    delay(ledDelay); 
    digitalWrite(buzzer, HIGH);       
    delay(ledDelay); 
    digitalWrite(buzzer, LOW);        
    delay(ledDelay); 
    digitalWrite(buzzer, HIGH);       
    delay(ledDelay); 
    digitalWrite(buzzer, LOW);       
    delay(ledDelay); 
  }

/*****
*** FUNZIONE PER CONTROLLARE LA LUCE CON IL FOTORESISTORE
***/
void controlloLed()
{
    
  int luce = analogRead (A0); // Variabile luce che legge dal pin analogico A0
  if (luce > 1010)
  {  
    Serial.println("q");
    digitalWrite(led, HIGH);  //si spegne la luce 
  }
  else
  {
    Serial.println("w");
    digitalWrite(led, LOW); //si accende la luce
  } 
}

/*****
*** FUNZIONE PER CONTROLLARE LA TEMPERATURA E UMIDITA'
***/
void checkTempHum()
{
  byte temperature = 0;
  byte humidity = 0;
  byte data[40] = {0};

  /* Misura la temperatura e l'umidità.  Se la funzione ritorna vera,
     allora la misura viene aggiornata. */
  if( dht11.read( pinDHT11, &temperature, &humidity, data ) )
  {
    return;
  }
  //dati per l'interfaccia
  Serial.print("t");
  Serial.println(temperature);
  Serial.print("u");
  Serial.println(humidity);

}

/*****
*** FUNZIONE PER ATTIVARE LA VENTOLA
***/
void controlloVentola()
{
  byte temperature = 0;
  byte humidity = 0;
  byte data[40] = {0};

  /* Misura la temperatura e l'umidità.  Se la funzione ritorna vera,
     allora la misura viene aggiornata. */
  if( dht11.read( pinDHT11, &temperature, &humidity, data ) )
  {
    return;
  }

//visualizzare il setpoint ottenuto dall'interfaccia
  byte setpoint = (byte)controlloSetPoint; 
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("Set Point   ");
  lcd.setCursor(13, 0);
  lcd.print((String)controlloSetPoint);
 
 //si attiva la ventola
  if((int)temperature < (int)setpoint)
  {   
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.clear();
      lcd.setCursor(0, 0);
      lcd.print("Temp Attuale   C  ");
      lcd.setCursor(13, 0);
      lcd.print((String)temperature);
      Serial.println("v");
      digitalWrite(ENABLE,HIGH); // enable on
      digitalWrite(DIRA,LOW);  //reverse
      digitalWrite(DIRB,HIGH);
   }
   else //si disattiva la ventola 
   {
    Serial.println("f");
    digitalWrite(ENABLE, LOW);
    return;
   }

}
     
/**FUNZIONI PER IL 
**CONTROLLO DEL CANCELLO***
***/

void controlloCancello()
{
   delay(2000);
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("Comandi:");
  lcd.setCursor(0, 1);
  lcd.print("UP-DOWN-STOP");

       if (irrecv.decode(&results)) // se abbiamo ricevuto un segnale ir
      {
        lcd.setCursor(0, 0);
          irrecv.resume();
          switch(results.value){
              //-------------------- Aziona il cancello
              case BUTTON_UP:
              { 
                delay(2000);
                lcd.clear();
                Serial.println("o");
                lcd.print("Cancello UP");  
                
                for(pos = 90;pos>=0;pos--)
                {
                  ServoMotor.write(pos);
                  digitalWrite(buzzer, HIGH);
                  delay(100);
                }
                digitalWrite(buzzer, LOW);
                break;
              }
            //----------------------Chiude il cancello
            case BUTTON_DOWN:
              { 
                delay(2000);
                Serial.println("c");
                lcd.clear();
                lcd.print("Cancello DOWN");
                
                for(pos = 0;pos<90;pos++)
                {
                  ServoMotor.write(pos);
                  digitalWrite(buzzer, HIGH);
                  delay(100);
                }
                digitalWrite(buzzer, LOW);
                break;
              }
            //---------------------Si esce dal loop              
            case BUTTON_PAUSE:
              { 
                lcd.clear();
                lcd.setCursor(0, 0);
                lcd.print("Ritorno al");
                lcd.setCursor(0, 1);
                lcd.print("menu casa ");
                apriMenu = true;
                cancelloAttivo = false;
                break;
              }              
           
         }
          lcd.setCursor(0, 0);
     
     }
}
