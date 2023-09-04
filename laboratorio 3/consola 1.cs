// See https://aka.ms/new-console-template for more information
Console.WriteLine("escoja que fruta va a transprotar:");
Console.WriteLine("a)naranja");
Console.WriteLine("b)fresa");
Console.WriteLine("c)mango");
string fruta = Console.ReadLine();
char frut = char.Parse(fruta);
Console.WriteLine("ingrese la distancia de recorrido");
int distancia=int.Parse(Console.ReadLine());
Console.WriteLine("escibre la cantidda de cajas que se transportara:");
int cajas =int.Parse(Console.ReadLine());
int precio;
if (distancia < 30)
{
    switch (frut)
    {

        case 'a':
            precio = 2 * cajas;
            Console.WriteLine("debes de pagar " + precio);
            break;
        case 'b':
            precio = 6 * cajas;
            Console.WriteLine("debes de pagar " + precio);
            break;
        case 'c':
            precio = 3 * cajas;
            Console.WriteLine("debes de pagar " + precio);
            break;
        
    }
}
else if (distancia > 30)
{
    switch (frut)
    {

        case 'a':
            precio = 4 * cajas;
            Console.WriteLine("debes de pagar " + precio);
            break;
        case 'b':
            precio = 9 * cajas;
            Console.WriteLine("debes de pagar " + precio);
            break;
        case 'c':
            precio = 5 * cajas;
            Console.WriteLine("debes de pagar " + precio);
            break;
        
    }
}
