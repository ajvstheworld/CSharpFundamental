using System;
namespace classwork
{
    public class QuizClass1
    {
        /* Write a method to accept a 
        grade and return a description of the grade. If a grade entered is not correct, 
        display a message that it is not a valid grade. */

        public string GetGradeMessage(char grade)
        {
            if(grade == 'E')
            {
                return "Excellent";
            } 
            else if(grade == 'V')
            {
                return "Very Good";
            }
            else if(grade == 'G')
            {
                return "Good";
            }
            else if()
        }       
    }
}