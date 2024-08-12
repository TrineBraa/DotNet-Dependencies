
//Du skal lage en stall, den skal ha noen hester. Hestene kan løpe i forskjellige hastigheter, feks 20km/h, 30km/h og 35km/h.
//    Du skal kunne mate hesten, stelle med hesten og hesten skal kunne meldes på hesteløp. 
//    Under et hesteløp kan man ha en løkke (for enkelhetsskyld kan hver runde i løkken tilsvare 1 time) som går frem til en av hestene har vunnet. 
//    En hest skal løpe 3000km. Print ut hvor langt hestene har løpt per runde i løkken.


//Klasse som e stall
//    Hestan objekt: Kunne mate, stelle og melle på til løp
    
//    Hesteløp (Løkke)
//    løpe 3000 km

using CodeAlong;

Stall stallen = new Stall();
Main();
void Main()
{
    Console.WriteLine("Velkommen til din stall!");
    Console.WriteLine("Her kan du besøke hestene dine i stallen eller gå til et hesteløp");
    Console.WriteLine("Hva vil du gjøre?");
    Console.WriteLine("1. Gå til stallen");
    Console.WriteLine("2. Gå å se på hesteløp");

    var Option = Console.ReadLine();
    switch (Option)
    {
        case "1":
            Console.WriteLine("Du tar deg en tur i stallen");
            Console.ReadKey();
            stallen.Stallen();
            break;
        case "2":
            Console.WriteLine("Du drar på løps banen og jobbe");
            Console.ReadKey();
            break;
    }

}











