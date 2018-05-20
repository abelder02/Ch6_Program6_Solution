using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTasksDLL;

namespace Ch6_Program6
{
    class Ch6_Program6 : CT
    {
        //PUT IN COMMENTS
        static void Main(string[] args)
        {
            Restart:
            Header(out CT.LengthOfTopLine, "Ch.6 Program 6",
                "to re make the phone number in a shorter way");

            string[] DisplayNum = new string[10];
            int counter = 0;

            Color("magetna");
            Console.WriteLine("Please type in the alphanumeric phonenumber, \n"
                +"remember to press enter after each digit:\n");

            Color("");
            Console.Write(" _ _ _  _ _ _   _ _ _ _");
            Console.CursorLeft = 0;

            List<string> OriginalNumbers = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                string x = "";
                switch (i + 1)
                {
                    case 1:
                        x = "(";
                        break;
                    case 2:
                    case 3:
                        x = " ";
                        break;
                    case 4:
                        x = ") ";
                        break;
                    case 5:
                    case 6:
                        x = " ";
                        break;
                    case 7:
                        x = " - ";
                        break;
                    case 8:
                    case 9:
                    case 10:
                        x = " ";
                        break;
                }
                counter = counter + x.Length;
                OriginalNumbers.Add(AskUserForString2(x, ref counter));
            }
            
            Color("");
            DisplayNum = OriginalNumbers.ToArray();
            Console.WriteLine("\n\nThe original phone number:");
            CT.Color("magenta");
            Console.WriteLine("({0} {1} {2}) {3} {4} {5} - {6} {7} {8} {9}",
            DisplayNum[0], DisplayNum[1], DisplayNum[2], DisplayNum[3], DisplayNum[4],
            DisplayNum[5], DisplayNum[6], DisplayNum[7], DisplayNum[8], DisplayNum[9]);
            CT.Color("");
            List<string> NewNumbers = new List<string>();
            foreach (string num in OriginalNumbers)
            {
                NewNumbers.Add(ConvertToPhoneNumberEquivalent(num));
            }
            DisplayNum = NewNumbers.ToArray();
            Console.WriteLine("\n\nThe useable phone number:");
            CT.Color("magenta");
            Console.WriteLine("({0} {1} {2}) {3} {4} {5} - {6} {7} {8} {9}",
            DisplayNum[0], DisplayNum[1], DisplayNum[2], DisplayNum[3], DisplayNum[4],
            DisplayNum[5], DisplayNum[6], DisplayNum[7], DisplayNum[8], DisplayNum[9]);

            Color("white");
            Console.Write("\nDo you wish to enter another phone number: (Y/N) ");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                Console.Clear();
                goto Restart;
            }
            CT.Footer();
        }

        public static string AskUserForString(string x, int y)
        {
            Console.Write("\nPlease enter {0} ", x);
            CT.Color("Green");
            string input = Console.ReadLine();
            CT.Color("");
            input = CheckNum(input, ref y);
            return input;
        }

        public static string AskUserForString2(string x, ref int y)
        {
            Color("magenta");
            Console.Write("{0}", x);
            CT.Color("Green");
            string input = Console.ReadLine();
            Console.CursorTop--;
            CT.Color("");
            y += input.Length;
            input = CheckNum(input, ref y);
            Console.CursorLeft = y;
            return input;
        }

        public static string CheckNum(string x, ref int y)
        {
            //This used to check if the input is anything other 
            //than the desired charachters and numbers

            //THIS CHECK IS EXECUTED IN THE GETTING INPUT METHOD
            switch (x.ToLower())
            {
                case "1":
                case "a":
                case "b":
                case "c":
                case "2":
                case "d":
                case "e":
                case "f":
                case "3":
                case "g":
                case "h":
                case "i":
                case "4":
                case "j":
                case "k":
                case "l":
                case "5":
                case "m":
                case "n":
                case "o":
                case "6":
                case "p":
                case "q":
                case "r":
                case "s":
                case "7":
                case "t":
                case "u":
                case "v":
                case "8":
                case "w":
                case "x":
                case "y":
                case "z":
                case "9":
                case "0":
                    break;
                default:
                    int minusLength = x.Length;
                    x = AskUserForString("only one digit at a time for the digit above", y);
                    Console.CursorTop--;
                    Console.Write("                                                             ");
                    Console.CursorTop--;
                    Console.CursorLeft = y-minusLength;
                    Color("green");
                    Console.Write(x);
                    for (int i = 0; i < minusLength; i++)
                    {
                        Console.Write(" ");
                    }
                    y = y - minusLength + 1;
                    break;

            }
            return x;
        }

        public static string ConvertToPhoneNumberEquivalent(string x)
        {
            switch (x.ToLower())
            {
                case "1":
                    x = "1";
                    break;
                case "a":
                case "b":
                case "c":
                case "2":
                    x = "2";
                    break;
                case "d":
                case "e":
                case "f":
                case "3":
                    x = "3";
                    break;
                case "g":
                case "h":
                case "i":
                case "4":
                    x = "4";
                    break;
                case "j":
                case "k":
                case "l":
                case "5":
                    x = "5";
                    break;
                case "m":
                case "n":
                case "o":
                case "6":
                    x = "6";
                    break;
                case "p":
                case "q":
                case "r":
                case "s":
                case "7":
                    x = "7";
                    break;
                case "t":
                case "u":
                case "v":
                case "8":
                    x = "8";
                    break;
                case "w":
                case "x":
                case "y":
                case "z":
                case "9":
                    x = "9";
                    break;
                case "0":
                    x = "0";
                    break;

            }

            return x;
        }

    }
}
