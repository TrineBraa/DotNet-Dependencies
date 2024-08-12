# Planne for i dag
Trafikklys
— skrive mer objektorientert
— innkapsling — mulig å bytte implementasjon
— properties
— andre eksempler?
— generelt om objektorientert tenking

# Del 1

## Trafikklys

Console.OutputEncoding = Encoding.UTF8 - Må bruke denne hvis du skal bruke tegn spesial tegn som ikke er ASCII tegn

Console.Clear() - blanker ut skjermen

Console.ForegroundColor - bruker dette til å sette fargen til en ConsoleColor
    - f.eks Console.ForgroundColor = ConsoleColor.Gray

ConsoleColor holder 16 forskjellige farger som du kan velge mellom til å bruke i konsolen
    - f.eks var color = ConsoleColor.Red

ctrl + r + ctrl + r - Rename en variabel på all stedene den er (Resharper)

## Innkapsling

Innkapsling i utgangs punktet prøver å ha alle variablene våre private i en klasse

Er for å ungå å lage ugyldige tilstander, når du gjør endringer utenfor klassen


# Del 2

## Innkapsling pt.2

Fordelen er at vi kan endre på innsiden, så lenge vi tilbyr det samme på utsiden

Alle variabler som er deklaret utenfor en metode men på klasse nivå, har en default value vis du ikke gir den en
    f.eks int sin default value er 0, string sin default value er null, osv., osv.

Eksempler som viser måter for å få tak i om yellow er false eller true:
    yellow = phase == 0 || phase == 1;
Kan også skrives som:
    yellow = phase is 0 or 1;
Eller:
    yellow = phase % 2 == 1;

Innkapsling blir å nesten bare jobbe via metoder og at alle variablene er private så de bare kan bli endret inni klassen

## Constructor
ctorf - for å lage en constructor med alle feltene ferdig i den
ctorp - for å lage en constructor med alle properties ferdig i den

Hvis du ikke leger inn en constructor selv, så leger da kompilatoren inn en tom constructor for deg
    som ser slik ut: public ClassName(){}

Når du legger inn en constructer selv inni klassen, så stopper den å legge til en tom constructor for deg.
    Så det kan skje situasjoner hvor du må manuelt, legge inn en tom constructor inni klassen din.

Du kan Overloade constructorer, som betyr at du kan ha flere av de så lenge de ikke deler helt like argumeter
    så f.eks public ClassName(int Age){}; og public ClassName(string Name){}; hadde funket bra

## Innkapsling pt.3
Hvis du vil vise fram en variabel som er privat i klassen utenfor klassen 
    Så kan du bare lage en metode som "viser" fram variablen f.eks:
        public void GetVariabel() { return _variabel}

    Samme vis du har lyst å endre på en variabel som er privat fra utsiden av klassen,
        så lager du bare en metode som kan endre variablen for deg f.eks:
            public void SetVariabel(string variabel){ _variabel = variabel;}

ctrl + r + ctrl + e, for å bruke resharper til å legge til properties til variablen du er på for deg

Med properties kan du gjøre det over mye lettere ved å gjøre det direkte i variablen f.eks:
    public string Name { get; private set;};
        Da kan du forsatt se på og få tak i den utenfor klassen fordi property-en er public,
            men du kan bare endre på veriden til property-en i klassen, fordi "set" er sat til private.

Opprinnelig syntaksen til properties:
    public int VariabelName
    {
        get
        {
            return variabelName;
        }
        private set
        {
            variabelName = value;
        }
    }

# Del 3

## Clicker eksempel (Repitisjon) 
Gjør Clicker koden som den er innkapslet
    - Gjør først variablene private 
    - Så etterpå gjør vi variablene om til properties som ser slikt ut: public int Points { get; private set; }.
        Slikt at vi kan bruke verdiene til properties-en utenfor klassen, men forsatt bare endre på verdien til den inni klassen.
        
Prøv deg ut først med bare private variabler.
    Men vis du må åpne opp for lesing av variablene fra uten for klassen, kan du bruke en property med public get og private set.

Hvis det blir vanskelig med innkapsling, så lønner det seg ofte å skrive om koden.

Hvis du har en sitasjon hvor det kan være vansklig å gjøre innkapsling, fordi du skal gjøre noe fra utensiden som du ikke får gjort.
    Så er løsningen ofte å flytte det inn i en metode inni klassen:

Du er på riktig vei når du drar ting inni klasser og koden blir enklere

Dra så mye du kan som gir menning inn i klasser

## Generelt om objektorientert tenking
Terje snakker kort om objektorientert tenking

Objektorientert programmering - handler om at det er en rekke objekter som sender meldinger til hverandre

Innkapsling - Gjør at vi kan fokusere på hva som skal gjøres, og hjemme bort hvordan. Og også få stor frihet til å gjøre om på hvordan vi gjør det på insiden.

Object-oriented analysis and design (ooad) - Eget fag som handler om å modellere den ytre verden.

Domain-driven design - Ha en kjerne av objektorientert kode som blir strukert som virkeligheten, som gjør det lett å finne fram i koden.