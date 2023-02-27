
#region task1
bool ArrayCheck(int[] numbers, int number)
{
    bool result = false;
    
    foreach (var item in numbers)
    {
        if(item == number)
        {
            result = true;
            break;
        }
    }
    return result;
}

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
int number = 9;
if(ArrayCheck(numbers, number))
{
    Console.WriteLine("Arrayda " + number + " ededi var");
}
else
{
    Console.WriteLine("Arrayda " + number + " ededi yoxdur");
}
#endregion


#region task2 
/*

int ArrayMax(params int[] numbers)
{
    int max = numbers[0];

    foreach (int items in numbers)
    {
        if(items > max)
        {
            max = items;
        }
    }
    return max;
}

int max = ArrayMax(1, 4, 2, 6, 487, 124, 236, 23, 241, 64, 32, 63, 75);
Console.WriteLine("Maximum of Array : " + max);
*/
#endregion

