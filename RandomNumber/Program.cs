Random rnd= new Random();

// sedasi kutsume välja süsteemist. 
//kasutatakse krüpteerimisel nt

int myRandomNum;

int randomSum = 0;

for(int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11); //sedasi genereeritakse 0-10 numbreid 
    randomSum = randomSum + myRandomNum;

    Console.WriteLine($"My random number is: {myRandomNum} ");
}

Console.WriteLine($"random sum total: {randomSum}");