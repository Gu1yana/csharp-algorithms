﻿//string username = "Admin", password = "Admin123";
//if (username == "Admin" && password == "Admin123")
//{
//    Console.WriteLine("Xosh gelmisiniz!");
//}
//else
//{
//    Console.WriteLine("username ve ya password yanlishdir");
//}


//int eded = 36;
//if (eded == 0)
//{
//    Console.WriteLine("eded sifirdir");
//}
//else if (eded % 2 == 0)
//{
//    Console.WriteLine("eded cutdur");
//}
//else
//{
//    Console.WriteLine("eded tekdir");
//}


//int num1 = 13, num2 = 14;
//int cem = num1 + num2;

//if (num1 % 2 == 0 && num2 % 2 == 0)

//{
//    Console.WriteLine($"ededlerin cemi: {cem}");
//}
//else
//{
//    Console.WriteLine("daxil olunan ededler cut olmalidir");
//}


//int bal = 66;
//if (bal > 90 && bal <= 100)
//{
//    Console.WriteLine("A");
//}
//if (bal > 80 && bal <= 90)
//{
//    Console.WriteLine("B");
//}
//if (bal > 70 && bal <= 80)
//{
//    Console.WriteLine("C");
//}
//else
//{
//    Console.WriteLine("Kesilmisiniz ;( ");
//}



//int A = 125, B = 95, C = 10;
//int cem = 0;
//if (A % 5 == 0)
//{
//    cem += A;
//}
//if (B % 5 == 0)
//{
//    cem += B;
//}
//if (C % 5 == 0)
//{
//    cem += C;
//}
//if (cem == 0)
//{
//    Console.WriteLine("ededler 5e qaliqsiz bolunmur");
//}
//else
//{
//    Console.WriteLine($"cem: {cem}");
//}


//int eded = 72;
//int b = eded;
//int a;
//eded %= 10;
//a = (b - eded) / 10;

//if (a > eded)
//{
//    Console.WriteLine("onluq mertebesi boyukdur");
//}
//else
//{
//    Console.WriteLine("teklik mertebesi boyukdur");
//}


//int x = 0, y = 1, n = 10, z;
//Console.WriteLine(x);
//Console.WriteLine(y);
//for (int i = 1; i < n; i++)
//{
//    z = y;
//    y += x;
//    x = z;
//    Console.WriteLine(y);
//}


//int[] arr = { 5, 8, 9, 1, 4, 3 };
//int sum = 0;


//for (int i = 0; i < arr.Length; i++)
//{
//    sum += arr[i];
//}
//Console.WriteLine(sum);


//int[] arr = { 11, 2, 9, 21, 81, 3 };

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 == 0)
//    {
//        Console.WriteLine(arr[i]);
//    }

//}


//int[] numbers = { 6, 4, 6, 14, 9, 12 };
//int sum = 0;

//for (int i = 0; i < numbers.Length; i++)
//{
//    sum += numbers[i];
//}
//   int average = sum / numbers.Length;
//   Console.WriteLine($"EDEDI ORTA:{average}");


//int[] arr = { 11, 2, 9, 21, 81, 3 };

//for (int i = arr.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine(arr[i]);
//}


//int[] arr = { 204, 7, 82, 91, 100, 3, 1 };
//int max = arr[0];

//for (int i = 1; i < arr.Length; i++)
//{
//    if (arr[i] > max)
//    {
//        max = arr[i];
//    }
//}
//Console.WriteLine(max);



int num = Convert.ToInt32(Console.ReadLine());
int max = 0;
int x;

while (num > 0)
{
    x = num % 10;
    if (x > max)
    {
        max = x;
    }
    num /= 10;
}
Console.WriteLine(max);