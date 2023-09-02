# Detalle de la escalera (Staircase detail)

### Enunciado

Esta es una escalera de tamaño **n** = 4

```
   #
  ##
 ###
####
```

Su base y su altura son iguales a **n**. Se dibuja usando el símbolo `#` y espacios. La última línea no va precedida de ningún espacio.

### Descripción de la función

La función recibe los siguientes parámetros:

- int **n**: un entero

### Formato de entrada

Un único entero, **n**, que denota el tamaño de la escalera.

### Restricciones

0 ≤ **n** ≤ 100

### Formato de salida

Imprime la escalera de tamaño n, usando el símbolo `#` y espacios.

### Ejemplo de entrada

```
6
```

### Ejemplo de salida

```
     #
    ##
   ###
  ####
 #####
######
```

### Explicación

La escalera es alineada de derecha a izquierda, compuesta por el símbolo `#` y espacios, tiene un alto y un ancho de **n** = 6

## Mi código para resolverlo

- C#

```csharp
class Result
{
    public static void Staircase(int n)
    {
        foreach(int value in Enumerable.Range(1, n))
        {
            Console.WriteLine(new string(' ', n - value) + new string('#', value));
        }
    }
}
```