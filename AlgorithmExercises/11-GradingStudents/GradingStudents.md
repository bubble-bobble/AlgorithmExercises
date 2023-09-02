# Calificando estudiantes (Grading Students)

### Enunciado

La universidad de HackerLand tiene la siguiente política de calificaciones:

- Cada estudiante recibe una calificación en el rango inclusivo de 0 a 100.
- Cada calificación menor a 40 es una calificación de suspenso.

Sam es profesor de la universidad y le gusta redondear las calificaciones de sus alumnos de acuerdo a las siguientes reglas.

- Si la diferencia entre la calificación y el siguiente múltiplo de 5 es inferior a 3, redondea la nota al siguiente múltiplo de 5.
- Si la nota es inferior a 38, no se redondea, ya que el resultado seguirá siendo una calificación de suspenso.

### Ejemplo

- calificación = 84 se redondea a 85 (85 - 84 es menor a 3)
- calificación = 29 no se redondea (el resultado es menor a 40)
- calificación = 57 no se redondea (60 - 57 es 3 o mayor)

Dado el valor inicial de para la calificación de cada uno de los alumnos de Sam,  automatiza el proceso de redondeo.

### Descripción de la función

La función recibe los siguientes parámetros:

- `int calificaciones[n]`: las calificaciones antes del redondeo.

### Retorno

- `int[n]`: las calificaciones después del redondeo.

### Formato de entrada

La primera línea contiene un entero, `n`, corresponde al numero de estudiantes.

Cada línea `i` de las `n` siguientes contiene un único número entero `calificaciones[i]`.

### Restricciones

1 ≤ `n` ≤ 60

0 ≤ `calificaciones[i]` ≤ 100

### Ejemplo de entrada

```
4
73
67
38
33
```

### Ejemplo de salida

```
75
67
40
33
```

### Explicación

| Id | Calificación original | Calificación final |
| --- | --- | --- |
| 1 | 73 | 75 |
| 2 | 67 | 67 |
| 3 | 38 | 40 |
| 4 | 33 | 33 |
1. El estudiante 1 obtuvo un 73, el siguiente múltiplo de 5 desde 73 es 75. 75 - 73 < 3, la calificación se redondea a 75.
2. El estudiante 2 obtuvo un 67, el siguiente múltiplo de 5 desde 67 es 70. 70 - 67 = 3, la calificación no se redondea y la calificación final queda como 67.
3.  El estudiante 3 obtuvo un 38, el siguiente múltiplo de 5 desde 38 es 40. 40 - 38 < 3, la calificación se redondea a 40.
4. El estudiante 4 obtuvo un 33, la calificación no se redondea y la calificación final queda como 33.

## Mi código para resolverlo

- C#

```csharp
class Result
{
    public static List<int> GradingStudents(List<int> grades)
    {
        List<int> finalGrades = new List<int>();
        for (int i = 0; i < grades.Count; i++)
        {
            if (grades[i] < 38)
            {
                finalGrades.Add(grades[i]);
            }
            else
            {
                int nextMultipleOfFive = grades[i];
                while (nextMultipleOfFive % 5 != 0)
                {
                    nextMultipleOfFive++;
                }
                if (nextMultipleOfFive - grades[i] > 3)
                {
                    finalGrades.Add(grades[i]);
                }
                else if(nextMultipleOfFive - grades[i] == 3)
                {
                    finalGrades.Add(grades[i]);
                }
                else
                {
                    finalGrades.Add(nextMultipleOfFive);
                }
            }
        }
        return finalGrades;
    }
}
```