{
    Console.WriteLine("Ahoj ako sa voláš?");
    string? meno = Console.ReadLine();
    Console.WriteLine(" Ahoj, " + meno + " koľko máš rokov. ");
    string vstup = Console.ReadLine() ?? "0";
    int vek = int.Parse(vstup);
    Console.WriteLine("Aha, máš teda " + vek + " rokov.");

    Console.WriteLine("Aké je tvoje obľúbené jedlo?");
    string? jedlo = Console.ReadLine() ?? "0";
    Console.WriteLine("Aha takže tvoje obľúbene jedlo je" +  jedlo);

    Console.WriteLine("Stlač klávesu");
    var key = Console.ReadKey();
    Console.WriteLine();      
    Console.WriteLine($"Stlačili ste klávesu: {key.KeyChar}");
}
