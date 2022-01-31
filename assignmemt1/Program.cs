using System;

namespace DIS_Assignmnet1_SPRING_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();

            //Question 3:
            int[] bull_bucks = new int[] { 1, 2, 3, 2 };
            int unique_sum = SumOfUnique(bull_bucks);
            Console.WriteLine("Q3:");
            Console.WriteLine("Sum of Unique Elements in the array are :{0}", unique_sum);
            Console.WriteLine();


            //Question 4:
            int[,] bulls_grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Q4:");
            int diagSum = DiagonalSum(bulls_grid);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);
            Console.WriteLine();

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();

            }

            private static string RemoveVowels(string s)
            {
                try
                {
                    // Code for Removing Vowels 
                    String final_string = "";
                    for (int i = 0; i < s.Length; i++) 
                    {   //will enter the block if the alphabet is "a e i o u"
                        if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                        {
                            final_string = final_string + "";
                        }
                    //will enter the block if the alphabet is "A E I O U"
                    else if (s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
                        {
                            final_string = final_string + "";
                        }
                        else
                            final_string = final_string + s[i];
                    }


                    return final_string;
                }
                catch (Exception)
                {
                    throw;
                }

        } //End of RemoveVowels

        private static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
            {
                try
                {
                    // Code for comparing strings 
                    string s1 = "";   //String 1
                    string s2 = "";   //String 2
                for (int i = 0; i < bulls_string1.Length; i++)
                    {
                        s1 = s1 + bulls_string1[i];
                    }
                    for (int i = 0; i < bulls_string2.Length; i++)
                    {
                        s2 = s2 + bulls_string2[i];
                    }
                    if (s1 == s2)
                        return true;
                    else
                        return false;
                }
                catch (Exception)
                {

                    throw;
                }

        } //End of ArrayStringsAreEqual

        private static int SumOfUnique(int[] bull_bucks)
        {
            try
            {
                // Code for sum of all the unique elements of nums
                int a = 0;
                for (int j = 0; j < bull_bucks.Length - 1; j++)
                {
                    for (int k = j + 1; k < bull_bucks.Length; k++)
                    {
                        if (bull_bucks[j] > bull_bucks[k])    //It enters the loop if j value is greater than j+1(k) 
                        {
                            int x = bull_bucks[j];
                            bull_bucks[j] = bull_bucks[k];
                            bull_bucks[k] = x;
                        }  //End of if 
                    }
                } //End of For Loop
                

                int n = bull_bucks.Length;  
                for (int i = 0; i < bull_bucks.Length - 1; i++)
                {
                    if (bull_bucks[i] == bull_bucks[i + 1])  //if both the values are equal in the array
                        a = a - bull_bucks[i];  //remove the value
                    else if (bull_bucks[i] != bull_bucks[i + 1])
                        a = a + bull_bucks[i];    // add the value

                }
                a = a + bull_bucks[bull_bucks.Length - 1];
                if (a > 0)
                    return a;
                else
                    return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }   // End of SumOfUnique


        private static int DiagonalSum(int[,] bulls_grid)
        {
            try
            {
                int l = bulls_grid.GetLength(0);
                int diagsum = 0;
                // write your code here.
                for (int i = 0; i < l; i++)
                {
                    for (int j = 0; j < l; j++)
                    {
                        if ((i == j) || ((i + j) == l - 1))
                        {
                            diagsum = diagsum + bulls_grid[i, j];

                        }
                    }
                }
                return diagsum;

                return 0;
            }   //end of try
            catch (Exception e)
            {

                Console.WriteLine("An error occured: " + e.Message);
                throw;
            } //end of catch

        }  // end of DiagonalSum

        private static string RestoreString(string bulls_string, int[] indices)
        {
            try
            {
                // Start of code for Restore String 
                string rotated_string = "";

                char[] a = new char[indices.Length]; // storing a given string in char format 
                int[] b = new int[bulls_string.Length]; // storing the length in integer format
                char[] result = new char[bulls_string.Length];   // storing the length in char format
                int t = 0;
                foreach (char c in bulls_string)    //checking for character string
                {
                    a[t] = c;
                    t++;
                }
                for (int i = 0; i < bulls_string.Length; i++)
                {
                    result[indices[i]] = a[i];
                }
                foreach (char c in result)
                {
                    rotated_string = rotated_string + c.ToString();  
                }

                return rotated_string;

            }  // end of try
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        } // End of Restorestring

        private static string ReversePrefix(string bulls_string6, char ch)
        {
            try
            { 
                String prefix_string = "";
                int flag = 0;
                for (int i = 0; i < bulls_string6.Length; i++)
                {
                    if (bulls_string6[i] == ch)
                    {
                        int length = i;
                        flag = 1;
                        while (length >= 0)
                        {
                            prefix_string = prefix_string + bulls_string6[length];
                            length--;
                        }
                    }
                    else if (flag == 1)
                    {
                        prefix_string = prefix_string + bulls_string6[i];
                    }
                }
                return prefix_string;
            }
            catch (Exception)
            {

                throw;
            }

        }  // End of ReversePrefix

    }


}
