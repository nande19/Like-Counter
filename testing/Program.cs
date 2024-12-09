using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    public class Program
    {
//--------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// promting the user tp enter names which are seperated by commas
        /// ensures that the program stops when the user types exit
        /// formats output according to the names which are provided by the user 
        /// </summary>
        public static void Main(string[]args)
        {
            string input;
            do
            {
                //prompts user to enter name or names or type exit to stop
                Console.WriteLine("Enter names separated by commas (or type 'exit' to quit):");
                input = Console.ReadLine().Trim();

                //program continues processing the input if exit is not typed
                if (input.ToLower() != "exit")
                {
                    //removes extra spaces and empty entries and it also divides the input into a list of names
                    List<string> names = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                              .Select(name => name.Trim())
                                              .Where(name => !string.IsNullOrEmpty(name))
                                              .ToList();

                    //likes method is called to display the formatted message with the names
                    Console.WriteLine(Likes(names));
                }

            } while (input.ToLower() != "exit");

            //telling the user that the program is exiting
            Console.WriteLine("BYE.");
        }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// provides formating according to who likes the post based on the number of names provided as input
        /// </summary>
        public static string Likes(List<string> names)
        {
            int count = names.Count;

            if (count == 0)
            {
                return "no one likes this";
            }
            else if (count == 1)
            {
                return $"{names[0]} likes this";
            }
            else if (count == 2)
            {
                return $"{names[0]} and {names[1]} like this";
            }
            else if (count == 3)
            {
                return $"{names[0]}, {names[1]} and {names[2]} like this";
            }
            else
            {
                return $"{names[0]}, {names[1]} and {count - 2} others like this";
            }
        }
    }
}        
        //---------------------------------------- END OF FILE -------------------------------------------------------//
