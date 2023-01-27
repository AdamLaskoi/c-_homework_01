//házi feladatok

//számológép

//Írj programot, ami kiírja a, és b egész (int) számok összegét, különbségét, szorzatát és hányadosát! A bemeneti változókat a konzolról olvasd be!
/*

Console.WriteLine("kérem az A egész számot");
string inText = Console.ReadLine();
int numberA = int.Parse(inText);
Console.WriteLine("kérem az B egész számot");
inText = Console.ReadLine();
int numberB = int.Parse(inText);
Console.WriteLine("A és B szám " + "Összege: " +(numberA + numberB) + " Külömbsége: " + (numberA - numberB) + " Szorzata: " + (numberA * numberB) + " Hányadosa: " + (numberA / numberB) + "");

 */
//---------------------------------------------------------------------------------------------------------------------

//Átlag

// Írj ami kiszámolja 5 egész szám pontos átlagát és az eredményt kiírja a program. Az 5 egész számot válaszd ki és írd bele a programba!

/*
int i = 1;
double resoult = 0;
while (i <= 5)
{
    Console.WriteLine("kérlek add meg az " + i + "." + "számot");
    string inText = Console.ReadLine();
    int num = int.Parse(inText);
    resoult = resoult + num;
    i++;
}
resoult = resoult / 5;
Console.WriteLine("Az 5 szám pontos átlaga: " + resoult);
*/

//---------------------------------------------------------------------------------------------------------------------
// Írj programot, ami kicseréli két string típusú változó értékét!

/*
string upButton = "w";
string downButton = "s";
Console.WriteLine(" AZ upButon változó tartalma: " + upButton);
Console.WriteLine(" A downButon változó tartalma: " + downButton);
string save;
save = upButton;
upButton = downButton;
downButton = save;
Console.WriteLine(" Csere után upButon: " + upButton );
Console.WriteLine("Csere után downButon: " + downButton);
*/


//----------------------------------------------------------------------------------------------------------------------
//Írj programot, ami elkéri egy kör sugarát és az alapján kiszámolja a kör kerületét és területét.
/*
Console.WriteLine("Kérem a kör sugarát [cm] Ha nem egész szám használj: [ , ] karaktert pl.: [10,5]");
string inText = Console.ReadLine();
double circleR = double.Parse(inText);
double pi = Math.PI;
double resoult = pi * (2 * circleR);
Console.WriteLine("A kör kerülete: " + resoult + " cm");
resoult = pi * (circleR * circleR); ;
Console.WriteLine("A kör Területe: " + resoult + " [Négyzet]cm");
*/
//------------------------------------------------------------------------------------------------
//Írj programot ami 2 számot kér a bemenetről, majd kiírja a kisebbiket és a nagyobbikat.
/*
Console.WriteLine("Kérlek add meg az első számot.");
String inText = Console.ReadLine();
int num1 = int.Parse(inText);
Console.WriteLine("Kérlek add meg a másdik számot.");
inText = Console.ReadLine();
int num2 = int.Parse(inText);
    int resoult = Math.Min(num1, num2);
Console.WriteLine("Ez a kissebbik: " + resoult);
resoult = Math.Max(num1,num2);
Console.WriteLine( "Ez a nagyobb: " + resoult);
*/

// Gondolkodj úgy mint a számítógép és fejben számold ki, hogy mi lesz az x kezdetű változók értéke, és típusa miután végrehajtjuk a következő kódot!

// Emlékeztető: A var kulcsszó behelyettesíthető bármilyen típus helyett lokális változó deklarálásánál, ha egyből definiáljuk is a változót. Ekkor a típus kiderül az értékadásból.
/*
int a = 2, b = 4, c = 5;
string d = "D", e = "E", f = "F";

var x1 = a + b + c;  // 2 + 4 + 5 = 11 (integer)
var x2 = a + b + e;  // 2 + 4 + "E" = "14E" ( string)
var x3 = b + d + c;  // 4 + "D" + "5" = "4D5" (string)
var x4 = f + a + b;  // "F" +  2 + 4 = "F24" (Sstring)

var x5 = a + b * c; // 2 + 4 + 5 = 11 (integer)
x5 /= 8;            // 11 / 8 = 1,375 (Double)
var x6 = x5 / b;   //1,375 /4
x6++;
var x7 = x6 / 2f;
x7--;
var x8 = -1 * x7;
x8 *= x8;
*/
// kifogott rajtam, utána nézni.. :/

//Hatványozás
//A programot kiírja a `baseNumber` számot az `exponent`-edik hatványon.
//A megoldás elég, ha csak nem negatív egész kitevő (exponent) esetén működik.
//Ne használj egyéb metódust a megoldáshoz!
Console.WriteLine(" Kérem azt az egész számot amit hatványozn iszeretnél");
string intext = Console.ReadLine();

int baseNumber = int.Parse(intext);
Console.WriteLine(" Kérem add meg hanyadik hatványra szeretnéd emelni a számot?");
intext = Console.ReadLine();
int exponent = int.Parse(intext);
int i = 0;
int resoult = 0;
while (i >= exponent)
{
     resoult = baseNumber * baseNumber;
    i++;
}
Console.WriteLine(resoult);