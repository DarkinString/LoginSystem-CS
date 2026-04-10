using System.Collections.Generic;
Console.WriteLine("Bienvenido a el Log-in, para continuar ingrese su usuario y contraseña");
List<string> usuarios = new List<string> {"Missael" , "Paola", "Administrador"};
List<string> contraseñas = new List<string> {"Goya", "Yummi", "Patas"};

int intentos = 0;
bool acceso = false;

while( intentos < 3 && !acceso )
{
Console.WriteLine("Usuario");
string usuarioInput = Console.ReadLine()!;
Console.WriteLine("Contraseña");
string contraseñaInput = Console.ReadLine()!;
    for(int i = 0; i < usuarios.Count; i++)
    {
        if(usuarioInput == usuarios[i] && contraseñaInput == contraseñas[i])
        {
            acceso = true;
            Console.WriteLine($"Bienvenido {usuarioInput}");
            break;
        }
    }
    intentos++;

    if( !acceso)
    {
        Console.WriteLine($"Usuario o contraseñas incorrectos, numero de intentos disponibles {3 - intentos}");
    }
}
if( !acceso)
    {
        Console.WriteLine("Usuario o contraseñas incorrectos, numero máximo de intentos alcanzados");
    }