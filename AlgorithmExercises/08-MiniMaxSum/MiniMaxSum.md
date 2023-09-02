# Mínima-Máxima Suma (Mini-Max Sum)

### Enunciado

Dado 5 enteros positivos, encontrar los valores mínimos y máximos que se pueden sumar exactamente con 4  de los 5 enteros. Una vez hallados imprimir los respectivos mínimos y máximos valores en una sola línea de dos enteros `long` separados por espacios.

### Ejemplo

`arr` = [1, 3, 5, 7, 9]

La mínima suma es 1 + 3 + 5 + 7 = 16 y la máxima suma es 3 + 5 + 7 + 9 = 24

```
16 24
```

### Descripción de la función

La función recibe los siguientes parámetros:

`arr`: arreglo de 5 enteros

### Formato de entrada

Una línea de enteros separados por espacios

### Formato de salida

Imprimir por consola dos enteros que representan la mínima y máxima suma. Los valores calculados pueden ser más grandes que un entero de 32 bits.

### Ejemplo de entrada

```
1 2 3 4 5
```

### Ejemplo de salida

```
10 14
```

### Explicación

Los números son 1, ,2 ,3 ,4 y 5. 

1. Suma todo excepto 1, la suma es 2  + 3 + 4 + 5 = 14.
2. Suma todo excepto 2, la suma es 1 + 3 + 4 + 5 = 13.
3. Suma todo excepto 3, la suma es 1 + 2 + 4 + 5 = 12.
4. Suma todo excepto 4, la suma es 1 + 2 + 3 + 5 = 11.
5. Suma todo excepto 5, la suma es 1 + 2 + 3 + 4 = 10.

## Mi código para resolverlo

- C#

```csharp
class Result
{
    public static void MiniMaxSum(List<int> arr)
    {
        long minSum = long.MaxValue;
        long maxSum = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            long sum = arr.Sum(c => (long)c) - (long)arr[i];
            if (sum > maxSum)
            {
                maxSum = sum;
            }
            if (sum < minSum)
            {
                minSum = sum;
            }
        }
        Console.WriteLine($"{minSum} {maxSum}");
    }
}
```