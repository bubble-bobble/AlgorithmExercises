# Simple suma de un arreglo (Simple array sum)

### Enunciado

Dado un arreglo de enteros, encuentra la suma de sus elementos, por ejemplo:

```
ar = [1, 2, 3], 1 + 2 + 3 = 6, retorna 6.
```

### Descripción de la función

Debe retornar la suma de los elementos del arreglo como un entero, la función recibe como parámetro:

- ar: un arreglo de enteros

### Formato de entrada

La primera línea contiene un entero, n, que indica el tamaño de la matriz. La segunda línea contiene n enteros separados por espacios que representan los elementos de la matriz.

### Restricciones

```
0 < n, ar[i] <= 1000
```

### Formato de salida

Imprime la suma de los elementos del arreglo, como un único entero.

### Entrada de ejemplo

```
6
1 2 3 4 10 11
```

### Salida de ejemplo

```
31
```

### Explicación

Imprimiremos la suma de los elementos de arreglo

```
1 + 2 + 3 + 4 + 10 + 11 = 31
```

## Mi código para resolverlo

- Usando C#

```csharp
class Result
{
    public static int SimpleArraySum(List<int> ar)
    {
        int sum = 0;
        for(int i = 0; i < ar.Count; i++)
        {
            sum += ar[i];
        }
        return sum;
    }
}
```