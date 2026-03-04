//Cree un diccionario que almacene usuario y contraseña.
//Imprima la contraseña de un usuario específico.

Dictionary<string, int> usuarios  = new Dictionary<string, int>();

usuarios.Add("Carlos", 1234);
usuarios.Add("Josue", 12345);
usuarios.Add("Armando", 123456);

string nombre = "Carlos";
int contraseña = usuarios[nombre];
Console.WriteLine("la contraseña es: " + contraseña);