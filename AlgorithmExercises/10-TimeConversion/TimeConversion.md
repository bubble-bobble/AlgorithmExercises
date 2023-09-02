# Conversión de tiempo (Time Conversion)

Dado el tiempo en formato de 12 horas (AM, PM), conviértalo a formato militar (24 horas).

- **Nota**: **12:00:00AM** en un reloj de **12** horas es **00:00:00** en un reloj de **24** horas. **12:00:00PM** en un reloj de **12** horas es **12:00:00** en un reloj de **24** horas.

### Ejemplo

`s` = ‘12:01:00PM’ → retorna ‘12:01:00’

`s` = ‘12:01:00AM’ → retorna ‘00:01:00’

### Descripción de la función

La función recibe lo siguientes parámetros:

- `string s`: el tiempo en formato de 12 horas.

Retorna 

- string: el tiempo en formato de 24 horas.

### Formato de entrada

Una cadena de caracteres s, que representa el tiempo en formato de 12 horas (`hh:mm:ssAM` o `hh:mm:ssPM`).

### Restricciones

Todas las entradas de tiempo son validas.

### Ejemplo de entrada

```
07:05:45PM
```

### Ejemplo de salida

```
19:05:45
```

## Mi código para resolverlo

- C#

```csharp
class Result
{
    public static string TimeConversion(string s)
    {
        string[] timeSeparated = s.Split(':');
        string period = (timeSeparated[2][2]  == 'A') ? "AM" : "PM";
        string result = string.Empty;
        if(period == "AM" && timeSeparated[0] == "12")
        {            
            int hours = Convert.ToInt32(timeSeparated[0]) - 12;
            string seconds = timeSeparated[2].Replace(period,"");
            result = $"{hours}0:{timeSeparated[1]}:{seconds}";
        }
        else if(period == "PM" && timeSeparated[0] == "12")
        {
            string seconds = timeSeparated[2].Replace(period,"");
            result = $"{timeSeparated[0]}:{timeSeparated[1]}:{seconds}";
        }
        else if(period == "AM")
        {
            string seconds = timeSeparated[2].Replace(period,"");
            result = $"{timeSeparated[0]}:{timeSeparated[1]}:{seconds}";
        }
        else
        {
            int hours = Convert.ToInt32(timeSeparated[0]) + 12;
            string seconds = timeSeparated[2].Replace(period,"");
            result = $"{hours}:{timeSeparated[1]}:{seconds}";
        }
        return result;
    }
}
```