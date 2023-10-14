//La fecha de finalizacion de las actvidades academicas de la materia de Programacion 2, ciclo 2 2023 es el sabado 18 de noviembre de 2023
// el parcial sera llevado a cabo a partir de las 3:00 Pm hacer un programa en C# que:
// Muestre de manera automatica la fecha y hora actual del sistema
// Muestre por seperado el numero de dias, que faltan para el parcial 3 
// Muestre la fecha en formato 14/10/2023, 14 Oct 2023, 2023 oct 14 

public class Ejercicio3
{
    public static void Main()
    {
        DateTime Fecha_Actual_del_sistema = DateTime.Now;//Ojo la del sistema 
        DateTime Fecha_del_Parcial = new DateTime(2023, 11, 18, 15, 0, 0); // sabado 18 de noviembre de 2023 el parcial sera llevado a cabo a partir de las 3:00 Pm 
        TimeSpan Dias_Para_Parcial = Fecha_del_Parcial - Fecha_Actual_del_sistema;
        int Tiempo_Dias = Dias_Para_Parcial.Days;
        Console.WriteLine("Fecha y hora actual del sistema: " + Fecha_Actual_del_sistema);
        Console.WriteLine("Número de días restantes para el parcial 3: " + Tiempo_Dias + " dias");
        Console.WriteLine();
        //Fecha de formatos:
        Console.WriteLine("Se presentas las fechas en formato: ");
        Console.WriteLine(Fecha_Actual_del_sistema.ToString("dd/MM/yyyy"));
        Console.WriteLine(Fecha_Actual_del_sistema.ToString("dd MMM yyyy"));
        Console.WriteLine( Fecha_Actual_del_sistema.ToString("yyyy MMM dd"));
    }
}

//Hecho por Josue Bryan Hernandez Zelaya