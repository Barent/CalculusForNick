using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculusForNick.Limits
{
    public class Limits
    {
        private double numberForStart { get; set; }
        private int numberOfIncrements { get; set; }
        private double limitNumber { get; set; }   
        
        public void StartLimitsProgram()
        {
            Console.WriteLine("Welcome to Calculus for Nick. We are going to produce some limits in this section.");
            Console.WriteLine("Type 'YES' to continue");
            var proceedWithProgram = Console.ReadLine();
            if (proceedWithProgram == "YES")
            {
                ProcessUserInputs();
                LogXAndY();
                ExitProgramPrompt();
            }
            else
            {
                return;
            }
        }

        private void ProcessUserInputs()
        {          
            try
            {
                Console.WriteLine("Please select the number to start from: ");
                numberForStart = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please select the increment: ");
                numberOfIncrements = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please select the limit number: ");
                limitNumber = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        private double SinXOverX(double xInput)
        {
            return Math.Sin(xInput) / xInput;
        }
        
        private void LogXAndY()
        {
            for (var i = 0; i < numberOfIncrements; i++)
            {
                double singleX = numberForStart + (limitNumber - numberForStart) * i / numberOfIncrements;
                double fOfX = SinXOverX(numberForStart + (limitNumber - numberForStart) * i / numberOfIncrements);
                Console.WriteLine(singleX + ", " + fOfX);              
            }
        }

        private void ExitProgramPrompt()
        {
            Console.WriteLine("Would You like to Exit? (Y/N)");
            var exitSelect = Console.ReadLine();
            if(exitSelect == "Y")
            {
                return;
            }
            else
            {
                StartLimitsProgram();
            }
        }

    }
}
