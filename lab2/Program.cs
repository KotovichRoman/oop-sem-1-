using System;
using System.Text;

namespace lab2 {
    class Program {
        static void Main() {
            task4();
        }

        static void task1() {
            bool flag = true; //1.a
            int num1 = 2;
            double num2 = 2.2;
            char symbol = 'a';
            string str;

            Console.WriteLine(flag);
            Console.Write(num1 + " ");
            Console.WriteLine(num2);
            Console.WriteLine(symbol);
            Console.WriteLine();

            str = Console.ReadLine();
            Console.WriteLine(str);
            Console.WriteLine();

            byte a = 1; //1.b
            byte b = (byte)(a + 40);
            
            double a1 = 2.3;
            decimal b1 = (decimal) a1;

            int a2 = 30;
            double b2 = 2.2f;
            short c2 = (short)(a2 + b2); 

            ushort a3 = 4;
            byte b3 = (byte) a3;

            try {
                int a4 = 100;
                int b4 = 300;
                byte c4 = checked((byte)(a4 + b4)); 
                Console.WriteLine(c4);
            }
            catch (OverflowException err) {
                Console.WriteLine(err.Message);
            } 

            byte z = 2;
            int x = z + 10;

            sbyte z1 = -4;
            short x1 = z1;

            long x2 = x;
            double x3 = x1;
            short z2 = z; 

            short conv1 = Convert.ToInt16(Console.ReadLine());
            double conv2 = Convert.ToDouble(Console.ReadLine());

            int inBox = 4; //1.c
            Object box = inBox;
            int fBox = (int) box;

            var vr = 30; //1.d
            byte bt = 10;
            Console.WriteLine(vr + bt);
            var vr1 = "Hello";
            string str1 = "World";
            Console.WriteLine(vr1 + " " + str1);

            int? NumNull = 4; //1.e
            Console.WriteLine(NumNull.Value);
            Console.WriteLine(NumNull.HasValue);
            int NumNoNull = (int) NumNull;

            //var objc = 30; //1.f
            //objc = "line"; 
        }

        static void task2() {
            string str1 = "hello";
            string str2 = "world";
            string str3 = "004";

            Console.WriteLine(String.Compare(str1, str2)); //2.a

            string str4 = String.Concat(str1, " ", str2); //2.b
            string str5 = "";
            foreach (char elem in str4) {
                str5 += elem;
            }
            string str6 = str3.Substring(1);
            string[] str7 = str4.Split(' ', 2);
            string str8 = str4.Insert(6, str6);
            string str9 = str8.Remove(6);

            string inter = "world";
            Console.WriteLine($"Hello {inter}");

            string line1 = ""; //2.c
            string line2 = null;
            string line3 = "4";
            Console.WriteLine(String.IsNullOrEmpty(line1));
            Console.WriteLine(String.IsNullOrEmpty(line2));
            Console.WriteLine(String.IsNullOrEmpty(line3));

            StringBuilder str = new StringBuilder("Hello world");
            str.Remove(0, 6);
            str.Insert(0, "Hello ");
            str.Append("!!!");
            Console.WriteLine(str);
        }

        static void task3() {
            /*int[,] arr = { {1, 2, 3, 4, 5}, {6, 7, 8, 9, 0 }, {1, 2, 3, 4, 5} };
            for (int i = 0; i < arr.GetUpperBound(0) + 1; i++) {
                for (int j = 0; j < arr.GetUpperBound(1) + 1; j++) {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            string[] ArrStr = {"Hello", "World", "!!!"};
            foreach(string elem in ArrStr) {
                Console.Write($"{elem} ");
            }
            Console.WriteLine();
            Console.WriteLine(ArrStr.Length);
            while (true) {
                byte num = Convert.ToByte(Console.ReadLine());
                if (num < 3) {
                    ArrStr[num] = Console.ReadLine();
                    break; 
                }
                else {
                    Console.WriteLine("error");
                }
            }
            foreach(string elem in ArrStr) {
                Console.Write($"{elem} ");
            }*/

            double[][] array = new double[3][] {
                new double[2],
                new double[3],
                new double[4]
            };
            for (int i = 0; i < 2; i++) {
                array[0][i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++) {
                array[1][i] = Convert.ToDouble(Console.ReadLine());
            } 
            for (int i = 0; i < 4; i++) {
                array[2][i] = Convert.ToDouble(Console.ReadLine());
            } 
            for (int i = 0; i <= array.GetUpperBound(0); i++) {
                for (int j = 0; j <= array[i].Length; j++) {
                    Console.WriteLine(array[i][j]);
                }
                Console.WriteLine();
            }

            var VarArr = new[] {1, 2, 3};
            var VarStr = "line";
            Console.WriteLine(VarStr);
        }

        static void task4() {
            (int, string, char, string, ulong) kort = (-10, "Hello", '!', "World", 100);

            Console.Write(kort.Item1 + " ");
            Console.Write(kort.Item2 + " ");
            Console.Write(kort.Item3 + " ");
            Console.Write(kort.Item4 + " ");
            Console.Write(kort.Item5 + " ");
            Console.WriteLine();
            byte k, c;
            while (true) {
                k = Convert.ToByte(Console.ReadLine());
                switch (k) {
                    case 1: {Console.WriteLine(kort.Item1); break;}
                    case 2: {Console.WriteLine(kort.Item2); break;}
                    case 3: {Console.WriteLine(kort.Item3); break;}
                    case 4: {Console.WriteLine(kort.Item4); break;}
                    case 5: {Console.WriteLine(kort.Item5); break;}
                    default: {Console.WriteLine("error"); break;}
                }
                Console.WriteLine("exit? 1-yes 2-no");
                c = Convert.ToByte(Console.ReadLine());
                if (c == 1) {
                    break;
                }
            }

        }
    }
}
