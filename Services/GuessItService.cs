using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KumarTMC_EightToTen_Endpoints.Services
{
    public class GuessItService
    {
        public string GuessIt(string difficulty, int guessnum)
        {
            switch (difficulty)
            {
                case "hard":
                    
                    Random random = new Random();
                    int randomnum = random.Next(1, 101);
                     
                    if (randomnum > guessnum)
                    {
                        return " your guess is lower than my number";
                    }
                    else if (randomnum < guessnum)
                    {
                        return " your guess is greater than my number";
                    }
                    else
                    {
                        return " your guess is equal to my number";
                    }
                    

                case "medium":
                   
                    Random mrandom = new Random();
                    int mrandomnum = mrandom.Next(1, 51);
                    
                    if (mrandomnum > guessnum)
                    {
                        return " your guess is lower than my number";
                    }
                    else if (mrandomnum < guessnum)
                    {
                        return " your guess is greater than my number";
                    }
                    else
                    {
                        return " your guess is equal to my number";
                    }

                    

                case "easy":
                    
                    Random erandom = new Random();
                    int erandomnum = erandom.Next(1, 11);
               
                    if (erandomnum > guessnum)
                    {
                        return " your guess is lower than my number";
                    }
                    else if (erandomnum < guessnum)
                    {
                        return " your guess is greater than my number";
                    }
                    else
                    {
                        return " your guess is equal to my number";
                    }

                    

                default:
                    return "input invalid";

            }

        }
    }
}