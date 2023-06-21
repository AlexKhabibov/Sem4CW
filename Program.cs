//Задача 1.
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// ищем через цикл for
/*
void FindSum1ToA(int numberA)
{
    int sumOfElem = 0;
    for (int current = 1; current <= numberA; current++)
    {
        sumOfElem += current; // тоже самое что и - sumOfElem = SumOfElem + current
        Console.Write(sumOfElem + " ");
    }
    Console.WriteLine();
    Console.WriteLine($"Sum of elements from 1 to {numberA} is {sumOfElem}");
}

Console.WriteLine("Input your number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber > 0)
{
    FindSum1ToA(userNumber);
}
else
    Console.WriteLine("Impossible value");
*/

// ищем через цикл while
/*
void FindsumWhile(int numberA)
{
    int sum = 0;
    int count = 1;
    while (count <= numberA)
    {
        sum +=count;
        count++;
        Console.Write(sum + " ");
    }
    Console.WriteLine($"Sum of elements from 1 to {numberA} is {sum}");
}        
    Console.WriteLine("Input your number: ");
    int numberA = Convert.ToInt32(Console.ReadLine());

    if (numberA > 0)
    {
        FindsumWhile(numberA);
    }
    else
        Console.WriteLine("Imposible value");
        */

// Задача 2.
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

/*
int CountDigits(int userNumber)
{
    int count = 0;
    while (userNumber > 0)
    {
        userNumber /= 10;
        count++;
    }
    return count;
}
Console.WriteLine("Input your number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int countRes;
if (userNum >= 0)
    countRes = CountDigits(userNum);
else
{
    int userNum1 = (-1) * userNum;
    countRes = CountDigits(userNum1);
}

Console.WriteLine(countRes);
*/


/*
int CountDigits(int userNumber)
{
    int count = 0;
    while (userNumber > 0)
    {
        userNumber /= 10;
        count++;
    }
    return count;
}
Console.WriteLine("Input your number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int countRes;
if (userNum >= 0)
    countRes = CountDigits(userNum);
else
{
    int userNum1 = (-1) * userNum;
    countRes = CountDigits(userNum1);
}

Console.WriteLine(countRes);
*/

//Задача 3.
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

/*
int FindMulty (int userN)
{
    int mult = 1;
    for (int count = 1; userN >= count; count ++)
    {
            mult *= count;
    }
    return mult;
}

Console.WriteLine("Input your number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int multRes;
if (userNum <= 0)
    multRes = 0;
else
    multRes = FindMulty (userNum);
Console.WriteLine(multRes);
*/

//Задача 4. Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]

int CreateNewArray(int sizeArray)
{
    int[] randomArray = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {
        randomArray[i] = new Random().Next(0, 2);
    }
    return randomArray;
}

void PrintArray(int[] arrayToPrint)
{
    Console.WriteLine("Your array is: ");
    for (int i = 0; i < arrayToPrint.Length; i++)
        Console.Write(arrayToPrint[i] + " ");
}

int size = 8;
int[] firstArray = CreateNewArray(size);
PrintArray(firstArray);