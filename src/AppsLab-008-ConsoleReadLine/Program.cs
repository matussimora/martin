{
    //privitanie
    Console.WriteLine("Moja prvá kalkulačka");

    //načitam čislo
    string? prveCislo = Console.ReadLine();
    //načitam 2. číslo
    string? druheCislo = Console.ReadLine();
    //spravim sucet
    int sucet = int.Parse(prveCislo) + int.Parse(druheCislo);
    //vypíšem sučet
    Console.WriteLine($"Súčet:" + sucet);

}