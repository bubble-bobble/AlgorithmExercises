# Resuélveme primero (Solve me first)

### Enunciado

Completa la función que calcula la suma de dos enteros, ejemplo:

```
a = 7
b = 3
```

### Descripción de la función

La función recibe los siguientes parámetros:

```
a: entero, el primer valor
b: entero, el segundo valor
```

### Restricciones

```
1 <= a,b <= 1000
```

### Entrada de ejemplo

```
a = 2
b = 3
```

### Salida de ejemplo

```
5
```

### Explicación

```
2 + 3 = 5
```

## Mi código para resolverlo

- Usando C#

```csharp
class Solution
{
    static int SolveMeFirst(int a, int b) { 
        return a + b;
    }
}
```