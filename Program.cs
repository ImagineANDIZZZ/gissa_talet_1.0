Random randomerare = new Random();
int slump_tal = randomerare.Next(1,100);
  //Ta en gissning
int gissning = 1;
Console.WriteLine("gissa ett tal mellan 1 och 100");
int antalgissningar=0;

while (slump_tal != gissning)
{
    gissning = int.Parse(Console.ReadLine());
   //Högt eller lågt
   antalgissningar ++;
    if (slump_tal < gissning){
    Console.WriteLine("din gissning var usel du försökte inte äns pröva något mindre nästa gång!");
    }

  //Högt eller lågt
    else if (slump_tal > gissning){
    Console.WriteLine("din gissning var usel du försökte inte äns pröva något högre tal nästa gång!");
    }

  // talet är rätt
    else {
    Console.WriteLine("grattis du gissade rätt tal fuskade du? hur kan du vara så bra!");
    Console.WriteLine("grattis det tog dig"+ " "+ antalgissningar + " "+ "gissningar");
    }

}



















/*string strNr = console.ReadLine();
int nr = convert.Toint32(strNr);
int guess = 0;

do
{
    slump_tal = randomerare.Next(1,100);
    guess += 1;
    if (nr > slump_tal)
{
console.WriteLine("din gissning var usel du försökte inte äns pröva något mindre nästa gång!")
}
else if (nr < slump_tal)
{
console.WriteLine("din gissning var usel du försökte inte äns pröva något högre tal nästa gång!")
}
}while (nr != slump_tal);

console.WriteLine("grattis du gissade rätt tal fuskade du? hur kan du vara så bra!" + guess + "tries");*/
