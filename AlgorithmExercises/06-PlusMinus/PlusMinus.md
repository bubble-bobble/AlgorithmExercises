# Más o menos (Plus-minus)

### Enunciado

Dado un arreglo de enteros, calcular que porcentaje de los elementos son positivos, negativos y cero. Muestra el valor decimal de cada fracción en una nueva línea con 6 dígitos después del decimal.

**Nota**: Este reto introduce problemas de precisión. Las pruebas unitarias están escaladas hasta 6 lugares de decimales. Aunque se aceptan respuestas con un error absoluto hasta de 10^-4.

### Ejemplo

```
arr = [1, 1, 0, -1, -1]
```

En el arreglo hay n = 5 elementos, dos positivos, dos negativos y un cero. Sus porcentajes serían 2/5 = 0.400000, 2/5 = 0.400000 y 1/5 = 0.200000.

El resultado sería:

```
0.400000
0.400000
0.200000
```

### Descripción de la función

La función recibe los siguientes parámetros:

- int arr[n]: un arreglo de enteros

### Imprimir

Imprime los porcentajes de positivos, negativos y cero de los valores en el arreglo. Cada valor debe ser impreso en líneas separadas con 6 dígitos después del decimal. La función no debe retornar ningún valor.

### Formato de entrada

La primera línea contiene un entero, **n**, que corresponde a el largo del arreglo. La segunda línea contiene **n** enteros separados por espacios que describen el arreglo **arr[n]**.

### Restricciones

0 < n ≤ 100

-100 ≤ **arr[i]** ≤ 100

### Formato de salida

Imprimir 3 líneas, cada una con 7 decimales.

1. Proporción de los valores positivos
2. Proporción de los valores negativos
3. Proporciones de los ceros

### Ejemplo de entrada

```
STDIN           Función
-----           --------
6               arr[] largo n = 6
-4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]
```

### Ejemplo de salida

```
0.500000
0.333333
0.166667
```

### Explicación

En el arreglo hay 3 números positivos, 2 números negativos y un cero. Las proporciones de ocurrencia positiva son: 3/6 = 0.500000, negativos 2/6 = 0.333333 y ceros 1/6 = 0.166667

## Mi código para resolverlo

- C#

```csharp
class Result
{
    public static void PlusMinus(List<int> arr)
    {
        int positives = 0;
        int negatives = 0;
        int zeros = 0;
        for(int i = 0; i < arr.Count; i++)
        {
            if(arr[i] == 0)
            {
                zeros++;
            }
            if(arr[i] > 0)
            {
                positives++;
            }
            if(arr[i] < 0)
            {
                negatives++;
            }
        }
        Console.WriteLine("{0:N6}", ((double)positives / arr.Count));
        Console.WriteLine("{0:N6}", ((double)negatives / arr.Count));
        Console.WriteLine("{0:N6}", ((double)zeros / arr.Count));        
    }

}
```