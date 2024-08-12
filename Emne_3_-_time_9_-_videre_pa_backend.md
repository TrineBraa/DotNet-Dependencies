# Planen for i dag
- skrive om api til persistens med fil
- intro til helt grunnleggende SQL og MS SQL Server
- skrive om api til persistens med database

# Del 1

## Repitisjon av forrige time

Kjernen i en API er å mape en url til noe kode

Brukergrensesnitt (user interface) er en mulighet for et menneske for å bruke enn applikasjon,
et api er en mulighet for et program for å bruke et annet program.

Går over en Rest-api som er basert på webservere, så i stedet for å få en webfil så får du JSON data.

trenger en mappe som heter "wwwroot" for å kunne lagre/lage statiske filer i API-en

Bruker Axios i JS, for å gjøre det lettere å fetche data fra API-en

### Http verb
Finnes en del av http verb når du snakker med en web server:
- Get - vanlig brukt når du skal få noe data fra API-en
- Post - vanlig brukt når API-en skal ta imot noe data
- Put
- Delete

### Launch setting
Du kan finne disse under properties i koden til API-en din

Her kan du sette en del ting, men mest viktige for nå er at her kan du sette hvem URl den starter på

### Bruke static files
app.UseStaticFiles() - Du må ha denne vis du skal bruke noen statiske filer i API-en din som f.eks html filer

### .Map
app.MapGet("/url", metode()) - Gjør at når noen kommer på url path-en satt av koden, så kjører den metoden. 

### Ngrok
Setter opp en server som har en http tunnel til din lokale server, sånn at folk på andre maskiner kan bruke programmet ditt.

Er tydeligvis noe lignene bygget inn i Visual Studio, så vis man har lyst å bruke det så slipper man å laste ned noe.

# Del 2

## Lagre til disk
JsonSerializer.Serialize() - gjør noe om ting om til JSON(string). (Som stringify i JS)

JsonSerializer.DeSerialize<Datatype>(variabel(Hva du skal de serialize)) - gjør om JSON/string til kode. (Som parse i JS)

File.WriteAllText("navn på filen", variabel(hva du skal lagre)) - Lagrer det du putter inn som en fil

File.ReadAllText("fill navn") - leser verdier på en fil

ctrl + k + ctrl + d - autoformaterer siden

### File properties
Build Action | Content - Betyr at denne filen er en del av app-en
Copy to Output Directory | Copy if newer - Betyr at vær gang vi kompilerer app-en, så vil den skrive over den gamle filen hvis noe har endret seg


### File reading/writing tip
Når du leser/skriver en fil uten å angi mappe så starter det med å sjekke i prosjekt mappen

### Hvorfor er ikke bruke file storage hele tiden
Meste parten av tiden så burde du ikke bruke fil lagring, det kan få problemer når det er mange samtide brukere. 
Så du kan få problemer når to brukere lagrer data samtidig.
Du er også helt overlatt til deg selv når det gjelder ytelse og å strukturere dataen. Det kan bli vanskelig å søke etter ting ettervært også.

Men hvis du skal ha en API som bare gir ut data, så kan fil lagring være ett greit alternativ.


# Del 3

## Database

Finnes flere typer databaser f.eks: Relasjons databaser, no-SQL databaser, dokument databaser, osv.

Skal bruke microsoft SQL server
- Er et programvare for en databasemotor

Gratis SQL programvare: 
- opensource SQL databaser eksempler: MySQL, postgresSQL, SQLite , osv.

Microsoft SQL Server Management Studio - er for å gjøre manuelle operasjoner mot databasen din
- Kan gjøre dette også direkte i VS studio

SQL data baser er lagret i en fil, men de er lagret på en smart måte så flere kan bruke den samtidig.

Tabeller er en av de viktigste tingene i en database
- prøv å kall kolonnene det samme i databasen, som det er kalt i programet ditt

Primary key - Det betyr at det du setter som primary key, er unik for den raden

Datatypen nvarchar(MAX) - er det samme som string 

## CRUD
Create - legge til nye data
Read - lese data
Update - endre data
Delete - slette data

### CRUD SQL syntax

#### Read
SELECT * FROM tabel - Da får du ut all dataen fra tabellen "tabel"

SELECT Number FROM tabel - Da får du ut alt fra kollonen "Number" fra tabellen "tabel"

WHERE Number > 1 - Du bruker WHERE når du har lyst å filtrere dataen du skal ta ut.
Så i dette tilfelle hadde du fått alle Number kolloner som er større enn 1.

#### Create
INSERT INTO tabel VALUES () - Då får du lagt til ny data til tabelen "tabel".

#### Update
UPDATE tabel - Du velger hvem tabel du har lyst til å endre på

SET ForeColor = 'gray' - Her setter du verdien til alle ForeColor kolonner til 'gray'

WHERE Text = 'test - Hvis du også bruker WHERE, så kan du velge på hvem felt du skal endre på
Så i dette tilfelle hadde du endret på alle rows som sin ForeColor = 'gray'.

#### Delete
DELETE FROM tabel - sletter alt fra "tabel"

WHERE Number = 5 - Hvis du også bruker WHERE, så kan du velge hvilke rows den skal slette
Så i dette tilfelle hadde du slettet alle rows som sin Number = 5.

## Skriver om API-en til at den bruker SQL

### Connection string
Connection string - er en tekstlig oppsummering av alle tilkoblings informasjonen

For å koble til databasen så trenger du en Connection string

Data Source - Hvor databasen er lagret

Inital Catalog - Er som Namespace men for SQL
- Burde skrive inn navnet til databasen din her

Integrated Security - Betyr at vi kobler til databasen med windows brukeren vår

### Nuget pakker
Gjør at du kan koble deg til andre bibloteker og kunne søke etter forskjellige pakker som gjør koding lettere
(Er som npm i node.js)

### System.Data.SqlClient
Inneholder ferdige klasser som gjør at du kan snakke med en SQL server

var sqlConnection = new SqlConnection(Connection string); 
- Lager en ny connection til en SQL database med Connection stringen

### Dapper
Har en Klasse som inne holder hjelpe metoder for å utføre forskjellige SQL ting

Akkurat som Axios så kan du gjøre dette uten ett bibliotek, men du hadde nok måtte lage en hjelpe metode uansett.
Og ved å laste ned Dapper så slipper du å lage disse hjelpe metodene selv.

var dbData = await conn.QueryAsync<(Klassen vi vil had det som)>("SQL kode"); 
- Gjør at vi kan få tak i dataen fra databasen vår

var rowsAffected = await conn.ExecuteAsync<(Klassen vi vil had det som)>("SQL kode", object); 
- Gjør at vi kan sende data til databasen vår, og returnerer hvor mange rader som ble endret på.

### SQL variabler
syntaks: @feltNavn - gjør at vi kan være mer generell, med hvordan vi spør om ting i SQL
