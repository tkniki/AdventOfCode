// part 1
Console.WriteLine(MaxCalorie(CaloriesCarriedByElves("Input.txt")));

// part 2
Console.WriteLine(SumOfMaxThree(CaloriesCarriedByElves("Input.txt")));

static int MaxCalorie(List<int> list)
{
    return list.Max();
}

static int SumOfMaxThree(List<int> list)
{
    int sum = 0;
    for (int i = 0; i < 3; i++)
    {
        sum += list.Max();
        list.Remove(list.Max());
    }
    return sum;
}

static List<int> CaloriesCarriedByElves(string inputfile)
{
    List<int> calorieList = new List<int>();
    using (StreamReader streamReader = new StreamReader(inputfile))
    {
        string line;
        int caloriesCarriedByElf = 0;
        while ((line = streamReader.ReadLine()) != null)
        {
            if (String.IsNullOrEmpty(line))
            {
                calorieList.Add(caloriesCarriedByElf); // the amount of calories one elf carries
                caloriesCarriedByElf = 0;
            }
            else
            {
                caloriesCarriedByElf += Convert.ToInt32(line);
            }
        }
    }
    return calorieList;
}
