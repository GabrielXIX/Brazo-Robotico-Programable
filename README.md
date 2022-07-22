# Brazo Robotico Programable

## Descripción
Este proyecto es un programa desarrollado en C# con Windows Forms para la interfaz gráfica que tiene como propósito controlar un brazo robótico con 5 grados de libertad construido con servomotores, un microcontrolador Arduino Uno, un modulo PCA9685, jumpers, baterías y madera.

## Funcionamiento
Primeramente el programa requiere que se seleccione la tasa de baudios y el puerto COM donde esta conectada la placa Arduino para poder utilizar el brazo, el usuario puede escoger entre dos opciones de control: usar la pestaña de control manual del brazo o usar la pestaña de rutinas programables para su movimiento. La primera opción como se menciona le permite al usuario controlar manualmente cada uno de los servomotores (grados de libertad), la segunda opción sirve para definir rutinas de movimiento y ejecutarlas en un ciclo que se puede finalizar cuando se desee.

## Video del programa y brazo en funcionamiento
- https://www.youtube.com/watch?v=HPIwY38xJuQ

## Imagenes del brazo
![20211128_210212](https://user-images.githubusercontent.com/65438145/180367477-9f8736fa-aa8d-408f-81f1-80fc7d03bee2.jpg)
![20211129_224217](https://user-images.githubusercontent.com/65438145/180367564-870a7b60-fffb-4dfe-a260-c46a665cdaad.jpg)
![20211128_210301](https://user-images.githubusercontent.com/65438145/180367680-efd81e3d-ad6c-4098-b2e5-d42b8c956cf5.jpg)
![20211129_224313](https://user-images.githubusercontent.com/65438145/180367601-d1761cc2-c63d-46c1-8ef6-24d4c62fa454.jpg)

## Interfaz gráfica del programa
### Pestaña para control manual del brazo
![image](https://user-images.githubusercontent.com/65438145/180368118-ba5277de-8475-4c9b-af83-d68c8ffd8044.png)
![image](https://user-images.githubusercontent.com/65438145/180368209-9dd1cb5f-6103-4d94-9396-078f3967f5b8.png)

### Pestaña para ejecución de rutinas
![image](https://user-images.githubusercontent.com/65438145/180368266-526c54a3-2f4d-495e-a526-1c8e483a0537.png)
![image](https://user-images.githubusercontent.com/65438145/180368326-7ceb4bf9-31d8-477e-8fe6-a4ee88ea21a9.png)
![image](https://user-images.githubusercontent.com/65438145/180368407-8bd7b0cf-643a-47c0-8577-bc1006148be2.png)

### Ventana para creación de rutinas
![image](https://user-images.githubusercontent.com/65438145/180368474-5c44c36c-52c7-428d-a605-ed78243205bb.png)
![image](https://user-images.githubusercontent.com/65438145/180368522-ef09a335-438d-4d46-b64d-7c8989eb4e41.png)

## Referencias
En cuanto a las referencias en las que se ha basado este proyecto se tiene un video donde se muestran los diferentes componentes para construir el brazo, varios videos donde se explica el código C++ asi como ciertas librerías para la manipulación de los servomotores mediante modulación por ancho de pulsos y una página web donde se muestran varios diseños de brazos robóticos:
- Video de componentes para construcción del brazo: 
  - https://www.youtube.com/watch?v=F0ZvF-FbCr0
- Videos del código para movimiento de servos: 
  - https://www.youtube.com/watch?v=y8X9X10Tn1k
  - https://www.youtube.com/watch?v=IJjOqRhKd0c
- Página de donde se basó el diseño: 
  - https://www.thingiverse.com/thing:2433
