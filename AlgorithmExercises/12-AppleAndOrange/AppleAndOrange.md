# Manzana y naranja (Apple and orange)

Dueño: Joan Rojas
Tags: Algoritmia

### Enunciado

La casa de Sam tiene un manzano y un naranjo que dan abundante fruta. Utilizando la información que se da a continuación, determina el número de manzanas y naranjas que caen en la casa de Sam.

En el diagrama de abajo:

- La región roja denota la casa, donde ***s*** es el punto inicial y ***t*** es el punto final. El manzano está a la izquierda de la casa y el naranjo a su derecha.
- Supongamos que los árboles están situados en un único punto, donde el manzano está en el punto ***a*** , y el naranjo está en el punto ***b***.
- Cuando una fruta cae de su árbol, aterriza a ***d*** unidades de distancia de su árbol de origen a lo largo del eje ***x***. *Un valor negativo de ***d*** significa que la fruta cayó unidades a la izquierda del árbol, y un valor positivo de ***d*** significa que cae ***d*** unidades a la derecha del árbol. *

![diagrama](diagram.png)

Dado el valor de ***d*** para ***m*** manzanas y ***n*** naranjas, determine cuántas manzanas y naranjas caerán sobre la casa de Sam (es decir, en el intervalo inclusivo [***s***, ***t***]).

Por ejemplo, la casa de Sam se encuentra entres ***s*** = 7 y ***t*** = 10. El árbol de manzanas está ubicado en ***a*** = 4 y el de naranjas en ***b*** = 12. Hay ***m*** = 3 manzanas y ***n*** = 3 naranjas. Las manzanas caen a ***manzanas = [2, 3, -4]*** unidades de distancia de ***a***, y las naranjas caen a ***naranjas = [3, -2, -4]*** unidades de distancia. Sumando la distancia de cada manzana a la posición del árbol, aterrizan en ***[4 + 2, 4 + 3, 4 + -4] = [6, 7, 0]***. Las naranjas aterrizan en ***[12 + 3, 12 + -12, 12 + -4] = [15, 10, 8]***. Una manzana y dos naranjas aterrizan en el rango inclusivo ***7 - 10***.

### Descripción de la función

Complete la función, que debería imprimir el número de manzanas y naranjas que aterrizan en la casa de Sam en una línea separada. Esta función recibe los siguientes parámetros:

- ***s***: entero, punto de partida de la casa de Sam.
- ***t***: entero, punto final de la casa de Sam.
- ***a***: entero, ubicación del árbol de manzanas.
- ***b***: entero, ubicación del árbol de naranjas.
- ***manzanas***: arreglo de enteros, distancia a la que cada manzana cae del árbol.
- ***naranjas***: arreglo de enteros, distancia a la que cada naranja cae del árbol.

### Formato de entrada

- La primera línea contiene dos enteros separados por un espacios, que indican los respectivos valores de ***s*** y ***t***.
- La segunda línea contiene dos enteros separados por espacios, que indican los respectivos valores de ***a*** y ***b***.
- La tercera línea contiene dos enteros separados por espacios, que indican los respectivos valores de ***m*** y ***n***.
- La cuarta línea contiene ***m*** enteros separados por espacios, que indican las respectivas distancias a las que cada manzana cae desde el punto ***a***.
- La quinta línea contiene ***n*** enteros separados por espacios, que indican las respectivas distancias a las que cada naranja cae desde le punto ***b***.

### Restricciones

- 1 ≤ s, t, b, a, m, n ≤ 10^5
- -10^5 ≤ d ≤ 10^5
- a < s < t < b

### Ejemplo de entrada

```
7 11
5 15
3 2
-2 2 1
5 -6
```

### Ejemplo de salida

```
1
1
```

### Explicación

- La primera manzana cae en la posición 5 - 2 = 3.
- La segunda manzana cae en la posición 5 + 2 = 7.
- La tercera manzana cae en la posición 5 + 1 = 6.
- La primera naranja cae en la posición 15 + 5 = 20.
- La segunda naranja cae en la posición 15 - 6 = 9.
- Solo una manzana cae en la región que está entre 7 y 11, entonces imprimimos 1 en la primera línea de salida.
- Solo una naranja cae en la región que está entre 7 y 11, entonces imprimimos 1 en la segunda línea de salida.

## Mi código para resolverlo

- C#

```csharp
class Result
{
	public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
	{
      int numberOfApple = 0;
      int numberOfOrange = 0;
      List<int> calculatedDistanceOfApple = new List<int>();
      List<int> calculatedDistanceOfOrange = new List<int>();
      for (int i = 0; i < apples.Count; i++)
      {
          calculatedDistanceOfApple.Add(a + apples[i]);
      }
      for (int i = 0; i < oranges.Count; i++)
      {
          calculatedDistanceOfOrange.Add(b + oranges[i]);
      }
      for(int i = 0;i < calculatedDistanceOfApple.Count; i++)
      {
          if (calculatedDistanceOfApple[i] >= s && calculatedDistanceOfApple[i] <= t)
          {
              numberOfApple++;
          }
      }
      for (int i = 0; i < calculatedDistanceOfOrange.Count; i++)
      {
          if (calculatedDistanceOfOrange[i] >= s && calculatedDistanceOfOrange[i] <= t)
          {
              numberOfOrange++;
          }
      }
      Console.WriteLine(numberOfApple);
      Console.WriteLine(numberOfOrange);
  }
}
```