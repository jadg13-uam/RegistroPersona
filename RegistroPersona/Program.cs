/*Registrar los datos de una persona
 nombres, apellidos, sexo, edad
 */

using System.Data;

struct Persona
{
    public string nombres;
    public string apellidos;
    public Boolean sexo;
    public int edad;
}

class Program()
{
    static Persona[] personas = new Persona[10];

    public static void Agregar(String nom, String ape, int eda, Boolean sex, int posicion)
    {
        Persona per = new Persona();
        per.nombres = nom;
        per.apellidos = ape;
        per.edad = eda;
        per.sexo = sex;
        personas[posicion] = per;
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro guardado.");
        Console.ResetColor();

    }
    public static void PedirDatos(int pos)
    {
        string nombres;
        string apellidos;
        bool sexo;
        int edad;

        Console.Write("Dime tu nombre: ");
        nombres = Console.ReadLine();
        Console.Write("Dime tu apellido: ");
        apellidos = Console.ReadLine();
        Console.Write("Dime tu sexo [True: Hombre - False: Mujer]: ");
        sexo = Boolean.Parse(Console.ReadLine());
        Console.Write("Dime tu edad: ");
        edad = int.Parse(Console.ReadLine());
        Agregar(nombres, apellidos, edad, sexo, pos);

    }


    public static void Main()
    {
       

        

}
    
}



