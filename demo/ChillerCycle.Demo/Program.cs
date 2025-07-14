using System;
using ChillerCycle.Module;

class Program
{
    static void Main()
    {
        //Collecting the heat absorbed to run the calculation
        Console.Write("Enter the heat absorbed (Q): ");

        string heat_input = Console.ReadLine();

        double QL = double.Parse(heat_input);

        //Collecting the work done 
        Console.Write("Enter the work (W): ");

        string work_input = Console.ReadLine();

        double W = double.Parse(work_input);

        //Collecting Evaporator Temperature
        Console.Write("Enter the evaporator temperature (C): ");

        string evap_temp_input = Console.ReadLine();

        double E = double.Parse(evap_temp_input);


        // Collecting Condensor Temperature
        Console.Write("Enter the condenser temperature (C): ");

        string condenser_input = Console.ReadLine();

        double C = double.Parse(condenser_input);

        //Perform the calculation of the current efficiency
        double cop = ChillerCycleCalculator.CalculateCOP(QL, W);

        //Calculate the ideal efficiency
        double ideal_cop = ChillerCycleCalculator.CalculateIdealCOP(E, C);

        //Find the difference for data analysis
        double difference = ideal_cop - cop;

        //Calculate efficiency
        double efficiencyPct = cop / ideal_cop * 100;

        Console.WriteLine($"With QL={QL} and W={W}, COP = {cop:F2}");
        
        //Write the proper message to the console
        if (ideal_cop > cop)
        {
            Console.WriteLine($"The ideal COP is {ideal_cop:F2}, this is below by {difference:F2}\n");
        }

        if (ideal_cop < cop)
        {
            Console.WriteLine($"The ideal COP is {ideal_cop:F2}, this is above by {difference:F2}\n");
        }

        if (ideal_cop == cop)
        {
            Console.WriteLine($"The ideal COP is {ideal_cop:F2}, this is perfect.\n");
        }

        Console.WriteLine($"Efficiency vs ideal: {efficiencyPct:F0}%");

    }
}
