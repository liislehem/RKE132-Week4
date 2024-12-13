//paneb tsükli käima nii kauaks kuni tingimus täidetub saab

//nt arvuti genereerib 1-10 ja meie peame arvu ära arvama, kui teeme seda siis arvuti õnnitleb. 

using System.ComponentModel.Design;

Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool võib olla true või false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4);
    Console.WriteLine($"cpu has generated {cpuRandom}");
    Console.WriteLine("Make a guess. Enter a number 1-3");

    int userNumber = Int32.Parse(Console.ReadLine());  

    if(userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        loopActive = false; //selle asemel võib kasutada ka break
    }
    else
    {
        Console.WriteLine("Oops. Try again");
    }
}
Console.WriteLine("Have a nice day");