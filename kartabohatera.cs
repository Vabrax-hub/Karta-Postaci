// zmienne i obliczenia

const int maxHP = 150;
const int maxPojemonscPlecaka = 20;

Console.WriteLine("Podaj imię bohatera: ");
string imie = Console.ReadLine();
Console.WriteLine("Podaj symbol bohatera: ");
char symbol = char.Parse(Console.ReadLine());
Console.WriteLine("Podaj aktualny poziom życia: ");
int aktualneHP = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj siłe bohatera: ");
int siła = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj bonus ataku broni: ");
int premiaBroni = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj mnożnik obrażeń krytycznych: ");
double mnoznikKryt = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj ilość zajetych miejsc w plecaku: ");
int zajetyPlecak = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj ilość złota: ");
int złoto = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczebność drużyny: ");
int party = int.Parse(Console.ReadLine());
Console.WriteLine("Czy bohater ma mape? (true/false)");
bool mapa = bool.Parse(Console.ReadLine());

złoto += 27; // nagroda za misje
złoto -= 4; // naprawa eq

int obrazenia = siła + premiaBroni;
int pojemnoscPlecaka = maxPojemonscPlecaka - zajetyPlecak;
double obrkryt = obrazenia * mnoznikKryt;
int złotoDruzyna = złoto / party;
int skarbiec = złoto % party;

int kryt = (int)obrkryt;
double procentZdrowia = ((double)aktualneHP / maxHP) * 100;

bool zyje = procentZdrowia > 0;
bool wolneMiejsce = pojemnoscPlecaka > 0;
bool leczenie = aktualneHP < maxHP;
bool gotowy = mapa && wolneMiejsce && zyje;

// wyswietlanie karty

Console.WriteLine("========================================");
Console.WriteLine("             KARTA POSTACI              ");
Console.WriteLine("========================================");
Console.WriteLine($"Bohater: {imie} [{symbol}]");
Console.WriteLine($"Zdrowie: {aktualneHP}/{maxHP} ({procentZdrowia:F2}%)");    
Console.WriteLine($"Zwykłe obrażenia: {obrazenia}");
Console.WriteLine($"Obrażenia krytyczne: {kryt}");
Console.WriteLine($"Plecak: zajęte {zajetyPlecak}/{maxPojemonscPlecaka}, wolne miejsca: {pojemnoscPlecaka}");
Console.WriteLine($"Ilość osób w drużynie: {party}");
Console.WriteLine($"Złoto: {złoto} monet (Dla drużyny: {złotoDruzyna} na osobę, w skarbcu: {skarbiec})");
Console.WriteLine("----------------------------------------");
Console.WriteLine("STAN PRZYGOTOWANIA DO WYPRAWY:");
Console.WriteLine($"- Żyje: {zyje}");
Console.WriteLine($"- Ma miejsce w plecaku: {wolneMiejsce}");
Console.WriteLine($"- Gotowy do wyprawy: {gotowy}");
Console.WriteLine($"- Wymaga leczenia: {leczenie}");
Console.WriteLine("========================================");
