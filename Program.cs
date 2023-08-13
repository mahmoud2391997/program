//namespace program;

//internal class system
//{
//    private static void main(string[] args)
//    {
//        // 1.declaration [ <datatype> <identifier>;]
//        int num;
//        // 2. assigment [<identifier> = <value>;]
//        num = 5;
//        //3. initialization [<datatype> <identifier> = <initial value>;]
//        int num2 = 5;
//        //string reference type
//        string s1;
//        s1 = "mahmoud";
//        string s2 = "mohamed";
//        // regular concatination (plus sign)
//        string s3 = s1 + " " + s2;
//        console.writeline(s3); //mahmoud mohamed
//        string s4 = $"{s1} {s2}";
//        console.writeline(s4);//mahmoud mohamed
//        console.writeline($"int: [{int.minvalue} → {int.maxvalue}]");
//        //var
//        var s1 = "mahmoud";
//        var f = 0f;
//        var d = 0d;
//        var m = 0m;
//        var u = 0u;
//        var l = 0l;
//        var ul = 0ul;
//        int onemillion = 1_000_000;
//        var result = 200 / 3.0;

//        //dynamic
//        dynamic x = 9;
//        x = "abc";
//        x = 10m;
//        char letter = 'a';
//        var id = 1000;
//        var fname = "mahmoud";
//        var lname = "a.";
//        var salary = 1000d;
//        var gender = 'm';
//        var address = "ismailia,egypt";
//        console.writeline("employee");
//        console.writeline("--------");
//        console.writeline($"id: {id}");
//        console.writeline($"name: {lname}");
//        console.writeline($"salary: {salary}");
//        console.writeline($"gender: {gender}");
//        console.writeline($"address: {address}");
//        var x = 10;
//        var y = 10;
//        // console.writeline(x == y); // is x equal to y? => true
//        //expression 1+2+3
//        var z = x == y;
//        console.writeline(z);
//        var total = 1000;
//        var vipthreshold = 900;
//        var isvip = total >= vipthreshold; // > , < , <=
//        console.writeline(isvip);
//        isvip = !true;
//        console.writeline(isvip);
//        // && ||
//        //logical and &&
//        console.writeline(true && true);
//        console.writeline(true && false);
//        console.writeline(false && true);
//        console.writeline(false && false);

//        //logical or !!
//        console.writeline(true || true);
//        console.writeline(true || false);
//        console.writeline(false || true);
//        console.writeline(false || false);

//        //logical xor
//        console.writeline(true ^ true);
//        console.writeline(true ^ false);
//        console.writeline(false ^ true);
//        console.writeline(false ^ false);
//        var isfirstfive = true;
//        var gpa = 3.5;
//        var iselegibletoscholarship = gpa >= 3.5 && isfirstfive;
//        var isfirstfive2 = true;
//        var gpa2 = 3.4;
//        var iselegibletoscholarship2 = gpa2 >= 3.5 || isfirstfive2;
//        console.writeline(iselegibletoscholarship);
//        console.writeline(iselegibletoscholarship2);
//        console.writeline(true & true);
//        console.writeline(true & false);
//        console.writeline(false & true);
//        console.writeline(false & false);
//        bool value = check() || true;
//        var a = 1;
//        var b = 2;
//        var c = x == y;
//        console.writeline(c);
//        var v1 = "hello";
//        var v2 = "hello";
//        var v3 = v1 == v2;
//        console.writeline(v3);
//        var totalpurchases = 900;
//        var vipthreshold = 1000;
//        var vip = total >= vipthreshold ? true : false;
//        var discount = total >= vipthreshold ? "0.05%" : "0.0%";
//        console.writeline(discount);


//        console.readkey();
//        static bool check()
//        {
//            console.writeline("checking...");
//            return true;
//        }
//    }
//}

////arrays

//class program
//{
//    static void main(string[] args)
//    {
//        // single dimensional array
//        //declaration
//        string[] friends = new string[5];
//        //2.accessing element
//        friends[0] = "ali";
//        friends[1] = "reem";
//        friends[2] = "faisal";
//        friends[3] = "ahmed";
//        friends[4] = "abeer";
//        //accessing elements with another way
//        string[] friends1 = new string[5]
//        {
//            "ali","reem","faisal","ahmed","abeer"
//        };
//        //accessing elements with another way
//        string[] friends2 =  {
//            "ali","reem","faisal","ahmed","abeer"
//        };
//        // multi dimensional array {rectangular array}
//        int[,] suduko = {
//        {1,2,3,4,5,6,7,8,9 },
//        {1,2,3,4,5,6,7,8,9 },
//        {1,2,3,4,5,6,7,8,9 },
//        {1,2,3,4,5,6,7,8,9 },
//        {1,2,3,4,5,6,7,8,9 },
//        {1,2,3,4,5,6,7,8,9 },
//        {1,2,3,4,5,6,7,8,9 },
//        {1,2,3,4,5,6,7,8,9 },
//        {1,2,3,4,5,6,7,8,9 }
//        };
//        // jagged array {array inside array}
//        var jagged = new int[][]
//        {
//            new int[] {1,2,3,4},
//            new int[] {1,2},
//            new int[] {3,4,5}
//        };
//        var friends4 = new string[] { "ali", "reem" };
//        var first = friends4[0];
//        // indices and ranges
//        var slices = friends[..2];
//        slices.print();
//        console.writeline(first);
//        console.readkey();
//    }

//}

//public static class extensions
//{
//    public static void print<t>(this t[] source)
//    {
//        if (!source.any())
//        {
//            console.writeline("{}");
//            return;
//        }
//        console.writeline("{ ");
//        for (var i = 0; i < source.length; i++)
//        {
//            console.writeline($"{source[i]}");
//            console.writeline(i < source.length - 1 ? ", " : "");

//        }
//        console.writeline(" }");
//    }
//}