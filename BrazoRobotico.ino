//Librerias utilizadas
#include <Adafruit_PWMServoDriver.h> //Modulo PCA9685
#include <Wire.h>

//Se declara una instancia de la libreria para el manejo de los
//servomotores usando la direccion de la tarjeta "0x40"
Adafruit_PWMServoDriver brazo = Adafruit_PWMServoDriver(0x40);

//variables globales

//El modulo se maneja por pulsos y no grados
unsigned int MIN = 125; //Ancho de Pulso Minimo
unsigned int MAX = 620; //Ancho de Pulso Maximo

String stringEntrada = ""; //Para guardar los comandos a ejecutar de VS
bool stringCompleto = false; //Para saber si se completo el comando
int rojo = 3; //variables para led
int verde = 5;
int azul = 6;

void setup() 
{
  //Monitor Serie
  Serial.begin(9600);
  Serial.println("Prueba de funcionamiento con 5 servos\n");

  //Se inicializa la instancia de brazo y se asigna la frecuecia
  brazo.begin();
  brazo.setPWMFreq(60); //Frecuencia de funcionamiento 60 Hz

  pinMode(rojo, OUTPUT);
  pinMode(verde, OUTPUT);
  pinMode(azul, OUTPUT);

  yield(); //Espera a que se realizen los procesos para seguir
}

void loop() 
{
    if(stringCompleto)
    {
      stringEntrada.trim(); //quitar espacios o caracteres especiales
      Serial.print("Comando de Entrada: ");
      Serial.print(stringEntrada);

      //Procesar comando
      procesarComando();

      //Limpiar el string
      stringEntrada = "";
      stringCompleto = false;   
    }
}

//Metodo para procesar el comando
void procesarComando()
{
  
  //stringCompleto es true

  //Rotación
  if(stringEntrada.indexOf("$R") != -1)
  {
    int angulo = stringEntrada.substring(2).toInt();

    brazo.setPWM(1, 0, Conversion(angulo));
  }

  //Hombro
  else if(stringEntrada.indexOf("$H") != -1)
  {
    int angulo = stringEntrada.substring(2).toInt();

    brazo.setPWM(2, 0, Conversion(angulo));
    brazo.setPWM(3, 0, Conversion(angulo));
  }

  //Codo
  else if(stringEntrada.indexOf("$C") != -1)
  {
    int angulo = stringEntrada.substring(2).toInt();

    brazo.setPWM(4, 0, Conversion(angulo));
  }

  //Muñeca
  else if(stringEntrada.indexOf("$M") != -1)
  {
    int angulo = stringEntrada.substring(2).toInt();

    brazo.setPWM(5, 0, Conversion(angulo));
  }

  //Agarre
  else if(stringEntrada.indexOf("$A") != -1)
  {
    int angulo = stringEntrada.substring(2).toInt();

    brazo.setPWM(8, 0, Conversion(angulo));
  }

  //Led encendido
  else if(stringEntrada.indexOf("$O") != -1)
  {
    analogWrite(rojo,0);
    analogWrite(verde,0);
    analogWrite(azul,0);
  }
  //Led apagado
  else if(stringEntrada.indexOf("$F") != -1)
  {
    analogWrite(rojo,255);
    analogWrite(verde,255);
    analogWrite(azul,255);
  }
}

//Funcion para conversion de grados a pulsos en hexadecimal
int Conversion(int ang)
{
  //Variacion de 0 a 180 grados
  //Mapea los valores maximos y minimos de un rango al otro
  int pulso = map(ang, 0, 180, MIN, MAX); 

  Serial.print("\nAngulo : ");
  Serial.print(ang);
  Serial.print("\nPulso  : ");
  Serial.print(pulso);
  Serial.println("\n");

  return pulso;
}

//Se ejecuta cada que ocurre un evento serial
void serialEvent()
{
  while(Serial.available())
  {
    char inChar = (char)Serial.read();
    if(inChar == '\n')
    {
      stringCompleto = true;
    }
    else
    {
      stringEntrada += inChar;
    }
  }
}
