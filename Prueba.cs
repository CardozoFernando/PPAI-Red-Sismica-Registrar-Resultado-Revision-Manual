using System;

public class Class1
{
	public Class1()
	{
		// Aquí puedes poner tus métodos o propiedades para probar
        public static void ProbarRandom()
    {
        Random rnd = new Random();
        int numero = rnd.Next(0, 3); // Número entre 0 y 2
        System.Windows.Forms.MessageBox.Show($"Número aleatorio: {numero}");
    }

    public static string ObtenerSaludo()
    {
        return "¡Hola desde MiClaseDePrueba!";
    }
}

