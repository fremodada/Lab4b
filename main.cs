using System;

// Start BMI class
class BMI {
//Declare function/method CalculateBMI
public static double CalculateBMI(double height, double weight) 
{
  return (weight * 703) / (height * height);
} // End CalculateBMI


//Declare function/method BMIResults
public static string BMIResults (double calculateBMI)
{
  //Determine BMI result
  if (calculateBMI < 18.5)
  {
    return "Underweight";
  }
  else if ((calculateBMI >= 18.5) && (calculateBMI <= 24.9))
  {
    return "Normal";
  }
  else if ((calculateBMI >= 25) && (calculateBMI <= 29.9))
  {
    return "Overweight";
  }
  else if (calculateBMI >= 30)
  {
    return "Obese";
  }
  else //Exception if the calculated BMI somehow ends up outside of the listed ranges
  {
    return "Unknown value entered";
  }
} // end BMIResults

}  // end BMI Class

class MainClass {
  public static void Main (string[] args) {

for (int i = 0; i < 9; i++ )
{
Console.WriteLine("Enter your height:");
double height = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your weight:");
double weight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(BMI.BMIResults(BMI.CalculateBMI(height, weight)));
  }
  }
}