using System;
public class Program
{   
    public int CalculateTotalHours(int c1, int b1)
    {
        int totalHours = 0;
        int currentSparklers = c1;
        int extinguishedSparklers = 0;
        int previousSparklers = -1; //чтобы программа не уходила в бесконечный цикл, пример с кейсом 10 и 2

        while (currentSparklers > 0 && currentSparklers != previousSparklers)
        {
            previousSparklers = currentSparklers;
            totalHours += 2 * currentSparklers;
            extinguishedSparklers += currentSparklers;

            int newSparklers = (extinguishedSparklers / b1) * 2;
            extinguishedSparklers %= b1;

            if (newSparklers == 0) break;
            currentSparklers = newSparklers;
        }

        return totalHours;
    }
    

    static void Main(string[] args)
    {
    }
}

