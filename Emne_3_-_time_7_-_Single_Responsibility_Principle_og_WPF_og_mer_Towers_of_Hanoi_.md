# Planen for i dag
1. Single Responsibility Principle
    - SOLID
    - hvordan bryter gammel versjon med dette prinsippet?
    - ny versjon
    - dele opp i prosjekter/pakker = få hjelp av visual studio tit å håndheve
2. Intro WPF
    - preview arv
3. Towers of Hanoi i WPF med samme logikk

# Del 1

## SOLID
Solid Prinsipene:
    S - Single responsibility principle
    O - Open/closed principle
    L - Liskov substitution principle
    I - Interface segregation principle
    D - Dependency inversion principle

Blir liksom Level 1 på å ha mer fokus på arkitiktur, design patterns og generelt bare skrive god kode.

### Single responsibility principle

Gjelder uavhengig av objektorientert programmering, kan brukes på en metode og klasser generelt.

Prinsippet handler om at en del av koden skal bare ha ett ansvar.

Fordeler med dette:
- En del av koden kan bare ha en grunn til å forandre seg
    Hjelper oss å ungå "spaghetti" kode

## Ny Versjon av Hannoi Towers
Kan ha flere prosjekter i samme solution
- Kan velge hvem du vil boote opp med, ved å sette prosjekte du har lyst til å bruke til "startup project"

### Properties
- Kan skrive en property uten set f.eks: int num { get; }
    Som betyr at du forsatt sette den i constructoren, men etter det kan den ikke bli endret 

- Hvis du er nysering på hvor en property blir brukt.  
    Så kan du trykke shift + alt + f12, så viser den deg alle steder den blir brukt 
        (usikker om dette er fra VS eller Resharper)

### Klasser
Hvis ett felt i en Klasse er private, 
så kan du forsatt bruke det feltet i ett annet objekt så lenge du er i samme klasse. f.eks:
    private int Num;
    public int ReturnAddedNum(Class class){ return Num + class.Num }

### Readonly
Du kan skrive en property med bare get, på en litt annen måte
Hva vi først lærte:
    public bool IsComplete { get { return false; } }
Men det kan også skrives som:
    public bool IsComplete => return false;

### Stack
Stack betyr en stabel, å den fungerer med at du legger ting på toppen av hverandre

.Push() - Legger noe på toppen av stacken

.Pop() - Fjerner noe fra toppen av stacken

.Peek() - Se hva som ligger på toppen av stacken, uten å fjerne det

Syntaks for Stacks:
    Stack<Datatype> navnPåStack;
    f.eks Stack<int> nums; - Hadde vært en stack full av helle tall pga. int er datatypen

.ToArray - Kan gjøre om en stack til en array 

### Debugging
Viser ett veldig kort eksempel på debugging av spillet

### Brukergrensesnitt
Forskjellen fra forrige Hannoi Towers, er at nå liger alt brukergrensesnitt relatert kode inni klassen MyConsole
Og de ligger bare der som static metoder.

Selvom denne nye versjonen er bra i forhold til Single responsibility prinsippet,
Så utfordrer det innkapslingen av koden en del.
    
    Og det er fordi vi har alt brukergrensesnittet i MyConsole,
    og fordi det trenger å hente ut informasjon fra andre klasser.
    
    Så trenger da variablene våre å være public eller bli gjort om til properties som har {get; private set;}.
    og det gjør det vanskligere å holde på innkapslingen.

## Class Library
Er ikke en selvstending applikasjon, blir litt som en modul
    blir litt som en tilhenger til en bil

For at ett prosjekt skal bruke ett Class library må du legge det til som "dependencies",
dette gjør du med å høyreklikke på dependencies og så trykke "Add Project Reference".

For at klasser skal bli brukt i andre prosjekt, så må de også nå være public og ikke internal
    internal - betyr bare inni det prosjektet
    public - betyr at det kan bli brukt på tvers av prosjekt

Også må du huske å legge til "Using NyProsjektNavn;", til der du skal bruke det nye class library-et

Å dele opp koden i flere prosjekter kan være bra vis du enten skal dele deler av koden din,
eller den delen skal bli brukt på flere steder.

# Del 2

## Intro WPF
Begynner med å lage ett prosjekt med template "WPF Application"

WPF er det mest moderne for vanlige windows apps
    Fines andre Frameworks, men vis du kan ett er det lett å bruke andre

[STAThread] - Gjøre at programmet bruker bare 1 thread, siden WPF ikke funker så bra med flere threads

var app = new Application(); - Er for å lage en WPF app.

app.Run(); - Er for å starte app-en og den trenger et "window" for å starte med

var window = new Window(); - Er for å lage ett nytt vindu
    - Er en innebygd klasse fra WPF, for å lage nye vinduer

Du kan ha flere vinduer men bare hvem du putter i Run(), blir vist.

var button = new Button{ Content = "Teksten til knappen!" }; - For å lage en ny button i WPF

Ett window kan bare ha en content 
    f.eks: window.Content = button;
    Content blir litt som innerHtml i Html

var label = new Label{Content = "Tekst"}; - Label holder på noe text som skal bli vist fram

### Panels
Vis du skal sette mer en enn ting inni Content, så må du bruke en Panel
    En Panel er som en firkant på skjermen du kan ha andre ting inni

panelName.Children.Add() - Bruker man når man skal legge til ting til en panel


StackPanel - Blir litt som en div med flexbox layout
    med StackPanel så kan du endre retnigen ting blir lagt med { Orientation = Orientation.Horizontal}
        (Dette minner veldig om flex-direction i CSS)

### Events
button.Click += MetodeNavn; - Dette gjør at noe skjer når du klikker på knappen (som onclick i JS)

## Arv
Arv syntax: internal class ClickerPanel : StackPanel

Så i eksemplet over, så alt som ligger inni classen StackPanel havner nå inni klassen ClickerPanel 
    Så med andre ord ClickerPanel har tilgang alt det som ligger inni sin egen klasse, og i tillegg alt som ligger inni StackPanel

Viktig å vite når du skal bruke Arv og når du ikke skal bruke det

# Del 3

## Gjør Towers of Hanoi til WPF

### Stackpanel
I en StackPanel så kan du også bun justere ting med:
{ VerticalAlignment = VerticalAlignment.Bottom }

### Rectangle
I WPF så kan vi også lage en rektangel, er som en label uten text f.eks:
var rectangle = new Rectangle
{
    Width = 10 - størrelsen på rektangelet
    Height = 10 - høyden på rektangelet
    Fill = EnFarge - kan gi rektangelet en farge
    Margin = new Thickness() - kan sette en margin til rektangelet
};

### .Click
Når du skal bruke en button.Click i WPF og må bruke informasjon som ligger utenfor .Click metoden
    f.eks du kan ikke videre sende ett parameter i metoden som lager knappen som skal bruke .Click

Så kan det være smart å mellom lagre den informasjoen i en klasse så du kan bruke den i .Click metoden,
eller så kan du ha en metode som returnerer .click metoden, sånn du får sendt med hva du ville videre sende

### Modulus
Modulus( % ) er fin for å finne de andre index plassene i en loop fra index-en du er på f.eks.
    index = 1; indexB = (index + 1) % 2; indexC = (index + 2) % 2;
        Med dette over kan vi altid ha til gang til de 2 neste index-ene foran den vi er på, uansett om index = 1,2 eller 3.
        Og vis index-en går over 2, så starter den bare på 0 igjen.

### typeof
typeof(ting) - For å finne ut hvem datatype tingen du putter i parametere er 

### Insert
.Insert() - funker som .Add() men du kan velge posisjonen du putter det i