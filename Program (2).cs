﻿//    namespace Program1
//{
//    class Program1
//    {
//        static void Main(string[] args)
//        {
//            // binary operator
//            var amount = Math.Cos(30) + 1;
//            Console.WriteLine(amount);
//            Console.WriteLine("mahmoud");
//            var x = 2;
//            var y = 5;
//            Console.WriteLine($"x + y = {x + y}");
//            Console.WriteLine($"x - y = {x - y}");
//            Console.WriteLine($"x / y = {x / y}");
//            Console.WriteLine($"x * y = {x * y}");
//            Console.WriteLine($"x % y = {x % y}");
//            var z = 8 / 4 / 2; //1
//            var Z = 8 / (4 / 2); //4
//            Console.WriteLine(Z);
//            var s1 = "";
//            var s2 = "";
//            var s3 = s1 = s2 = "mahmoud";
//            Console.WriteLine(s1);


//            x = x + 10;//12
//            // null operator
//            string S1 = null;
//            S1 = S1 ?? "mahmoud";
//            Console.WriteLine(S1);
//            S1 = S1 ?? "someone else";
//            Console.WriteLine(S1);
//            string S2 = null;
//            var S3 = S2?.ToUpper();
//            Console.WriteLine(S3);
//            // statement and statement blocks
//            Console.WriteLine("hi");
//            {
//                Console.WriteLine("hi");
//                Console.WriteLine("hello");

//            }
//            //declaration statement 
//            int X;
//            //Expression statement 
//            //1. change state
//            var name = "mahmoud";
//            name = name + "elsayed";
//            //2.call something that change the state
//            name = name.ToUpper();
//            Console.WriteLine(name);
//            //3. increment and decrement 
//            var totalfriends = 150;
//            ++totalfriends;
//            Console.WriteLine(totalfriends);
//            --totalfriends;
//            Console.WriteLine(totalfriends);
//            var Q = 2;
//            Console.WriteLine(Q++);
//            Console.WriteLine(Q);
//            //5. object instansiation
//            Object o = new object();
//            //if
//            var mark = 90;
//            if (mark >= 85)
//            {
//                Console.WriteLine("Excellent");
//            }
//            mark = 55;
//            if (mark >= 60)
//            {
//                Console.WriteLine("passed");
//            }
//            else if(mark >=55)
//            {
//                Console.WriteLine("you can have a chance in a make up exam");
//            }
//            else
//            {
//                Console.WriteLine("failed");
//            }
//            if (mark >= 60)
//            {
//                if (mark >= 85)
//                {
//                    Console.WriteLine("Excellent");
//                }
//            }
//            //switch
//            var amountEGP = 100;
//            var currType = "USD";
//            var output = 0d;

//            var USDtoEGP = 33d;
//           switch(currType)
//            {
//                case "USD":
//                    output = amountEGP / USDtoEGP;
//                    Console.WriteLine(output);
//                    break;
//            }
//            var  NO= 3;
//            switch (NO)
//            {
//                case 1:
//                case 3:
//                case 5:
//                case 7:
//                    Console.WriteLine("ODD");
//                    break;
//                case 2:
//                case 4:
//                case 6:
//                case 8:
//                    Console.WriteLine("even");
//                    break;
//            }
//            Object K = "Mahmoud";
//            switch(K)
//            {
//                case int i: Console.WriteLine($"it's int,sqr of{i}={i * i}");
//                    break;
//                case string i: Console.WriteLine($"it's a string, capitalization of {i} = {i.ToUpper()}");
//                    break;     }
//            bool IsVip = true;
//            switch (IsVip)
//            {
//                case bool i when i == true:
//                    Console.WriteLine("yes");
//                    break;
//                case bool i:
//                    Console.WriteLine("no");
//                    break;

//            }
//            var cardNo = 13;
//            string cardName = cardNo switch
//            {
//                1 => "ACE",
//                13 => "King",
//                12 => "Queen",
//                11 => "Jack",
//                _ => cardNo.ToString()


//            };
//            Console.WriteLine(cardName);
//            //iteration
//            //while
//            var counter =0;

//            while (counter < 10)
//            {
//                Console.Write(counter + " ");
//                counter++;
//            }
//            counter = 0;
//            do
//            {
//                Console.Write(counter + " ");
//                counter++;

//            } while (counter < 10);
//            //for

