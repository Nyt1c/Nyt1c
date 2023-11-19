// See https://aka.ms/new-console-template for more information



int[] tab = new int[10];
int potega;
int min, max;
int indeksMIN = 0, indeksMAX = 0;
float suma = 0;
float srednia=0;

Random rnd = new Random();

for (int i = 0;i < tab.Length; i++)
{

    tab[i] = rnd.Next(0, 15);

    Console.WriteLine("Tablica"+i+" wynosi:" + tab[i]);


}

for(int i = 0;i < tab.Length; i++)
{


    potega = tab[i] * tab[i];

    Console.WriteLine("Liczba " + tab[i] + "Podniesiona do potegi wynosi:" + potega);
}

min = tab[0];
max = tab[0];


for(int i =0;i < tab.Length; i++)
{
    if(min > tab[i])
    {
        min = tab[i];
        indeksMIN = i;
        
    }

    else if(max < tab[i])
    {
        max = tab[i];
        indeksMAX = i;
    }
    
}

Console.WriteLine("Najwieksza liczba w talblicy to:" + max + "Liczba ta jest pod indeksem  " +  indeksMAX);
Console.WriteLine("Najmniejsza liczba tablicy to:" + min + "lICZBA TA JEST POD INDEKSEM  " + indeksMIN);


for(int i = 0 ;i<tab.Length; i++ )
{

    suma = suma + tab[i];

}

Console.WriteLine("Suma wszystkich liczb z tablicy wynosi:" + suma);

for(int i =0 ;i<tab.Length; i++)
{

    srednia = suma/tab.Length;
}

Console.WriteLine("średnia wszystkich liczb z tablicy jest równa :" + srednia);



Console.WriteLine("liczny wyświetlone od tyłu");

for (int i = 9; i >= 0; i--)
{



    Console.WriteLine("Tablica" + i + " wynosi:" + tab[i]);


}









