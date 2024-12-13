// proovime kuvada i väärtust, muudame vastavalt vajaduseele

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"i = {i+1}");   //ei muuda i väärtust, vaid kuvab seda tehet sulgudes vaid
}

//tagurpidi tahaks lugeda numbreid, tsükkel senikaua kuni i on suurem kui 0

for (int i = 10; i > 0; i --)
{
    Console.WriteLine($"i = {i}");
}

// proovime kokku liita i väärtuseid

int sum = 0;
for (int i = 1; i < 11; i ++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum += i;
    //sum = sum + i;
    // sum+ =i;
}
//Console.WriteLine($"Final total {sum}");


