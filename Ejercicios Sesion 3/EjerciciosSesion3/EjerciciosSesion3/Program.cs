/**
 Ejercicio 1

Crea una estructura de datos para un cliente con estos campos:

Nombre completo

Teléfono

Dirección

Email

Si es nuevo cliente

Bonus: escribe un método para presentar estos datos desde la estructura al hacer Console.WriteLine(...)
 
 
 */


Client myClient = new Client("Cristian", 33259876, "Honduras", "crpaz21@hotmail.com");
Console.WriteLine(myClient);


public struct Client
{

    public Client(string name, long phone, string address, string email)
    {
        Name = name;
        Phone = phone;
        Address = address;
        Email = email;
    }

    public string Name { get; set; }
    public long Phone { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"Hello {Name} {Address} {Phone} {Email}";
    }
}