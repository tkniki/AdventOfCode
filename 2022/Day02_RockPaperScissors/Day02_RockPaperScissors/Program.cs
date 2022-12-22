// part 1
List<string> strategyGuide = ReadInput("Input.txt");
Console.WriteLine(CalculateTotalScore(strategyGuide));


static int CalculateTotalScore(List<string> list)
{
    int totalScore = 0;
    for (int i = 0; i < list.Count; i++)
    {
        char[] chars = SplitLine(list[i]);
        totalScore += CalculateSingleRound(chars[0], chars[1]);
    }
    return totalScore;
}

static int CalculateWhenOpponentA(char yours)
{
    int result = 0;

    switch (yours)
    {
        case 'X':
            result = 3 + 1; break;
        case 'Y':
            result = 6 + 2; break;
        case 'Z':
            result = 0 + 3; break;
        default:
            throw new ArgumentException();
            break;
    }

    return result;
}

static int CalculateWhenOpponentB(char yours)
{
    int result = 0;

    switch (yours)
    {
        case 'X':
            result = 0 + 1; break;
        case 'Y':
            result = 3 + 2; break;
        case 'Z':
            result = 6 + 3; break;
        default:
            throw new ArgumentException();
            break;
    }

    return result;
}

static int CalculateWhenOpponentC(char yours)
{
    int result = 0;

    switch (yours)
    {
        case 'X':
            result = 6 + 1; break;
        case 'Y':
            result = 0 + 2; break;
        case 'Z':
            result = 3 + 3; break;
        default:
            throw new ArgumentException();
            break;
    }

    return result;
}

static int CalculateSingleRound(char opponent, char yours)
{
    int score = 0;
    switch (opponent)
    {
        case 'A': score = CalculateWhenOpponentA(yours); break;
        case 'B': score = CalculateWhenOpponentB(yours); break;
        case 'C': score = CalculateWhenOpponentC(yours); break;

        default: throw new ArgumentException();
            break;
    }

    return score;
}

static char[] SplitLine(string line)
{
    string[] result = line.Split(' ');
    return new char [] { Convert.ToChar(result[0]), Convert.ToChar(result[1]) };
}

static List<string> ReadInput(string file)
{
    List<string> input = new List<string>();
    using (StreamReader streamReader = new StreamReader(file))
    {
        string line;
        while ((line = streamReader.ReadLine()) != null)
        {
            input.Add(line);
        }
    }
    return input;
}