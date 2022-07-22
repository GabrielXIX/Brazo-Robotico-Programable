# Brazo-Robotico-Programable

## Descripción
Este proyecto es un programa desarrollado en C# con Windows forms para la interfaz gráfica que tiene como propósito controlar un brazo robótico con 5 grados de libertad construido con servomotores, un microcontrolador Arduino Uno, un modulo PCA9685, jumpers, baterías y madera.

## Funcionamiento
Primeramente el programa requiere que se seleccione la tasa de baudios y el puerto COM donde esta conectada la placa Arduino para poder utilizar el brazo, el usuario puede escoger entre dos opciones de control: usar la pestaña de control manual del brazo o usar la pestaña de rutinas programables para su movimiento. La primera opción como se menciona le permite al usuario controlar manualmente cada uno de los servomotores (grados de libertad), la segunda opción sirve para definir rutinas de movimiento y ejecutarlas en un ciclo que se puede finalizar cuando se desee.

## Imagenes del brazo
![20211128_210212](https://user-images.githubusercontent.com/65438145/180367477-9f8736fa-aa8d-408f-81f1-80fc7d03bee2.jpg)
![20211129_224217](https://user-images.githubusercontent.com/65438145/180367564-870a7b60-fffb-4dfe-a260-c46a665cdaad.jpg)
![20211128_210301](https://user-images.githubusercontent.com/65438145/180367680-efd81e3d-ad6c-4098-b2e5-d42b8c956cf5.jpg)
![20211129_224313](https://user-images.githubusercontent.com/65438145/180367601-d1761cc2-c63d-46c1-8ef6-24d4c62fa454.jpg)

## Interfaz gráfica del programa


## Video del programa y brazo en funcionamiento
- https://www.youtube.com/watch?v=HPIwY38xJuQ

## Referencias
En cuanto a las referencias en las que se ha basado este proyecto se tiene un video donde se muestran los diferentes componentes para construir el brazo, varios videos donde se explica el código C++ asi como ciertas librerias para la manipulacion de los servomotores mediante modulacion por ancho de pulsos y una página web donde se muestran varios diseños brazos robóticos:
- Video de componentes para construcción del brazo: https://www.youtube.com/watch?v=F0ZvF-FbCr0
- Videos del código para movimiento de servos: 
  - https://www.youtube.com/watch?v=y8X9X10Tn1k
  - https://www.youtube.com/watch?v=IJjOqRhKd0c
- Página de donde se basó el diseño: https://www.thingiverse.com/thing:2433
