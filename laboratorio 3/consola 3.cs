// See https://aka.ms/new-console-template for more information
Console.WriteLine("cuantos años tiene el participante :");
int años = int.Parse(Console.ReadLine());
Console.WriteLine("cuantas adivinanzas logro desifrar el concursante: ");
int adi = int.Parse(Console.ReadLine());
int total;
if (años>=18)
{
	if (adi<3)
	{
		total = (años * 5) + (adi * 2) + 30;
		Console.WriteLine("su monto a ganar es de :" + total, "soles");
	}
	else if (adi>3 && adi<5)
    {
        total = (años * 5) + (adi * 2) + 50;
        Console.WriteLine("su monto a ganar es de :" + total, "soles");
    }
}
else if (años<18)
{
    if (adi < 3)
    {
        total = (años * 5) + (adi * 2) + 50;
        Console.WriteLine("su monto a ganar es de :" + total, "soles");
    }
    else if (adi > 3 && adi < 5)
    {
        total = (años * 5) + (adi * 2) + 80;
        Console.WriteLine("su monto a ganar es de :" + total, "soles");
    }
}
