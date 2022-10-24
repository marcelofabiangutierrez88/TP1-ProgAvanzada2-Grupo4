# TP1-ProgAvanzada2-Grupo4
TP1- Programacion Avanzada

Grupo 4: Figueras Gonzalo, Galarza Agustin, Gutierrez Marcelo, Quintela Victor, Regueira Alberto

1)Crear una función que devuelva la suma de dos números recibidos por parámetros.
2)Crear una función que reciba una cadena de 8 caracteres y retorne en el mismo parámetro la cadena cortada de izquierda a derecha en 4 caracteres. 
3)Crear una función que devuelva la fecha y hora actual  
4)Escribir un comentario con // 
5)Escribir un comentario con /*   */ 

Enumeraciones 

1) Crear una enumeración con los días de la semana, comenzando por Domingo con valor 1
2) Agregar a la enumeración la posibilidad de Imprimir un Texto por cada día de la semana 

Conversiones 

1) Realizar la conversión de true, false, 1 y 0 utilizando los métodos Convert., bool.Parse y bool.TryParse. Explique cómo responde en cada caso cada uno de los métodos indicados. 

2) Explique que sucede en los siguientes intentos de casteos de datos. 

 

a) int a = (int)344.4; 

 

En el primer caso, al ser un int y castear en un int lo que devuelve es el valor entero del numero: 344 

 

b) decimal a = 10; 

 

En este caso, al no tener decimales muestra el valor entero : 10 

 

c) int a=443444; 

 

El 44344 es un valor entero, por ende no pasa nada.  

    

d) short b = (short)a; 

 

Los dos tipos de datos son iguales (short) en este caso el casteo no haria nada. 

3) Escriba una sentencia switch utilizando una enumeración con 3 colores (blanco, azul y negro) y para cada caso indicar un mensaje de cual es el color informado.

4) Si se tiene una variable entera a, realice una sentencia if para evaluar si la variable a es mayor a 10. Si es verdad, mostrar un mensaje indicando que el valor es mayor a 10.
5) Al ejercicio del punto 4), agregar la sentencia de else y, en ella, indicar un mensaje de error. 

6) ¿Cuál es la diferencia entre la sentencia for y foreach? ¿Cuándo se debe utilizar cada una de ellas? 

 

La diferencia principal entre el las sentencias for y el foreach es que, el for recorre un array hasta la posicion que indicamos que recorrra, en cambio el foreach recorre de principio a fin. 

Ademas, foreach no es un bucle si no mas bien un constructor el cual solo puede iterar en arrays y objetos. For es bucle que nosotros podemos decir hasta donde se tiene que repetir. 

Foreach no se puede utilizar para recorrer strings. 

7) Defina una variable a que en cada ciclo de una sentencia while incremente su valor en 5. Cuando la variable a exceda el valor de 50, el ciclo while debe finalizar. 
