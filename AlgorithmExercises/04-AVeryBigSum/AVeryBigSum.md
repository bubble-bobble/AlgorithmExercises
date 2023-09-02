# Una gran suma (A very big sum)

### Enunciado

Es requerido calcular e imprimir la suma de los elementos de un arreglo, teniendo en mete que los enteros del arreglo son muy grandes.

### Descripción de la función

La función debe retornar la suma de todos los elementos del arreglo, está función recibe como parámetro:

- int ar[n]: un arreglo de enteros

Debe retornar:

- long: la suma de los elementos del arreglo

### Formato de entrada

La primera línea de entrada consiste en un entero **n**, la siguiente línea con tiene **n** enteros contenidos en el arreglo, separados por espacios.

### Formato de salida

Retorna la suma entera de los elementos del arreglo.

### Restricciones

```
1 <= n <= 10
0 <= ar[i] <= 10^10
```

### Ejemplo de entrada

```
5
1000000001 1000000002 1000000003 1000000004 1000000005
```

### Ejemplo de salida

```
5000000015
```

### Nota

El rango de los enteros de 32 bits es:

-2^31 hasta 2^31 -1 ó [-2147483648, 2147483647]

Cuando sumamos varios valores enteros, la suma resultante puede exceder el rango anterior. Puede que necesites utilizar long int C/C++/Java para almacenar dichas sumas.

## Mi código para resolverlo

- C#

```csharp
class Result
{
    public static long AVeryBigSum(List<long> ar)
    {
        long result = 0;
        for(int i = 0; i < ar.Count; i++)
        {
            result += ar[i];
        }
        return result;
    }
}
```