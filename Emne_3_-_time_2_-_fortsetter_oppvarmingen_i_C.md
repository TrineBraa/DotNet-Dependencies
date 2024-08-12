# Emne 3 - Time 2 - Fortsetter oppvarmingen i C#

## Planen for i dag
top-level statements
de viktigste datatypenen
var
casting, parse
enum
overloads og default parametre
arrays
tillfeldige tall
Game of life

## Del 1

Setting når du lagger ett nytt prosjekt
    Viste hva å ikke bruke top level statements gjør

### De viktigste datatypene

int n = 5; - hell tall
double d = 1.44; - desimaler

string s = "tekst"; - tekst
char c = s[5]; - bokstav

bool b = true; - true / false

Du kan bruke ordet var istedet for datatypen
    var kan du bare bruke når du deklarerer og lager variablen på samme linje.
    var kan ikke brukes globalt, er bare lokale variabler som kan bruke var.

Variabler er i metoder er lokale fra vanlig

### Convert, casting og parse

Disse konverterer hva det får inn til int, funker med andre datatyper også
Convert.ToInt32()
int.Parse()

Convert table (ikke ferdig)
            int     char    double    string     bool
int          x               auto     
char                  x 
double
string    convert
bool

## Del 2

ctrl + d for å duplisere en linje

Resharper eksempel
    hvordan lage en metode fra et kall

### Enumarations

ny datatype enum

enum Weekday
{
    Monday, 
    Tuesday,
    Wednesday,
    Thursday,
    Friday, 
    Saturday,
    Sunday,
}

referere det med f.eks Weekday.Monday

enum har ett tall automatisk tilknyttet til vær data inni. Litt som en array i JS
    Du kan også manualet sette dette tallet f.eks: enum Weekday {Monday = 100,} Da blir tallet til 100

Casting er å tvinge noe til en annen datatype
    kan f.eks bruke det til å valge en dag med et number i Weekday enum lista
        var aDay = (Weekday) 2; i dette eksemplet hadde du fått dag number 2 i enum Weekday

### Overloads
    du kan lage metoder med samme navn, så lenge de ikke tar i mot samme datatype eller returnerer samme datatype
    og da skjønner C# hvem metode den skal bruke f.eks
        hvis du har Greet(string name) og Greet()
        så hvis du kaller Greet("navn") og Greet(). Vil den da vite hvem den skal bruke

### Default parameter

Så vis du har en metode som skal returne noe, men den tar ikke altid inn noe så kan du skrive det sånn her

static void Greet(string name = "du"){ Console.WriteLine($"Hei, {name}");}
    Hvordan dette funker er når du kaller opp Greet og du sender en string med i parametere f.eks Greet("Audun") så vil den printe ut "hei, Audun"
        Men vis du ikke sender noe med f.eks. bare Greet() så vil den bruke den defaulte verdien og printe ut "hei, du".

De som skjer i praksis er at når du legger til en default parameter er at C# generer en kodebit for deg som ser ut som dette i dette tilfele
    Greet(){
        Greet("du")
    }
    så om du bare skriver det sånn over eller legger til en default parameter så gjør det ingen forskjell i praksis


### Tilfeldige tall

var random = new Random();
    Generer et random tall

random.Next(90, 100);
    gir ett tall fram og med 90 til 100.


## Del 3

### Arrays

int array full syntax
    int[] numbers = new int[10];    // JS let numbers = []; numbers.length = 10;
    kan også skrives sånn: var numbers = new int[10];

    foreach(var number in numbers)  // JS: for (let number of numbers)
        kan også skrives som en vannlig for løkke

    alle datatyper i C# har en default verdi
    og en tom array vil bare ha den default verdien

    for å legge til arrayen
        numbers[0] = 1;

    kan også skrives
    var numbers = new int[] = {1, 2, 3, 4, 5,}

    Viktigste forskjeller fra JS:
        - fast lengde, kan ikke endres
        - sterkt typet + samme datatype for alle elementer
        - en "fersk" array blir initialisert med default-verdi til datatypen

### Game of life

Viser fram game of life

Forklarer forskjellen mellom JS og C# litt grundigere