//            for(var count = 0;count < 10; ++count)
//            {
//                Console.Write(count + " ");
//            }
//            //fibonacci{0,1,1,2,3,5,8,13,21,34}
//            for (int count = 0 ,prev =0 , current = 1; count < 10; ++count)
//            {
//                Console.Write(prev + " ");
//                int newFib = prev + current;
//                prev = current;
//                current = newFib;
//            }
//            // infinite loop for(; ; ){}
//            //for each

//            foreach(char c in "full stack developer course")
//            {
//                Console.Write(c+ " ");

//            };
//            var arr = new int[] { 1, 2, 3, 4 };
//            foreach(var n in arr)
//            {
//                Console.Write(n + " ");
//            }
//            for (var i = 0;i < arr.Length; i++)
//            {
//                Console.Write(arr[i] + " ");
//            }
//            //Jump{break,continue,goto, return}
//            var I = 0;
//            while(I<10)
//            {
//                if (I > 5)
//                    break;
//                Console.Write(I + " ");
//                I++;
//            }
//            for(int i =0; i< 10; i++)
//            {
//                if (i % 2 == 0)
//                    continue;
//                        Console.Write(i+" ");
//            }
//            var P = 0;
//            start:
//            if(P <= 5)
//            {
//                Console.Write(P + " ");
//                P++;
//                goto start;
//                Console.WriteLine("mahmoud");
//            }
//            var input = .44m;
//            var result = AsPercentage(input);
//            Console.WriteLine(result);
//            static decimal AsPercentage(decimal amount)
//            {
//                return amount * 100;
//            }
//            Console.ReadKey();
//        }
//    }
//}
//using System;
//namespace Program1
//{ 
// class Program {

//        static void Main(string[] args)
//        {
//            Int32 x; //int x; => 32 bit
//            Int16 s; //short s; => 16 bit
//            Int64 l; //long l; => 64 bit
//            short sh; //-32767 > 32768
//            ushort ush; // 0 - 65???;
//            UInt16 uns;
//            //object
//            var num = 10;
//            string str = "10";
//            // int num2 = str; {invalid} because it's a strongly typed language
//            int numberInt = 100;
//            long numberLong = numberInt;
//            long nl = 1000;
//            if (nl <= Int32.MaxValue)
//            {
//                int nI = (int)nl;
//            }
//            double d = 1234.1;
//            int I = (int)d;
//            Console.WriteLine(I);

//            //Boxing , UnBoxing
//            int X = 10;//value type
//            object obj; //refrence type
//            obj = X; //conversion done implicitly (boxing)
//            int y = (int)obj; //unboxing
//            //Int32(int) - Int64 (long)
//            string stringValue = "120";
//            int number = int.Parse(stringValue);
//            Console.WriteLine(number);
//            string Stringvalue = "999999999999";
//            //  int Number = int.Parse(Stringvalue); Value is too large  for an Int32.'
//            if (int.TryParse(Stringvalue, out int Number))
//            {
//                Console.WriteLine(Number);
//            }
//            else
//            {
//                Console.WriteLine("invalid number provided or doesn't fit integer");
//            }
//            // 1) type.parse() => int.Parse(), double.Parse()....
//            //    var P = Convert.ToInt32(Stringvalue);  Value is too large  for an Int32
//            string StringValue = "dsjk";
//            //    var P = Convert.ToInt32(StringValue); value doesn't fit Int32

//            //BitConverter
//            var NUM = 255;
//            var bytes = BitConverter.GetBytes(NUM);
//            foreach (var b in bytes)
//            {
//                var binary = Convert.ToString(b, 2).PadLeft(8, '0');
//                Console.WriteLine(binary);
//        }
//            var NAME = "Mahmoud";
//            char[] letters = NAME.ToCharArray();
//            foreach (var L in letters)
//            {
//                int ascii = Convert.ToInt32(L);
//                var output = $"'{L}' → ASCII:{ascii}, Binary:{Convert.ToString(ascii, 2).PadLeft(8, '0')},{ascii:x}";
//                Console.WriteLine(output);
//            }
//            string[] hexValues = { "4d", "61", "68", "6d", "6f", "75" ,"64" };
//            foreach (var hex in hexValues)
//            {
//                int value = Convert.ToInt32(hex, 16);
//                var stringvalue = Char.ConvertFromUtf32(value); //#1
//                var ch = (char)value;//#2
//                Console.WriteLine(stringvalue);
//                Console.WriteLine(ch);
//            }
//            var hexa = "8E2";
//            int no = Int32.Parse(hexa, System.Globalization.NumberStyles.HexNumber);
//            Console.WriteLine(no);

//            Console.ReadKey();


//    }

//}}