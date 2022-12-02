Console.WriteLine(MaxCalorie(CaloriesCarriedByElves("Input.txt")));

static int MaxCalorie(List<int> list)
{
    return list.Max();
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
