using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe1{
    public class Person{
        public string name;
        public int age; 
        public bool Haspe;


    
    }
    class Program{
        static void Main(string [] args){
            House house1 = new House(800, "Kelvin", "Ramirez", 90210, 200200);
            House house2 = new House(800, "Kelvin", "Ramirez", 90210, 200200);
            House house3 = new House(800, "Kelvin", "Ramirez", 90210, 200200);
            House house4 = new House(800, "Kelvin", "Ramirez", 90210, 200200);
            House house5 = new House(800, "Kelvin", "Ramirez", 90210, 200200);
            House house6 = new House(800, "Kelvin", "Ramirez", 90210, 200200);
            System.Console.WriteLine(house1.houseNumber);
            Domicile d1 = new Domicile(123, "Kevin", "Gomez", 68107, 200000);
            System.Console.WriteLine("The price: "  + d1.Price);
            System.Console.WriteLine("number of house instances: " + House.count);

            System.Console.WriteLine(house1.houseNumber);
            System.Console.WriteLine(house1.IsInNineThousand());
            /*
            Console.WriteLine("hello world!");            
            string t = Console.ReadLine();
            Console.WriteLine(t);
            int age = 23;
            Console.WriteLine("Hi what the fuck " + age + " Just kidding");
            decimal e = 12.23M;
            bool b = false;
            Console.WriteLine(b);
            String j = "Something";
            Console.WriteLine(j.ToUpper()); //Will change the string to upper case without changing the original string 
            Console.WriteLine(j.Contains("j")); //the contains method checks whether the string passed inside is found inside the other string
            */

            /* Strings
            string p = "Tomorrow";
            Console.WriteLine(p[1]);
            System.Console.WriteLine(p.IndexOf("om"));
            //substring
            System.Console.WriteLine(p.Substring(0, 2));
            System.Console.WriteLine(p.Substring(5));
            */

            /*
            float f = 1.2f;
            System.Console.WriteLine(1 + 2 + (2 * 3));
            System.Console.WriteLine(1 + 2 + 1.2M);
            System.Console.WriteLine(1 + 2 + 3 + 4 * 1.2);
            System.Console.WriteLine(10 % 5);
            System.Console.WriteLine(Math.Sqrt(144));
            System.Console.WriteLine(Math.Max(100, 1000));
            System.Console.WriteLine(Math.Min(10, 1000));
            System.Console.WriteLine(Math.Pow(12, 2));

            int three = (int)3.2;
            System.Console.WriteLine(three);

            double d = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine(d);

            int [] luckyNumbers = {1, 2, 3, 4, 5};
            //luckyNumbers[5] = 12; error
            System.Console.WriteLine(luckyNumbers.Length);

            int [] arr = new int[12];
            System.Console.WriteLine(arr[0]);

            fun1("person", 1);
            fun1("person");

            System.Console.WriteLine(returnInt(2));

            
            System.Console.WriteLine(switchCase(4));

            guessingGame();
            */
            

            int [,] x = {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            System.Console.WriteLine(x[0, 0]);


            int [,,] p = {
                {{1, 2}},
                {{3, 4}},
                {{5, 6}}
                };
                System.Console.WriteLine(p[0,0,0]);

            try{
                Console.Write("Enter a number");
                int d = Convert.ToInt32(Console.ReadLine());
                int e = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine(d / e);
            }catch(DivideByZeroException e){
                System.Console.WriteLine("This was a divide by zero exception" + e);
            }
            catch{
                System.Console.WriteLine("Generic error");
            }
            finally{
                System.Console.WriteLine("this is in finally ");
            }
            System.Console.WriteLine("this runs anyways");
        }

        public static void fun1(string t, int x){
            System.Console.WriteLine(t + " " + x);
        }
        public static void fun1(string t){
            System.Console.WriteLine(t);
        }

        public static int returnInt(int t){
            return t;
        }

        //use switch cases when using numbers and string comparisons as its faster than if/else
        public static string switchCase(int num){
            switch(num){
                case 1:
                    return "one";
                    break;
                case 2: 
                    return "two";
                    break;
                case 3:
                    return "three";
                    break;
                default: 
                    return "default";
                    break;
            }
            return "";
        }

        static void guessingGame(){
            string correctWord = "brick";
            string guess = "";
            int tries = 0;
            int tryLimit = 3;

            while(guess != correctWord){
                if(tryLimit == tries){
                    System.Console.WriteLine("You lost!!!");
                    return; 
                }
                Console.Write("Enter word: ");
                guess = Console.ReadLine();
                tries++;
            }
            System.Console.WriteLine("You win! It took you " + tries + " tries" );
        }

        
    }
}