# Diferencia diagonal (Diagonal difference)

### Enunciado

Dada una matriz cuadrada, calcular la diferencia absoluta entre la sumas de sus diagonales. Por ejemplo, la matriz **arr:**

```
1 2 3
4 5 6
9 8 9
```

La diagonal de izquierda a derecha es: 1 + 5+ 9 = 15. La diagonal de derecha a izquierda es: 3 + 5 + 9 = 17. Su diferencia absoluta es: |15 - 17 | = 2.

### Descripción de la función

La función recibe los siguientes parámetros:

- **int arr[n][m]**: un arreglo de enteros

La función debe retornar:

- **int**: diferencia absoluta entre la diagonales

### Formato de entrada

La primera línea contiene un único entero, **n**, que corresponde al número de filas y columnas en la matriz cuadrada. Cada una de las siguientes **n** líneas correspondes a una fila, **arr[i]**, y consisten en n enteros separados por un espacio **arr[i][j].**

### Restricciones

-100 ≤ arr[i][j] ≤ 100

### Formato de salida

Retorna la diferencia absoluta, entre la suma de sus diagonales como un solo entero.

### Ejemplo de entrada

```
3
11 2 4
4 5 6
10 8 -12
```

### Ejemplo de salida

```
15
```

### Explicación

La primera diagonal es

```
11
   5
     -12
```

La suma a través de la diagonal: 11 + 5 -12 = 4

La segunda diagonal es:

```
     4
   5
10
```

La suma a través de la diagonal: 4 + 5 + 10 = 19

Diferencia absoluta: |4 - 19| = 15

## Mi código para resolverlo

- C#

```csharp
class Result
{
    public static int DiagonalDifference(List<List<int>> arr)
    {
        int leftToRight = 0;
        int rightToLeft = 0;
        for(int i = 0; i < arr.Count; i++)
        {
            for(int j = 0; j < arr[i].Count; j++ )
            {
                if(i == j)
                {
                    leftToRight += arr[i][j];
                }
                if(j == arr.Count - 1 - i)
                {
                    rightToLeft += arr[i][j];
                }
            }
        }
        int difference = Math.Abs(leftToRight - rightToLeft);
        return difference;
    }
}
```