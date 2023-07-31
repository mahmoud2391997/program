using System;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Declaration [ <DataType> <identifier>;]
            int num;
            // 2. assigment [<identifier> = <value>;]
            num = 5;
            //3. initialization [<Datatype> <identifier> = <initial value>;]
            int num2 = 5;
            //string reference type
            string s1;
            s1 = "mahmoud";
            string s2 = "mohamed";
            // regular concatination (plus sign)
            string s3 = s1 +" "+ s2;
            Console.WriteLine(s3); //mahmoud mohamed
            string s4 = $"{s1} {s2}";
            Console.WriteLine(s4);//mahmoud mohamed
            Console.WriteLine($"int: [{int.MinValue} → {int.MaxValue}]");
            //var
            var S1 = "mahmoud";
            var f = 0f;
            var d = 0d;
            var m = 0m;
            var u = 0u;
            var l = 0l;
            var ul = 0ul;
            int oneMillion = 1_000_000;
            var result = 200 / 3.0;

            //dynamic
            dynamic x = 9;
            x = "abc";
            x = 10m;
            char letter = 'A';
            var id = 1000;
            var fname = "mahmoud";
            var lname = "A.";
            var salary = 1000d;
            var gender = 'M';
            var address = "ismailia,egypt";
            Console.WriteLine("Employee");
            Console.WriteLine("--------");
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"name: {lname}");
            Console.WriteLine($"salary: {salary}");
            Console.WriteLine($"gender: {gender}");
            Console.WriteLine($"address: {address}");
        }
    }
}
