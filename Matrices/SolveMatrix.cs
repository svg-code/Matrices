using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class SolveMatrix
    {
        public int R1C1 { get; set; }
        public int R1C2 { get; set; }
        public int R1C3 { get; set; }
        public int R1C4 { get; set; }

        public int R2C1 { get; set; }
        public int R2C2 { get; set; }
        public int R2C3 { get; set; }
        public int R2C4 { get; set; }

        public int R3C1 { get; set; }
        public int R3C2 { get; set; }
        public int R3C3 { get; set; }
        public int R3C4 { get; set; }

        public int R4C1 { get; set; }
        public int R4C2 { get; set; }
        public int R4C3 { get; set; }
        public int R4C4 { get; set; }


        public string Selection { get; set; }
        public string Confirm { get; set; }

        public string Dimension { get; set; }


        public void CalcHome()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Enter \n " +
                "\"1\" To find the determinant of a 4 by 4 matrix \n \"2\" For matrices Dot multiplication \n \"3\" For matrix scalar multiplication");
            Selection = Console.ReadLine();

            if (Selection == "1")
            {
                FindDeterminant();
            }
            else if (Selection == "2")
            {
                MultiplyMatrix();
            }
            else if (Selection == "3")
            {
                ScalarMultiplication();
            }
            else
            {
                Console.WriteLine("Invalid entry, try again");
                CalcHome();
            }
        }

        public void FindDeterminant()
        {
            Console.WriteLine("Enter matrix elements row by row");
            Console.WriteLine("Row 1, Column 1");
            R1C1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Row 1, Column 2");
            R1C2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Row 1, Column 3");
            R1C3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Row 1, Column 4");
            R1C4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Row 2, Column 1");
            R2C1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Row 2, Column 2");
            R2C2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Row 2, Column 3");
            R2C3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Row 2, Column 4");
            R2C4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Row 3, Column 1");
            R3C1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Row 3, Column 2");
            R3C2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Row 3, Column 3");
            R3C3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Row 3, Column 4");
            R3C4 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Row 4, Column 1");
            R4C1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Row 4, Column 2");
            R4C2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Row 4, Column 3");
            R4C3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Row 4, Column 4");
            R4C4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter \n \"1\" To confirm that this is your matrix \n \"2\" To go back");
            Console.WriteLine($"|  {R1C1} {R1C2} {R1C3} {R1C4}  |");
            Console.WriteLine($"|  {R2C1} {R2C2} {R2C3} {R2C4}  |");
            Console.WriteLine($"|  {R3C1} {R3C2} {R3C3} {R3C4}  |");
            Console.WriteLine($"|_ {R4C1} {R4C2} {R4C3} {R4C4} _|");

            Confirm = Console.ReadLine();

            if(Confirm == "1")
            {

                Console.Write("Answer: ");
                Console.Write($"{/*A*/(R1C1 *( (R2C2 *( (R3C3 * R4C4) - (R3C4 * R4C3)) )- R2C3 *((R3C2 * R4C4) - (R3C4 * R4C2)) + R2C4 * ((R3C2 * R4C3) - (R3C3 * R4C2))) )- /*B*/(R1C2 * (R2C1 *( (R3C3 * R4C4) - (R3C4 * R4C3)) - R2C3 * ((R3C1 * R4C4) - (R3C4 * R4C1)) + R2C4 * ((R3C1 * R4C3) - (R3C3 * R4C1)) )) + /*C*/(R1C3 *( (R2C1 *( (R3C2 * R4C4) - (R3C4 * R4C2))) - R2C2 * ((R3C1 * R4C4) - (R3C4 * R4C1)) + R2C4 * ((R3C1 * R4C2) - (R3C2 * R4C1))) )- /*D*/(R1C4 *( (R2C1 *( (R3C2 * R4C3) - (R3C3 * R4C2))) - R2C2 * ((R3C1 * R4C3) - (R3C3 * R4C1)) + R2C3 * ((R3C1 * R4C2) - (R3C2 * R4C1)) )) }");
            }
            else if(Confirm == "2")
            {
                CalcHome();
            } 
            else
            {
                Console.WriteLine("Invalid entry, try Again");
                CalcHome();
            }
            CalcHome();
        }
   
        public void MultiplyMatrix()
        {
            Console.WriteLine("To multiply two matrices, the number of columns of the first " +
                "matrix must equal the number of rows of the second matrix");
            Console.WriteLine("(Note that matrix A * matrix B is not the same as matrix B * matrix A)");

            Console.WriteLine("Enter the dimension of the matrices (Row by Column) " +
               "\n \"1\"  1 by 2 * 2 by 2 " +
               "\n \"2\"  2 by 2 * 2 by 2 " +
               "\n \"3\"  2 by 3 * 3 by 2 " +
               "\n \"4\"  1 by 3 * 3 by 2 " +
               "\n \"5\"  3 by 3 * 3 by 3 " +
               "\n \"6\"  1 by 3 * 3 by 1 " +
               "\n \"7\"  1 by 2 * 2 by 3 " +
               "\n \"8\"  2 by 2 * 2 by 1 " +
               "\n \"9\"  3 by 2 * 2 by 3 " +
               "\n \"10\" 3 by 1 * 1 by 3 " +
               "\n \"11\" 3 by 2 * 2 by 1 " +
               "\n \"12\" 2 by 1 * 1 by 2 " +
               "\n \"13\" 2 by 1 * 1 by 3 " +
               "\n \"14\" 2 by 3 * 3 by 1 " +
               "\n \"15\" 1 by 2 * 2 by 1 ");
            Dimension = Console.ReadLine();

            int ra1ca1, ra1ca2, ra1ca3,
                ra2ca1, ra2ca2, ra2ca3,
                ra3ca1, ra3ca2, ra3ca3;

            int rb1cb1, rb1cb2, rb1cb3,
                rb2cb1, rb2cb2, rb2cb3,
                rb3cb1, rb3cb2, rb3cb3;


            if (Dimension == "1")
            {
                //1 by 2 * 2 by 2
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                ra1ca2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                rb1cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                rb2cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                rb2cb2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer:");
                Console.WriteLine($"[{(ra1ca1 * rb1cb1) + (ra1ca2 * rb2cb1)} {(ra1ca1 * rb1cb2) + (ra1ca2 * rb2cb2)}]");

            }
            else if(Dimension == "2")
            {
                //2 by 2 * 2 by 2
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                ra1ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                ra2ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                ra2ca2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                rb1cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                rb2cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                rb2cb2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer:");
                Console.WriteLine($"{(ra1ca1 * rb1cb1) + (ra1ca2 * rb2cb1)} {(ra1ca1 * rb1cb2) + (ra1ca2 * rb2cb2)}");
                Console.WriteLine($"{(ra2ca1 * rb1cb1) + (ra2ca2 * rb2cb1)} {(ra2ca1 * rb1cb2) + (ra2ca2 * rb2cb2)}");
            }
            else if (Dimension == "3")
            {
                //2 by 3 * 3 by 2
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                ra1ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 3");
                ra1ca3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                ra2ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                ra2ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 3");
                ra2ca3 = Convert.ToInt32(Console.ReadLine());
                 
                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                rb1cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                rb2cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                rb2cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 1");
                rb3cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 2");
                rb3cb2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer:");
                Console.WriteLine($"|{(ra1ca1 * rb1cb1) + (ra1ca2 * rb2cb1) + (ra1ca3 * rb3cb1)} {(ra1ca1 * rb1cb2) + (ra1ca2 * rb2cb2) + (ra1ca3 * rb3cb2)}|");
                Console.WriteLine($"|{(ra2ca1 * rb1cb1) + (ra2ca2 * rb2cb1) + (ra2ca3 * rb3cb1)} {(ra2ca1 * rb1cb2) + (ra2ca2 * rb2cb2) + (ra2ca3 * rb3cb2)}|");

            }
            else if (Dimension == "4")
            {
                //1 by 3 * 3 by 2
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                ra1ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 3");
                ra1ca3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                rb1cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                rb2cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                rb2cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 1");
                rb3cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 2");
                rb3cb2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer:");
                Console.WriteLine($"[{(ra1ca1 * rb1cb1) + (ra1ca2 * rb2cb1) + (ra1ca3 * rb3cb1)} {(ra1ca1 * rb1cb2) + (ra1ca2 * rb2cb2) + (ra1ca3 * rb3cb2)}]");
            }
            else if (Dimension == "5")
            {
                //3 by 3 * 3 by 3
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                ra1ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 3");
                ra1ca3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                ra2ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                ra2ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 3");
                ra2ca3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 1");
                ra3ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 2");
                ra3ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 3");
                ra3ca3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                rb1cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 3");
                rb1cb3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                rb2cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                rb2cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 3");
                rb2cb3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 1");
                rb3cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 2");
                rb3cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 3");
                rb3cb3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer:");
                Console.WriteLine($"|{(ra1ca1 * rb1cb1) + (ra1ca2 * rb2cb1) + (ra1ca3 * rb3cb1)} {(ra1ca1 * rb1cb2) + (ra1ca2 * rb2cb2) + (ra1ca3 * rb3cb2)} {(ra1ca1 * rb1cb3) + (ra1ca2 * rb2cb3) + (ra1ca3 * rb3cb3)}|");
                Console.WriteLine($"|{(ra2ca1 * rb1cb1) + (ra2ca2 * rb2cb1) + (ra2ca3 * rb3cb1)} {(ra2ca1 * rb1cb2) + (ra2ca2 * rb2cb2) + (ra2ca3 * rb3cb2)} {(ra2ca1 * rb1cb3) + (ra2ca2 * rb2cb3) + (ra2ca3 * rb3cb3)}|");
                Console.WriteLine($"|{(ra3ca1 * rb1cb1) + (ra3ca2 * rb2cb1) + (ra3ca3 * rb3cb1)} {(ra3ca1 * rb1cb2) + (ra3ca2 * rb2cb2) + (ra3ca3 * rb3cb2)} {(ra3ca1 * rb1cb3) + (ra3ca2 * rb2cb3) + (ra3ca3 * rb3cb3)}|");

            }
            else if (Dimension == "6")
            {
                //1 by 3 * 3 by 1
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                ra1ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 3");
                ra1ca3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                rb2cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 1");
                rb3cb1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer: ");
                Console.WriteLine($"[{(ra1ca1 * rb1cb1) + (ra1ca2 * rb2cb1) + (ra1ca3 * rb3cb1)}]");
            }
            else if (Dimension == "7")
            {
                //1 by 2 * 2 by 3
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                ra1ca2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                rb1cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 3");
                rb1cb3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                rb2cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                rb2cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 3");
                rb2cb3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer:");
                Console.WriteLine($"[{(ra1ca1 * rb1cb1) + (ra1ca2 * rb2cb1)} {(ra1ca1 * rb1cb2) + (ra1ca2 * rb2cb2)} {(ra1ca1 * rb1cb3) + (ra1ca2 * rb2cb3)}]");
            }
            else if (Dimension == "8")
            {
                //2 by 2 * 2 by 1
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                ra1ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                ra2ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                ra2ca2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                rb2cb1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer:");
                Console.WriteLine($"|{(ra1ca1 * rb1cb1) + (ra1ca2 * rb2cb1)}|");
                Console.WriteLine($"|{(ra2ca1 * rb1cb1) + (ra2ca2 * rb2cb1)}|");

            }
            else if (Dimension == "9")
            {
                //3 by 2 * 2 by 3
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                ra1ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                ra2ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                ra2ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 1");
                ra3ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 2");
                ra3ca2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                rb1cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 3");
                rb1cb3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                rb2cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                rb2cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 3");
                rb2cb3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer:");
                Console.WriteLine($"|{(ra1ca1 *rb1cb1) + (ra1ca2 * rb2cb1)} {(ra1ca1 * rb1cb2) + (ra1ca2 * rb2cb2)} {(ra1ca1 * rb1cb3) + (ra1ca2 * rb2cb3)}|");
                Console.WriteLine($"|{(ra2ca1 * rb1cb1) + (ra2ca2 * rb2cb1)} {(ra2ca1 * rb1cb2) + (ra2ca2 * rb2cb2)} {(ra2ca1 * rb1cb3) + (ra2ca2 * rb2cb3)}|");
                Console.WriteLine($"|{(ra3ca1 * rb1cb1) + (ra3ca2 * rb2cb1)} {(ra3ca1 * rb1cb2) + (ra3ca2 * rb2cb2)} {(ra3ca1 * rb1cb3) + (ra3ca2 * rb2cb3)}|");
            }
            else if (Dimension == "10")
            {
                //3 by 1 * 1 by 3
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                ra2ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 1");
                ra3ca1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                rb1cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 3");
                rb1cb3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer: ");
                Console.WriteLine($"|{(ra1ca1 * rb1cb1)} {(ra1ca1 * rb1cb2)} {(ra1ca1 * rb1cb3)}|");
                Console.WriteLine($"|{(ra2ca1 * rb1cb1)} {(ra2ca1 * rb1cb2)} {(ra2ca1 * rb1cb3)}|");
                Console.WriteLine($"|{(ra3ca1 * rb1cb1)} {(ra3ca1 * rb1cb2)} {(ra3ca1 * rb1cb3)}|");
            }
            else if (Dimension == "11")
            {
                //3 by 2 * 2 by 1
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                ra1ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                ra2ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                ra2ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 1");
                ra3ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 2");
                ra3ca2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                rb2cb1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer:");
                Console.WriteLine($"|{(ra1ca1 * rb1cb1) + (ra1ca2 * rb2cb1)}|");
                Console.WriteLine($"|{(ra2ca1 * rb1cb1) + (ra2ca2 * rb2cb1)}|");
                Console.WriteLine($"|{(ra3ca1 * rb1cb1) + (ra3ca2 * rb2cb1)}|");
            }
            else if (Dimension == "12")
            {
                //2 by 1 * 1 by 2 
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                ra2ca1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                rb1cb2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"|{(ra1ca1 * rb1cb1)} {(ra1ca1 * rb1cb2)}|");
                Console.WriteLine($"|{(ra2ca1 * rb1cb1)} {(ra2ca1 * rb1cb2)}|");
            }
            else if (Dimension == "13")
            {
                //2 by 1 * 1 by 3
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                ra2ca1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                rb1cb2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 3");
                rb1cb3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer: ");
                Console.WriteLine($"|{(ra1ca1 * rb1cb1)} {(ra1ca1 * rb1cb2)} {(ra1ca1 * rb1cb3)}|");
                Console.WriteLine($"|{(ra2ca1 * rb1cb1)} {(ra2ca1 * rb1cb2)} {(ra2ca1 * rb1cb3)}|");
            }
            else if (Dimension == "14")
            {
                //2 by 3 * 3 by 1
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                ra1ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 3");
                ra1ca3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                ra2ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                ra2ca2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 3");
                ra2ca3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                rb2cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 1");
                rb3cb1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer: ");
                Console.WriteLine($"|{(ra1ca1 * rb1cb1) + (ra1ca2 * rb2cb1) + (ra1ca3 * rb3cb1)}|");
                Console.WriteLine($"|{(ra2ca1 * rb1cb1) + (ra2ca2 * rb2cb1) + (ra2ca3 * rb3cb1)}|");
            }
            else if (Dimension == "15")
            {
                //1 by 2 * 2 by 1
                Console.WriteLine("Enter elements of the first matrix");
                Console.WriteLine("Row 1, Column 1");
                ra1ca1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                ra1ca2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter elements of the second matrix");
                Console.WriteLine("Row 1, Column 1");
                rb1cb1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                rb2cb1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Answer:");
                Console.WriteLine($"[{(ra1ca1 * rb1cb1) + (ra1ca2 * rb2cb1)}]");
            }
            else
            {
                Console.WriteLine("Invalid entry, try again");
                CalcHome();
            }
            CalcHome();
        }

        public void ScalarMultiplication()
        {
            Console.WriteLine("Enter the dimension of the matrix (Row by Column) " +
                "\n \"1\" For 1 by 2 matrix " +
                "\n \"2\" For 1 by 3 matrix" +
                "\n \"3\" For 2 by 1 matrix" +
                "\n \"4\" For 2 by 2 matrix" +
                "\n \"5\" For 2 by 3 matrix" +
                "\n \"6\" For 3 by 1 matrix" +
                "\n \"7\" For 3 by 2 matrix" +
                "\n \"8\" For 3 by 3 matrix");
            Dimension = Console.ReadLine();

            Console.WriteLine("Enter matrix elements row by row");
            int constant;
            if (Dimension == "1")
            {
                Console.WriteLine("Row 1, Column 1");
                R1C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                R1C2 = Convert.ToInt32(Console.ReadLine());
                int[] array1D = { R1C1, R1C2}; 
                Console.WriteLine("Enter the constant");
                constant = Convert.ToInt32(Console.ReadLine());
                DotMultiplication1D(array1D, constant);
                Console.WriteLine("Answer:");
                Console.WriteLine($"[{array1D[0]} {array1D[1]}]");
            }
            else if(Dimension == "2")
            {
                Console.WriteLine("Row 1, Column 1");
                R1C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                R1C2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 3");
                R1C3 = Convert.ToInt32(Console.ReadLine());
                int[] array1D = { R1C1, R1C2, R1C3 };
                Console.WriteLine("Enter the constant");
                constant = Convert.ToInt32(Console.ReadLine());
                DotMultiplication1D(array1D, constant);
                Console.WriteLine("Answer:");
                Console.WriteLine($"[{array1D[0]} {array1D[1]} {array1D[2]}]");
            }
            else if (Dimension == "3")
            {
                Console.WriteLine("Row 1, Column 1");
                R1C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                R2C1 = Convert.ToInt32(Console.ReadLine());
                int[] array1D = { R1C1,
                                  R2C1     
                };
                Console.WriteLine("Enter the constant");
                constant = Convert.ToInt32(Console.ReadLine());
                DotMultiplication1D(array1D, constant);
                Console.WriteLine("Answer:");
                Console.WriteLine($"|{array1D[0]}|");
                Console.WriteLine($"|{array1D[1]}|");
            }
            else if (Dimension == "4")
            {
                Console.WriteLine("Row 1, Column 1");
                R1C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                R1C2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                R2C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                R2C2 = Convert.ToInt32(Console.ReadLine());
                int[] array1D = { R1C1, R1C2, 
                                  R2C1, R2C2 };
                Console.WriteLine("Enter the constant");
                constant = Convert.ToInt32(Console.ReadLine());
                DotMultiplication1D(array1D, constant);
                Console.WriteLine("Answer:");
                Console.WriteLine($"|{array1D[0]} {array1D[1]}|");
                Console.WriteLine($"|{array1D[2]} {array1D[3]}|");
            }
            else if (Dimension == "5")
            {
                Console.WriteLine("Row 1, Column 1");
                R1C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                R1C2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 3");
                R1C3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                R2C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                R2C2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 3");
                R2C3 = Convert.ToInt32(Console.ReadLine());
                int[] array1D = { R1C1, R1C2, R1C3,
                                  R2C1, R2C2, R2C3 };
                Console.WriteLine("Enter the constant");
                constant = Convert.ToInt32(Console.ReadLine());
                DotMultiplication1D(array1D, constant);
                Console.WriteLine("Answer:");
                Console.WriteLine($"|{array1D[0]} {array1D[1]} {array1D[2]}|");
                Console.WriteLine($"|{array1D[3]} {array1D[4]} {array1D[5]}|");
            }
            else if (Dimension == "6")
            {
                Console.WriteLine("Row 1, Column 1");
                R1C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                R2C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 1");
                R3C1 = Convert.ToInt32(Console.ReadLine());
                int[] array1D = { R1C1, 
                                  R2C1, 
                                  R3C1,
                };
                Console.WriteLine("Enter the constant");
                constant = Convert.ToInt32(Console.ReadLine());
                DotMultiplication1D(array1D, constant);
                Console.WriteLine("Answer:");
                Console.WriteLine($"|{array1D[0]}|");
                Console.WriteLine($"|{array1D[1]}|");
                Console.WriteLine($"|{array1D[2]}|");
            }
            else if (Dimension == "7")
            {
                Console.WriteLine("Row 1, Column 1");
                R1C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                R1C2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                R2C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                R2C2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 1");
                R3C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 2");
                R3C2 = Convert.ToInt32(Console.ReadLine());
                int[] array1D = { R1C1, R1C2,
                                  R2C1, R1C2,
                                  R3C1, R3C2
                };
                Console.WriteLine("Enter the constant");
                constant = Convert.ToInt32(Console.ReadLine());
                DotMultiplication1D(array1D, constant);
                Console.WriteLine("Answer:");
                Console.WriteLine($"|{array1D[0]} {array1D[1]}|");
                Console.WriteLine($"|{array1D[2]} {array1D[3]}|");
                Console.WriteLine($"|{array1D[4]} {array1D[5]}|");
            }
            else if (Dimension == "8")
            {
                Console.WriteLine("Row 1, Column 1");
                R1C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 2");
                R1C2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 1, Column 3");
                R1C3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 1");
                R2C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 2");
                R2C2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 2, Column 3");
                R2C3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 1");
                R3C1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 2");
                R3C2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Row 3, Column 3");
                R3C3 = Convert.ToInt32(Console.ReadLine());
                int[] array1D = { R1C1, R1C2, R1C3,
                                  R2C1, R1C2, R2C3,
                                  R3C1, R3C2, R3C3
                };
                Console.WriteLine("Enter the constant");
                constant = Convert.ToInt32(Console.ReadLine());
                DotMultiplication1D(array1D, constant);
                Console.WriteLine("Answer:");
                Console.WriteLine($"|{array1D[0]} {array1D[1]} {array1D[2]}|");
                Console.WriteLine($"|{array1D[3]} {array1D[4]} {array1D[5]}|");
                Console.WriteLine($"|{array1D[6]} {array1D[7]} {array1D[8]}|");
            }
            else
            {
                Console.WriteLine("Invalid entry, try again");
                ScalarMultiplication();
            }
            CalcHome();
        }

        public int[] DotMultiplication1D(int[] arr,int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= num;
            }
            return arr;
        }
    }
}
