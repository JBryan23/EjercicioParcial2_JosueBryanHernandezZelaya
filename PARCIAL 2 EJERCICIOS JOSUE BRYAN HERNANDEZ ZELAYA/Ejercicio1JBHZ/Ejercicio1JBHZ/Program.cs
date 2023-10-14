// El reuter principal se le pide desarrollar un programa en c# donde permita ingresar la clave por defecto(AdministradorR)
// para que pueda realizar las configuraciones de respaldo, a todo esto se pide que como requesito que el ingreso de la clave
// del teclado sea independiemte de si esta activo las letras mayusculas o minusculas, tenga espacios blanco, tabulaciones, etc,
// donde se debe hacer las transformaciones necesarias para que estas no afectan su comparacion

public class Ejercicio1
{
    public static void Main()
    {
        string Clave_Por_Defecto = "AdministradorR"; 

        Console.Write("Usuario porfavor ingrese la clave que se tiene por defecto: ");
        string Clave_Del_Usuario = Console.ReadLine();
        Clave_Del_Usuario = Clave_Del_Usuario.ToLower().Trim();
        Clave_Por_Defecto = Clave_Por_Defecto.ToLower();
        //Validar si la contraseña esta correcta o no para poder ingresar
        if (Clave_Del_Usuario == Clave_Por_Defecto)
        {
            Console.WriteLine("Su clave es correcta tiene acceso para realizar las configuraciones de respaldo.");
        }
        else
        {
            Console.WriteLine(@"Su clave es incorrecta su acceso no sera posible para realizar las configuraciones de respaldo.
(Asegurese que haya escrito bien la clave)");
        }
    }
}

//Hecho por Josue Bryan Hernandez Zelaya