using System.Collections.Generic;

public class Contacto


{
    // almacena el nombe
    public string Nombre { get; set; }

    // almacena el apellido
    public string Apellido { get; set; }

    // almacena el apellido 
    public string Direccion { get; set; }

    // almacena el correo 
    public string Correo { get; set; }

    public List<string> Telefonos { get; } = new List<string>();
    public List<string> PalabrasClave { get; } = new List<string>();

    public override string ToString()


    {
        // devuelve el nombre copleto 
        return Nombre + " " + Apellido;
    }
}