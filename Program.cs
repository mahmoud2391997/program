using System;
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
string s3 = s1 + " " + s2;
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
var X = 10;
var y = 10;
// Console.WriteLine(X == y); // is X equal to y? => true
//Expression 1+2+3
var z = X == y;
Console.WriteLine(z);
var total = 1000;
var vipThreshold = 900;
var isVip = total >= vipThreshold; // > , < , <=
Console.WriteLine(isVip);
isVip = !true;
Console.WriteLine(isVip);
// && ||
//logical and &&
Console.WriteLine(true && true);
Console.WriteLine(true && false);
Console.WriteLine(false && true);
Console.WriteLine(false && false);

//logical or !!
Console.WriteLine(true || true);
Console.WriteLine(true || false);
Console.WriteLine(false || true);
Console.WriteLine(false || false);

//logical xor
Console.WriteLine(true ^ true);
Console.WriteLine(true ^ false);
Console.WriteLine(false ^ true);
Console.WriteLine(false ^ false);
var isFirstFive = true;
var GPA = 3.5;
var isElegibleToScholarship = GPA >= 3.5 && isFirstFive;
var isFirstFive2 = true;
var GPA2 = 3.4;
var isElegibleToScholarship2 = GPA2 >= 3.5 || isFirstFive2;
Console.WriteLine(isElegibleToScholarship);
Console.WriteLine(isElegibleToScholarship2);
Console.WriteLine(true & true);
Console.WriteLine(true & false);
Console.WriteLine(false & true);
Console.WriteLine(false & false);
bool value =  Check() || true;
var A = 1;
var B = 2;
var C = x == y;
Console.WriteLine(C);
var v1 = "hello";
var v2 = "hello";
var v3 = v1 == v2;
Console.WriteLine(v3);
var totalPurchases = 900;
var VipThreshold = 1000;
var Vip =total >= vipThreshold ? true : false;
var discount = total >= vipThreshold ?"0.05%" : "0.0%";
Console.WriteLine(discount);
Console.ReadKey();
static bool Check()
{
    Console.WriteLine("checking...");
    return true;
}
