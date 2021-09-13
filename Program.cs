using System;

namespace ComputationalThinkingExercises
{
    class Program
    {
        private static char ch;

        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("COMPUTATIONAL THINKING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Are These Integers Equal?");
                Console.WriteLine("2. Even or Odd?");
                Console.WriteLine("3. Vowel or Consonant?");
                Console.WriteLine("4. Find the Largest Number");
                Console.WriteLine("5. Divisible by 3");
                Console.WriteLine("6. Restaurant Bill");
                Console.WriteLine("7. Age Category");
                Console.WriteLine("8. Words to Digits");
                Console.WriteLine("9. Which Name is Longer?");
                Console.WriteLine("10. Are these Names the Same?");
                Console.WriteLine("11. Name and Place of Birth");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        AreTheseIntegersEqual();
                        break;
                    case "2":
                        EvenOrOdd();
                        break;
                    case "3":
                        VowelOrConsonant();
                        break;
                    case "4":
                        FindLargestNumber();
                        break;
                    case "5":
                        DivisibleBy3();
                        break;
                    case "6":
                        RestaurantBill();
                        break;
                    case "7":
                        AgeCategory();
                        break;
                    case "8":
                        WordsToDigits();
                        break;
                    case "9":
                        WhichNameIsLonger();
                        break;
                    case "10":
                        AreNamesSame();
                        break;
                    case "11":
                        NameAndBirthplace();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
                {

                }
            }

            static void AreTheseIntegersEqual()
            {
                // Ask the user for two integers. 
                // Check and see if the two integers are equal to each other.
                // If they are, inform the the user that the numbers are equal,
                // else inform the user that the numbers are not equal

                Console.Clear();
                Console.WriteLine("ARE THESE INTEGERS EQUAL?\n");


                Console.Write("Please enter a number");
                int int1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number");
                int int2 = Convert.ToInt32(Console.ReadLine());
                if (int1 == int2)
                    Console.WriteLine("The numbers are equal");
                else
                    Console.WriteLine("The numbers are not equal");
                {
                }

                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();

            }

