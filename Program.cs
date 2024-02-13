using _13_metody;

Kot bella = new Kot();
bella.imie = "Bella";
bella.waga = 6f;
bella.wiek = 9;
bella.kolorOczu = "Zolty";
bella.kolorSiersci = "Prazkowany";

string koniecProgramy = "koniec";
string wartosc = "";

while (wartosc != koniecProgramy)
{
    wartosc = Console.ReadLine();

    switch (wartosc)
    {
        case "info":
            bella.PokazInformacje();
            break;
        case "spac":
            bella.Spac();
            break;
        case "mysz":
            bella.ZlapacMysz();
            break;
        default: break;
    }
}