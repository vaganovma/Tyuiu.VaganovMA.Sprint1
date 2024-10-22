namespace Tyuiu.VaganovMA.Sprint1.Task6.V15.Lib;
using tyuiu.cources.programming.interfaces.Sprint1;

public class DataService : ISprint1Task6V15
{
    public bool CheckLettersCount(string value)
    {
        int C = 0;
        int nC = 0;
       foreach (char c in value)
        {
            if (char.IsLetter(c)) 
            {
                C++; 
            }
            else
            {
                nC++;
            }
        }

          return C>nC;

    }
}

