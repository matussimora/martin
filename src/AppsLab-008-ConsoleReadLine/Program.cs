Console.WriteLine("Zadaj prvé číslo");
int cislo1 = int.Parse(Console.ReadLine());
Console.WriteLine("Zadaj druhé číslo");
int cislo2 = int.Parse(Console.ReadLine());
Console.WriteLine("Zadaj operáciu +,-,*,/,%");
string operacia = Console.ReadLine();

int vysledok = operacia switch
{
    "+" => cislo1 + cislo2,
    "-" => cislo1 - cislo2,
    "*" => cislo1 * cislo2,
    "/" => cislo1 / cislo2,
    "%" => cislo1 % cislo2,
};

Console.WriteLine($"Tvoj vysledok je {vysledok}");