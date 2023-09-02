# Velas de la torta de cumpleaños (Birthday Cake Candles)

### Enunciado

Estas a cargo de la torta de cumpleaños. Has decidido que la torta tendrá una vela por cada año de su edad total. Solo podrán soplar la vela más alta. Cuenta cuantas velas son las más altas.

### Ejemplo

`candles` = [4, 4, 1, 3]

Las velas con la altura máxima son de 4 unidades de altura, hay 2 de esas, entonces retornamos 2.

### Descripción de la función

La función recibe los siguientes parámetros:

`int candles[n]`: altura de las velas

### Formato de entrada

La primera línea contiene un entero, **n**, indica la longitud del arreglo. La segunda línea contiene **n** enteros separados por espacios, donde cada entero describe la altura de una vela.

### Restricciones

1 ≤ **n** ≤ 10^5

1 ≤ **candles[i]** ≤ 10^7

### Ejemplo de entrada

```
4
3 2 1 3
```

### Ejemplo de salida

```
2
```

### Explicación

La altura de las velas es [3, 2, 1, 3], La vela más alta es de 3 unidades de altura y hay 2 de ellas.

## Mi código para resolverlo

- C#

```csharp
class Result
{
    public static int birthdayCakeCandles(List<int> candles)
    {
        int tallestCandle = 0;
        int quantity = 0;
        for(int i = 0; i < candles.Count; i++)
        {
            if(candles[i] > tallestCandle)
            {
                tallestCandle = candles[i];
            }
        }
        for(int i = 0; i < candles.Count; i++)
        {
            if(candles[i] == tallestCandle)
            {
                quantity++;
            }
        }
        return quantity;
    }
}
```