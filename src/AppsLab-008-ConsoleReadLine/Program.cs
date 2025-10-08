//Console.WriteLine("Zadaj prvé číslo");
//int cislo1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Zadaj druhé číslo");
//int cislo2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Zadaj operáciu +,-,*,/,%");
//string operacia = Console.ReadLine();

//int vysledok = operacia switch
//{
//    "+" => cislo1 + cislo2,
//    "-" => cislo1 - cislo2,
//    "*" => cislo1 * cislo2,
//    "/" => cislo1 / cislo2,
//    "%" => cislo1 % cislo2,
//};

//Console.WriteLine($"Tvoj vysledok je {vysledok}");

//Console.WriteLine("Zadaj číslom deň týždňa");
//int dayofweak = int .Parse(Console.ReadLine());

//switch (dayofweak)
//{
//    case 1:
//        Console.WriteLine("Pondelok");
//        break;
//        case 2:
//        Console.WriteLine("Utorok");
//        break;
//        case 3:
//        Console.WriteLine("Streda");
//        break;
//        case 4:
//        Console.WriteLine("Štvrtok");
//        break;
//        case 5:
//        Console.WriteLine("Piatok");
//        break;
//        case 6:
//        Console.WriteLine("Sobota");
//        break;
//        case 7:
//        Console.WriteLine("Nedeľa");
//        break;
//        default:
//        Console.WriteLine("Neplatný deň");
//        break;
//}
int numberDescription;
int; numberDescription  = numberDescription switch
{
 1 => "jeden",
 2 => "dva",
 3 => "tri",
 _ => "Neznáme číslo"
};

Console.WriteLine(numberDescription); //vypise:tri 