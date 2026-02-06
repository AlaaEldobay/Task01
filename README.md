Search Task :
________________________
(Standard numeric format)

int X = 10;
int Y = 20;
Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");


1. why the output of this Equation = $30.00?
- On a machine with U.S. culture settings, 30 becomes $30.00
- So the output is:Equation: 10 + 20 = $30.00

2. what is its benefit?
- Readability: Currency formatting makes values instantly recognizable as monetary amounts.
- Localization: The :C specifier adapts to the user’s culture (e.g., €30.00 in Europe, £30.00 in the UK).
- Consistency: Ensures uniform display of financial data without manually adding symbols or decimal places.

3. try another example with a different specifier with a screenshot of the output.
Let’s try the percentage (P) specifier:

double value = 0.256;
Console.WriteLine($"Percentage: {value:P}");

Output:
Percentage: 25.60 %
