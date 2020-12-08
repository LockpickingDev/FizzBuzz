using System;
using System.Text;

namespace FizzBuzzInterview
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            //Given the example, it made sense to use an array of Strings
            string[] userInputString = { "1", "2", "3", "4", "5", "A", "" };
            FizzBuzzText.InnerHtml = FizzBuzz(userInputString);
        }

        public string FizzBuzz(string[] inputString)
        {
            StringBuilder returnString = new StringBuilder();
            int currentValue;

            //for (int i = 1; i <= 100; i++)
            for (int i = 0; i <= inputString.Length - 1; i++)
            {
                try
                {
                    currentValue = Convert.ToInt32(inputString[i]);

                    //Divisible by 3 and 5
                    if (currentValue % 3 == 0 && currentValue % 5 == 0)
                    {
                        returnString.AppendFormat("FizzBuzz<br />");
                    }

                    //Divisible by 3
                    if (currentValue % 3 == 0)
                    {
                        returnString.AppendFormat("Fizz<br />");
                    }
                    else
                    {
                        returnString.AppendFormat("Divided {0} by 3<br />", currentValue);
                    }

                    //Divisible by 5
                    if (currentValue % 5 == 0)
                    {
                        returnString.AppendFormat("Buzz<br />");
                    }
                    else
                    {
                        returnString.AppendFormat("Divided {0} by 5<br />", currentValue);
                    }

                }
                catch (Exception)
                {
                    returnString.AppendFormat("Invalid Item<br />");
                }
            }

            return returnString.ToString();
        }
    }
}