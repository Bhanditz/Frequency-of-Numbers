using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//program that generates a random number in array size 1000 in the range of 0 - 49 and
//computes the frequency of the numbers generated
namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            int number = 0;
            int[] arr = new int[1000];//array of size 1000
            
                for (int i = 0; i < arr.Length; i++)
                {
                    Random random = new Random();//instantiate random number generator and assign variable
                    arr[i] = random.Next(0, 49);//assign random number within range 0 - 49 to index in array
                Console.Write(arr[i]+" ,");//output array
            }
            Console.WriteLine();
            do
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == number)//if number in index i equals value of variable number
                    {
                        counter += 1;//increment counter by one
                    }
                }
                Console.WriteLine("Frequency of " + number + " = " + counter);//output frequency
                number += 1;//increment number to be checked by one
                counter = 0;//bring the counter back to zero.
            } while (number < 50);//continue until number being checked is less than 50
        }
       
    }
}
