# Comparar las tripletas (Compare the triplets)

### Enunciado

Alice y Bob crearon cada uno un problema. Un revisor califica los dos retos, otorgando puntos en una escala de 1 a 100 para tres categorías: claridad del problema, originalidad y dificultad.

La puntuación del reto de Alice es el triplete a = (a[0], a[1], a[2]), y la del reto de Bob es el triplete b = (b[0], b[1], b[2]).

La tarea consiste en encontrar sus puntos de comparación comparando a[0] con b[0], a[1] con b[1] y a[2] con b[2].

```
Si a[i] > b[i], Alice recibe 1 punto.
Si a[i] < b[i], Bob gana 1 punto.
Si a[i] = b[i], ninguna de las dos personas recibe un punto.

```

Puntos de comparación es el total de puntos que ha ganado una persona.

Dados a y b, determina sus respectivos puntos de comparación.

Ejemplo

a = [1, 2, 3]
b = [3, 2, 1]

```
Para los elementos *0*, Bob obtiene un punto porque a[0].
Para los elementos iguales a[1] y b[1], no se gana ningún punto.
Finalmente, para los elementos 2, a[2] > b[2] por lo que Alice recibe un punto.

```

La matriz de retorno es [1, 1] con la puntuación de Alice en primer lugar y la de Bob en segundo.

### Descripción de la función

La función recibe los siguientes parámetros:

```
int a[3]: Valoración del reto de Alice
int b[3]: Puntuación de Bob
```

Devuelve

```
int[2]: La puntuación de Alice está en la primera posición y la de Bob en la segunda.
```

### Formato de entrada

La primera línea contiene 3 enteros separados por espacios, a[0], a[1] y a[2], los valores respectivos del triplete a.
La segunda línea contiene 3 enteros separados por espacios, b[0], b[1] y b[2], los valores respectivos del triplete b.

### Restricciones

- *1 ≤ a[i] ≤ 100*
- *1 ≤ b[i] ≤ 100*

### Ejemplo de entrada

```
5 6 7
3 6 10
```

### Ejemplo de salida

```
1 1
```

### Explicación

En este ejemplo:

- a = (a[0], a[1], a[2]) = (5, 6, 7)
- b = (b[0], b[1], b[2]) = (3, 6, 10 )

Ahora vamos a comparar sus puntajes individuales:

- a[0] > b[0], Alice recibe un punto.
- a[1] = b[0], nadie recibe un punto.
- a[2] < b[2], Bob recibe un punto.

La puntuación de comparación de Alice es 1, y la puntuación de comparación de Bob es 1. Por lo tanto, devolvemos la matriz [1, 1].

## Mi código para resolverlo

- C#

```csharp
class Result
{
    public static List<int> CompareTriplets(List<int> a, List<int> b)
    {
        List<int> result = new List<int>();
        int alicePoints = 0;
        int bobPoints = 0;
        for(int i = 0; i < a.Count; i++)
        {
            if(a[i] > b[i])
            {
                alicePoints++;
            }
            if(b[i] > a[i])
            {
                bobPoints++;
            }
        }
        result.Add(alicePoints);
        result.Add(bobPoints);
        return result;
    }
}
```