namespace ChillerCycle.Module
{
    public static class ChillerCycleCalculator
    {
        //Calculating the Performance using  COP = Q_L / W

        public static double CalculateCOP(double heatAbsorbed, double workInput)
        {
            //Data validation
            if (heatAbsorbed < 0)
            {
                Console.Error.WriteLine("Heat Absorbed must be positive.");
                throw new ArgumentException("Heat Aborbed must be positive", nameof(heatAbsorbed));
            }
            if (workInput <= 0)
            {
                Console.Error.WriteLine("Work must be positive.");
                throw new ArgumentException("Work input must be positive", nameof(workInput));
            }

            //Perform the calculation
            return heatAbsorbed / workInput;
        }

        public static double CalculateIdealCOP(double evap_temp, double cond_temp)
        {

            //Converting from Celsius to Kelvin
            double convert_evap = evap_temp + 273.15;

            double convert_comp = cond_temp + 273.15;

            //Ensure valid data is entered
            if (convert_comp <= convert_evap)
            {
                throw new ArgumentException("Condenser temperature must be higher for a valid COP.");
            }

            if (convert_evap <= 0)
            {
                Console.Error.WriteLine("Evaporator temperature must be positive.");
                throw new ArgumentException("Evaporator temperature must be positive", nameof(convert_evap));
            }

            if (convert_comp <= 0)
            {
                Console.Error.WriteLine("Condenser temperature must be positive.");
                throw new ArgumentException("Condenser temperature must be positive", nameof(convert_comp));
            }



            //Return the ideal performance
            return convert_evap / (convert_comp - convert_evap);
        }
    }
}
