# Plannen for Hannoi Towers
1. Objektorientert analyse og design

Hvilke klasser?
2. Hvordan vise?
3. Flytte disk - GUI og logikk
4. Vunnet?

Single Responsibility Principle
5. Intro WPF
6. Flytte spillet til WPF, inkludert flere klasser og Class library
7. Refactoringsoppgave Canvas i WPF, bilspill

# Del 1

## Forklarer Hannoi Towers
    Tre tårn og tre disker.
    Målet er å flytte diskene fra det tårn 1 til tårn 3, sånn at de ligger i samme rekefølge som i tårn 1.
    Men du kan ikke legge en mindre disk på en større disk.


## Objektorientert analyse og design
    Litt om hvordan plannleggingen blir delt opp
        a. Hvilke klasser?
        b. Hvilken funksjonalitet
        c. Hvordan samarbeider klassene om en viss funksjonalitet

    Objektorientert analyse og design handler om å tenke seg om i bredden før man starter på ett prosjekt, men også underveis.

### Klasse Diagram
    UML: planttext.com
        Hjelper deg med å lage klasse diagramer og tegner eksempler til koden din.

    Diagramet fokuserer på hva som er de mulige relasjonene mellom klassene
        Er så konkrett som mulig, men det kommer forsatt til å være litt generelt

### a. Hvilke klasser?
    Deler opp Hannoi Towers spille inn i klassene vi tror den kommer til å trenge

### b. Hvilken funksjonalitet
    Usecaser, med andre ord beskrive funksjonaliteten
        Kan bruke usecase diagrammer til å hjelpe med dette

    Så funksjonaliteten i Hannoi Towers, blir at du kan starte ett nytt spill og flytte på en disk. 

### Sequence Diagram
    websequencediagrams.com
        Hjelper deg med å lage sequence diagramer og tegner eksempler til koden din.

    Sequence Diagramer handler om å modellere hvordan objekter snakker med hverandre


### Oversette diagrammene til kode
    Lager "skeleton"-et til Hanoi Towers ved å oversette diagrammene han har laget til konkret kode


# Del 2
    Fokusere på å få programmert første versjon av spillet.

## Starter på Hanoi Towers
    Ha klasser som holder på hjelpe metoder   

    Trekk ut så mye du kan inni metoder

## Arrays i classes
    basic class array eksemple: 
        private Tower[] _towers;
        _towers = new Tower[3];
        _towers[0] = new Tower();
        _towers[1] = new Tower();
        _towers[2] = new Tower();

    Kan også bli skrivet som dette:
        private Tower[] _towers;
        _towers = new Tower[]
        {
            new Tower(), new Tower(), new Tower(),
        }

## Resharper tip
     ctrl + r + ctrl + f - kan ta ett parameter/argument og gjøre det om til ett felt for deg.

## Params
    Hvis du skal f.eks. ta inn en array som parameter, så må du sende med en array.
    Men hvis du legger til params før parametere i metoden.
    Så kan du bare sende med innholdet i arrayen når du kaller på den og det blir automatisk gjort om til en array.

        Eksempel uten params:
        public Constructor(int[] array){}

        Constructor(new int []{1, 2, 3})

        med params:
        public Constructor(params int[] array){}

        Constructor(1, 2, 3)

        Dette betyr også at hvis du kaller på Constructor() med ingen ting i parametrene, at den bare sender en tom array

## Readonly
    Readonly betyr at den ikke kan byttes ut med noe / du kan ikke sette en ny verdig på den
        Er veldig likt som const i JS

    Du kan sette verdien til en readonly i en Constructor, men du kan bare ikke endre den senere igjen


# Del 3
    Bruke denne delen til å prøve til å få alt til å funke

    Hvis du skal tegne noe opp i consolen, så kan det hjelpe å tegne det opp i en tekst fil først

## Tegne opp ting i consolen
    Console.SetCursorPosition() - for å velge i hvem posisjon du skal putte cursoren
        Den tar in to parametre, den første er for hvem kolonne cursoren skal være i og den andre er for hvem rad  cursoren skal være i.
            f.eks: Console.SetCursorPosition(1, 2) - betyr at du putter cursoren på plassen kolonne 1, rad 2.

    
    .PadLeft() / .PadRight() - Legger til karakterer til en string, helt til den er lengden vi har lyst til at den skal være.
        Den tar inn 2 ting som parametre, den første er hvor lang vi har lyst til at stringen skal være.
        Og det andre parametre er hvem Char vi skal fylle stringen med.
            f.eks: "".Padleft(10, 'C') - I dette eksemplet legger den til C-er til stringen, helt den har lengden 10.

## Debugging
    Starter programmet med debugging i VS, og det kommer opp en feil.
        Så drar den deg bare direkte til linjen hvor feilen er.

## Forhindre null
    Enten kan du bare sjekke med en if setning om tingen ikke er null så kjøre det f.eks:
        if(thing != null){ Method(); }
    
    Du kan også skrive:
        thing?.Method();
    Hva ? tegnet betyr her er at du kaller bare på Method() om "thing" er ulik null

## Tegne opp ting i consolen pt.2
    Console.CursorLeft - for å sette kolonne posisjonen til cursoren
        f.eks: Console.CursorLeft = 10 - da setter den cursor posisjonen til kolonne 10.
    
    Console.CursorTop - for å sette rad posisjonen til cursoren
        f.eks: Console.CursorTop = 2 - da setter den cursor posisjonen til rad 2.
    
    .Reverse() - Snur rundt på en array 
        så hvis array-en er [1,2,3] så blir den [3,2,1]