int sideLengthA;
int sideLengthB;
int sideLengthC;

int sumAB;
int sumBC;
int sumAC;



Console.WriteLine("Podaj długość pierwszego boku:");
var enteredsideLengthA = Console.ReadLine();
Int32.TryParse(enteredsideLengthA, out sideLengthA);

Console.WriteLine("Podaj długość drugiego boku:");
var enteredsideLengthB = Console.ReadLine();
Int32.TryParse(enteredsideLengthB, out sideLengthB);

Console.WriteLine("Podaj długość trzeciego boku:");
var enteredsideLengthC = Console.ReadLine();
Int32.TryParse(enteredsideLengthC, out sideLengthC);



sumAB = sideLengthA + sideLengthB;
sumBC = sideLengthB + sideLengthC;
sumAC = sideLengthC + sideLengthA;

if(sumAB > sideLengthC && sumBC > sideLengthA && sumAC > sideLengthB)
{
    Console.WriteLine($"Z odcinków {sideLengthA}, {sideLengthB}, {sideLengthC} da się zbudować trójkąt");
}
else
{
    Console.WriteLine($"Z odcinków {sideLengthA}, {sideLengthB}, {sideLengthC} nie da się zbudować trójkąta");
}