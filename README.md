# ChillerCycleModule

This is a .NET console application to compute the Coefficient of Performance for a chiller cycle. Provided is a reusable CHillerCycleCalculator, an interactive console demo, and a few unit tests.

## Features 

1. CalculateCOP(): Returns COP = Q / W with input validation

2. Console demo: Prompts and computes the COP

3. xUnit tests for input validation and correct calcualtions 

## Running the program

1. Clone the repo

2. build by running

	1. dotnet restore

	2. dotnet build --configuration Release

	3. dotnet run --project demo/ChillerCycle.Demo

## Other Information

This is run in standard units, but can be converted to other HVAC units as needed. 

## Example run

Enter the heat absorbed (Q): 50000
Enter the work (W): 12500
Enter the evaporator temperature (C): 6.7
Enter the condenser temperature (C): 35.0
With QL=50000 and W=12500, COP = 4.00
The ideal COP is 9.89, this is below by 5.89

Efficiency vs ideal: 40%