            static void EvenOrOdd()
            {
                // Ask the user for a number.
                // Tell the user if that number is even or odd.

                Console.Clear();
                Console.WriteLine("EVEN OR ODD?\n");

                Console.WriteLine("Please enter a number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num % 2 == 0)
                {
                    Console.WriteLine("The number is even");
                }
                else
                {
                    Console.WriteLine("The number is odd");
                }
                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void VowelOrConsonant()
            {
                // Ask the user for a letter. Check whether a letter is a vowel or consonant.
                // Hint: You can do this problem using a switch or an if condition.

                Console.Clear();
                Console.WriteLine("VOWEL OR CONSONANT?\n");

                Console.WriteLine("Please enter a letter");

                ch = Convert.ToChar(Console.ReadLine());

                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {

                    Console.WriteLine(ch + " is Vowel.");

                }
                else
                {
                    Console.WriteLine(ch + " is Consonant.");
                }


                Console.ReadLine();

                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void FindLargestNumber()
            {
                // Prompt the user to input two integer values.
                // Find and print the greatest value of the two integers.

                Console.Clear();
                Console.WriteLine("Find Largest Number?\n");

                Console.Write("Please enter a number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter another number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num1 > num2)
                {
                    Console.Write("The first number is greater");
                }
                else
                {
                    Console.Write("The second number is greater");
                }
                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();

            }

            static void DivisibleBy3()
            {
                // Ask the user for a number and then tell them if it is divisible by 3

                Console.Clear();
                Console.WriteLine("DIVISIBLE BY 3\n");

                Console.WriteLine("Please enter a number");
                int int1 = Convert.ToInt32(Console.ReadLine());
                if (int1 % 3 == 0)
                    Console.WriteLine("Your number is Divisible by 3");
                else
                    Console.WriteLine("Your number is not Divisible by 3");




                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void RestaurantBill()
            {
                // At a restaurant, Mike and his three friends decided to divide the bill evenly.
                // If each person paid $13 then what was the total bill?
                // Use arithmetic operators and print the amount of the total bill to the console.

                // Returning to the above problem, replace hard-coded values of 4(number of diners)
                // and 13(cost per diner) with values provided by the user.

                // How nice!The restaurant is having Customer Appreciation Week.
                // If a table’s total bill is $50 or more, then they’ll receive a 10 % discount!
                // Otherwise, they’ll receive a 5 % discount.

                Console.Clear();
                Console.WriteLine("RESTAURANT BILL\n");
                int tpartybill = (13 * 4);
                Console.WriteLine("Total is $52");

                Console.WriteLine("What is the total bill for your party?");
                int tbill;
                tpartybill = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("How many diners are there in your party?");
                int nparty = Convert.ToInt32(Console.ReadLine());

                int eachpersonpays = tpartybill / nparty;
                Console.WriteLine("Each person pays $" + eachpersonpays);

                Console.WriteLine("Hooray, it's customer Appreciation Week!\n");
                int eachPeraonPays = tpartybill / nparty;
                int disc5 = (int)(tpartybill * .05);
                int disc10 = (int)(tpartybill * .10);
                int newTPartyBill;

                if (tpartybill > 50)
                {
                    newTPartyBill = tpartybill - disc10;

                    Console.Write("Your new bill is" + newTPartyBill);



                }


                else
                {
                    newTPartyBill = tpartybill - disc5;
                    Console.Write("Your new bill is" + newTPartyBill);
                }


                // Console.Writeline;










                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();



            }

            static void AgeCategory()
            {
                // You're responsible for providing a demographic report for your local school district based on age.
                // To do this, you're going to determine which 'category' each person fits into based on their age.
                // The person's age will determine which category they should be in:

                // If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
                // If they're 3 or 4 and should be in preschool print : 'Preschool Maniac'
                // If they're from 5 to 11 and should be in elementary school print : 'Elementary School'
                // From 12 to 14: 'Middle School'
                // From 15 to 18: 'High School'
                // From 19 to 22: 'College'
                // From 23 to 65: 'Working for the Man'
                // From 66 to 100: 'The Golden Years'
                // If the age of the person is less than 0 or more than 100 - it might be an alien
                // print: "This program is for humans".

                Console.Clear();
                Console.WriteLine("AGE CATEGORY\n");

                Console.WriteLine("Please enter your age");
                int age = Convert.ToInt32(Console.ReadLine());

                if ((age <= 2) && (age >= 0)) { Console.WriteLine("Still in Mama's Arms"); }
                if ((age <= 4) && (age >= 3)) { Console.WriteLine("Preschool Maniac"); }
                if ((age <= 11) && (age >= 5)) { Console.WriteLine("Elementary School"); }
                if ((age <= 14) && (age >= 12)) { Console.WriteLine("Middle School"); }
                if ((age <= 18) && (age >= 15)) { Console.WriteLine("High School"); }
                if ((age <= 22) && (age >= 19)) { Console.WriteLine("College"); }
                if ((age <= 65) && (age >= 23)) { Console.WriteLine("Workling for the Man"); }
                if ((age <= 100) && (age >= 66)) { Console.WriteLine("Golden Years"); }
                if ((age >= 100)) { Console.WriteLine("Alien attack! This program is for humans"); }





                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void WordsToDigits()
            {
                // Having a string representation of a number, you need to print the digit form of the number.
                // Ask the user to enter a string representation of a number from zero to ten.
                // Using switch case, print the digit (0-10) representation of the number.

                Console.Clear();
                Console.WriteLine("WORDS TO DIGITS\n");
                Console.WriteLine("Spell out any number zero through ten and I will give you the digit)");
                string word = Console.ReadLine().ToLower();

                switch (word)

                {

                    case "one":
                        Console.Write("1");
                        break;
                    case "two":
                        Console.Write("2");
                        break;
                    case "three":
                        Console.Write("3");
                        break;
                    case "four":
                        Console.Write("4");
                        break;
                    case "five":
                        Console.Write("5");
                        break;
                    case "six":
                        Console.Write("6");
                        break;
                    case "seven":
                        Console.Write("7");
                        break;
                    case "eight":
                        Console.Write("8");
                        break;
                    case "nine":
                        Console.Write("9");
                        break;
                    case "ten":
                        Console.Write("10");
                        break;

                    default:
                        break;
                }

                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
                {

                }
            }
            static void WhichNameIsLonger()
            {
                // Ask the user for their first and last name.

                // Print the user's full name.
                // If the first name is longer than the last name, print "First is longer."
                // If the first name and last name are the same length, print "Same-sies!"
                // Otherwise, print "Last must be longer!"




                Console.Clear();
                Console.WriteLine("WHICH NAME IS LONGER?\n");
                Console.WriteLine("Please enter your first and last name");
                Console.ReadLine();
                string name1, name2;
                Console.Write("Name One:");
                name1 = Console.ReadLine();
                Console.Write("Name Two:");
                name2 = Console.ReadLine();
                if (name1 == name2)

                    Console.WriteLine("Same-sies!");






                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void AreNamesSame()
            {
                // Ask the user for 2 names.

                // If the two names are the same, print "The names are the same."
                // If they're not the same, print "The names are different."

                Console.Clear();
                Console.WriteLine("ARE THESE NAMES THE SAME?\n");

                // Console.WriteLine("Please enter two names");
                string name1, name2;
                Console.Write("Name One:");
                name1 = Console.ReadLine();
                Console.Write("Name Two:");
                name2 = Console.ReadLine();
                if (name1 == name2)

                    Console.WriteLine("Same-sies!");
                Console.Write("Press enter to return to the Main Menu");
                Console.ReadLine();
            }

            static void NameAndBirthplace()
            {
                Console.Clear();
                Console.WriteLine("NAME AND PLACE OF BIRTH\n");
                // Ask the user for their first name and where they were born.
                // Print a sentence to the console that repeats this information.


                // Enter your solution here
                Console.WriteLine("Please tell me your first name");



                {
                    string FirstName;
                    FirstName = Console.ReadLine();


                    Console.WriteLine("Where were you born?");
                    string born;

                    born = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("Hello, " + FirstName + " you were born in" + born);



                    Console.WriteLine("Press enter to return to the Main Menu");
                    Console.ReadLine();
                }
            }
        }
    }
}



            
                
            
            
        

