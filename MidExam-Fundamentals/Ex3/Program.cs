using System;

List<int> items = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
int index = int.Parse(Console.ReadLine());
string fight = Console.ReadLine();

int leftSum = 0;
int rightSum = 0;
int current = items[index];



if (fight == "cheap")
{

    for (int i = 0; i < index; i++)
    {
        if (items[i] < current)
        {
            leftSum += items[i];
        }
    }
    for (int j = index + 1; j < items.Count; j++)
    {
        if (items[j] < current)
        {
            rightSum += items[j];
        }

    }

}
else if (fight == "expensive")
{
    for (int i = 0; i < index; i++)
    {
        if (items[i] >= current)
        {
            leftSum += items[i];
        }

    }
    for (int j = index + 1; j < items.Count; j++)
    {
        if (items[j] >= current)
        {
            rightSum += items[j];
        }

    }

    
    if (leftSum >= rightSum)
    {
        Console.WriteLine($"Left - {leftSum}");
    }else
    {
        Console.WriteLine($"Right - {rightSum}");
    }
}
