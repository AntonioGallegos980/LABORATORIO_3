// See https://aka.ms/new-console-template for more information
Console.WriteLine("dias de estadia :");
int dias = int.Parse(Console.ReadLine());
Console.WriteLine("que categoria de hotel desea");
Console.WriteLine("1)3 estrellas");
Console.WriteLine("2)5 estrellas");
int categoria = int.Parse(Console.ReadLine());
int precio;
switch (categoria)
{
    case 1:
        if (dias >= 1 && dias < 5)
        {
            precio = (dias * 100)+7;
            Console.WriteLine("pagara " + precio , "con desayuno incluido");
        }
        else if (dias >= 6 && dias < 10)
        {
            precio = (dias * 85) + 7;
            Console.WriteLine("pagara " + precio, "con desayuno incluido");
        }
        else if (dias >= 11)
        {
            precio = (dias * 70) + 7;
            Console.WriteLine("pagara " + precio, "con desayuno incluido");
        }
        
        break;
    case 2:
        if (dias >= 1 && dias < 5)
        {
            precio = (dias * 300) + 7;
            Console.WriteLine("pagara " + precio, "con desayuno incluido");
        }
        else if (dias >= 6 && dias < 10)
        {
            precio = (dias * 270) + 7;
            Console.WriteLine("pagara " + precio, "con desayuno incluido");
        }
        else if (dias >= 11)
        {
            precio = (dias * 250) + 7;
            Console.WriteLine("pagara " + precio, "con desayuno incluido");
        }
        
        break;

}
