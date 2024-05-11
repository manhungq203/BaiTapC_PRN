// Bai 1
//Console.WriteLine("Hello : Nguyen Manh Hung ");

//bai 2
//int soThuNhat = 10;
//int soThuHai = 20;
//Console.WriteLine($"Sum : {soThuNhat + soThuHai}");

//Bai 3
//int soChia = 30;
//int soBiChia = 5;
//Console.WriteLine($"Dividing : {soChia/soBiChia}");

//Bai 4
//Console.WriteLine(-1+(4*6));
//Console.WriteLine((35 + 5) % 7);
//Console.WriteLine(14 + ((-4 * 6) / 11));
//Console.WriteLine(2 + (15 / (6 * 1)) - 7 % 2);

//Bai 5
//Console.Write("Input the First Number : ");
//int so1 = int.Parse(Console.ReadLine());
//Console.Write("Input the Second Number : ");
//int so2 = int.Parse(Console.ReadLine());
//so1 = so1 + so2;
//so2 = so1 - so2;
//so1 = so1 - so2;
//Console.WriteLine("After Swapping : ");
//Console.WriteLine($"First Number : {so1}");
//Console.WriteLine($"Second Number : {so2}");

//Bai 6
//Console.Write("Input the First Number : ");
//int so1 = int.Parse(Console.ReadLine());
//Console.Write("Input the Secord Number : ");
//int so2 = int.Parse(Console.ReadLine());
//Console.Write("Input the Third Number : ");
//int so3 = int.Parse(Console.ReadLine());
//Console.WriteLine($"Expected Output: {so1*so2*so3}");

//Bai 7
//Console.Write("Input first number : ");
//int so1 = int.Parse(Console.ReadLine());
//Console.Write("Input secord number : ");
//int so2 = int.Parse(Console.ReadLine());
//Console.WriteLine($"{so1} + {so2} = {so1+so2}");
//Console.WriteLine($"{so1} - {so2} = {so1 - so2}");
//Console.WriteLine($"{so1} X {so2} = {so1 * so2}");
//if(so2 == 0)
//{
//    Console.WriteLine("Can't divide/mod by 0");
//}
//else
//{
//    Console.WriteLine($"{so1} / {so2} = {so1 / so2}");
//    Console.WriteLine($"{so1} mod {so2} = {so1 % so2}");
//}

//Bai 8
//Console.Write("Enter the number: ");
//int n = int.Parse(Console.ReadLine());
//for(int i = 0; i <= 10; i++)
//{
//    Console.WriteLine($"{n} * {i} = {n*i}");
//}

//Bai 9
//Console.Write("Input first number : ");
//int so1 = int.Parse(Console.ReadLine());
//Console.Write("Input secord number : ");
//int so2 = int.Parse(Console.ReadLine());
//Console.Write("Input third number : ");
//int so3 = int.Parse(Console.ReadLine());
//Console.Write("Input four number : ");
//int so4 = int.Parse(Console.ReadLine());
//Console.WriteLine($"The average of {so1} , {so2}, {so3} , {so4} is:  {(so1+so2+so3+so4)/4}");

//Bai 10
//Console.Write("Input first number : ");
//int so1 = int.Parse(Console.ReadLine());
//Console.Write("Input secord number : ");
//int so2 = int.Parse(Console.ReadLine());
//Console.Write("Input third number : ");
//int so3 = int.Parse(Console.ReadLine());
//Console.WriteLine($"Result of specified numbers {so1}, {so2} and {so3}, (x+y).z is {(so1+so2)*so3} and x.y + y.z is {(so1*so2) + (so2 * so3)}");

//Bai 11
//Console.Write ("Enter your age : ");
//int age = int.Parse (Console.ReadLine ());
//if(age > 25)
//{
//    Console.WriteLine("You look older than 25");
//}
//else
//{
//    Console.WriteLine("You look younger than 25");
//}

//Bai 12
//Console.Write("Enter a digit: ");
//int number = int.Parse(Console.ReadLine());
//for (int i = 0; i < 2; i++)
//{
//    for (int x = 0; x < 4; x++)
//    {
//        Console.Write($"{number} ");
//    }
//    Console.WriteLine();
//    for (int y = 0; y < 4; y++)
//    {
//        Console.Write($"{number}");
//    }
//    Console.WriteLine();
//}

//Bai 13
//Console.Write("Enter a number : ");
//int number = int.Parse(Console.ReadLine()); 
//for (int i = 0; i < 5; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        if (i == 0 || j == 0 || j == 2 || i == 4)
//        {
//            Console.Write(number);
//        }
//        else
//        {
//            Console.Write(" ");
//        }
//    }
//    Console.WriteLine();
//}

//Bai 14
//Console.Write("Enter the amount of celsius: ");
//float c = float.Parse(Console.ReadLine());
//Console.WriteLine($"Kelvin = {c + 273}");
//Console.WriteLine($"Fahrenheit = {c * 18 / 10 + 32}");

//Bai 15
//Console.WriteLine("Test data : ");
//string s = "NguyenManhHung";
//Console.WriteLine(s);
//// remove char at index 1
//Console.WriteLine(s.Remove(1,1));
//// remove char at index 1
//Console.WriteLine(s.Remove(4, 1));
//// remove char at index 1
//Console.WriteLine(s.Remove(5, 1));

//Bai 16
//Console.WriteLine("Test data: ");
//string s = "NguyenManhHung";
//Console.WriteLine(s);
//List<char> cs = s.ToList();
//Console.WriteLine("Output: ");
//Console.Write(cs[cs.Count - 1]);
//for (int i = 1; i < cs.Count - 1; i++)
//{
//    Console.Write(cs[i]);
//}
//Console.WriteLine(cs[0]);

//Bai 17 
//Console.WriteLine("Test data: ");
//string s = "NguyenManhHung";
//Console.WriteLine(s);
//Console.WriteLine(s.ToCharArray()[0]+s+ s.ToCharArray()[0]);

//Bai 18
//Console.Write("Input first number : ");
//int so1 = int.Parse(Console.ReadLine());
//Console.Write("Input secord number : ");
//int so2 = int.Parse(Console.ReadLine());
//int n = so1 * so2;
//if(n < 0)
//{
//    Console.WriteLine("True");
//}
//else
//{
//    Console.WriteLine("False");
//}

//Bai 19
//Console.Write("Input first number : ");
//int so1 = int.Parse(Console.ReadLine());
//Console.Write("Input secord number : ");
//int so2 = int.Parse(Console.ReadLine());
//if(so1 != so2)
//{
//    Console.WriteLine($"Output = {so1 + so2}");
//}
//else
//{
//    Console.WriteLine($"Output = {(so1 + so2)*3}");
//}

//Bai 20
//Console.Write("Input first number : ");
//int so1 = int.Parse(Console.ReadLine());
//Console.Write("Input secord number : ");
//int so2 = int.Parse(Console.ReadLine());
//int output = (so1 > so2)? 2*(so1 - so2) : so2 - so1;
//Console.WriteLine($"Output = {output}  ");

//Bai 21
//Console.Write("Input first number : ");
//int so1 = int.Parse(Console.ReadLine());
//Console.Write("Input secord number : ");
//int so2 = int.Parse(Console.ReadLine());
//string output = (so1 == 20 || so2 == 20 || (so1+so2) == 20) ? "True" : "False";
//Console.Write(output);

//Bai 22
//Console.Write("Input a number : ");
//int so1 = int.Parse(Console.ReadLine());
//string output = ((so1 <=120 && so1 >=80)||(so1 <= 220 && so1 >= 180)) ? "True" : "False";
//Console.Write(output);

//Bai 23
//Console.WriteLine("Test data: ");
//string s = "Nguyen Manh Hung";
//Console.WriteLine(s);
//Console.WriteLine(s.ToLower());

//bai 24
//string data = "Nguyen Manh Hung HE172300";
//string[] words = data.Split(' ');
//int max = words[0].Length;
//string maxWord = words[0];
//foreach (string word in words)
//{
//    if (word.Length >= max)
//    {
//        maxWord = word;
//    }
//}
//Console.WriteLine(maxWord);

//Bai 25
//for(int i =1; i<100; i+=2)
//{
//    Console.WriteLine(i);
//}

//Bai 26
//int numofPricenum = 1;
//int num = 3, sum = 2; 
//while (numofPricenum != 500)
//{
//    bool check = true;
//    int x = (int)Math.Floor(Math.Sqrt(num));
//    for (int i = 2; i <= x; ++i)
//    {
//        if (num % i == 0) check = false;
//    }

//    if (check)
//    {
//        sum += num;
//        numofPricenum++;
//    }
//    num++;
//}
//Console.WriteLine(sum);

//Bai 27
//Console.Write("Enter a number: ");
//int num = int.Parse(Console.ReadLine());
//int chuso;
//int sum = 0;
//while(num != 0)
//{
//    chuso = num%10;
//    sum += chuso;
//    num/=10;
//}
//Console.WriteLine(sum);

//bai 28
//string datatest = "Nguyen Manh Hung Vip 999";
//string[] words = datatest.Split(' ');
//foreach (string word in words.Reverse())
//{
//    Console.Write(word+" ");
//}

//bai 30
//string hexval = "4B0";
//Console.WriteLine("Hexadecimal number: " + hexval);
//int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
//Console.WriteLine("Convert to-");
//Console.WriteLine("Decimal number: " + decValue);

//bai 31
//int[] first_array = { 1, 3, -5, 4 };
//int[] second_array = { 1, 4, -5, -2 };
//Console.WriteLine("Array1: { 1, 3, -5, 4 }");
//Console.WriteLine("Array2: { 1, 4, -5, -2 }");

//for (int i = 0; i < first_array.Length; i++)
//{
//    Console.Write(first_array[i] * second_array[i]+", ");
//}

//bai 32
//Console.Write("Input a string : ");
//string data = Console.ReadLine();
//int n = data.Length;
//if(n < 4)
//{
//    Console.WriteLine(data);
//}
//else
//{
//    string output = data.Substring(n-4);
//    Console.WriteLine(output+output+output+output);
//}

//bai 33
//Console.Write("Enter a number : ");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine((num > 0 && (num % 3 == 0 || num % 7 == 0)));

//bai34
//Console.Write("Data: string1 : ");
//string data = Console.ReadLine();
//Console.Write("Enter substring : ");
//string substring = Console.ReadLine();
//Console.WriteLine(substring == data.Substring(0, substring.Length));

//Bai 35
//Console.Write("Input a first number(<100): ");
//int m = int.Parse(Console.ReadLine());
//Console.Write("Input a second number(>200): ");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine((m < 100 && n > 200));

//bai 36
//Console.Write("Input a first number: ");
//int m = int.Parse(Console.ReadLine());
//Console.Write("Input a second number: ");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine(n <= 10 && n >= -10 && m <= 10 && m >= -10);

//bai 37
//string str = "PHP Tutorial";
//Console.WriteLine((str.Substring(1, 2).Equals("HP") ? str.Remove(1, 2) : str));

//Bai 38
//Console.Write("Data test : ");
//string s = Console.ReadLine();
//var result = "";
//if (s[0] == 'P')
//    result += s[0];
//if (s[1] == 'H')
//    result += s[1];
//Console.WriteLine(result);

//Bai 39
//Console.WriteLine("Input first integer:");
//int x = int.Parse(Console.ReadLine());
//Console.WriteLine("Input second integer:");
//int y = int.Parse(Console.ReadLine());
//Console.WriteLine("Input third integer:");
//int z = int.Parse(Console.ReadLine());
//Console.WriteLine("Largest of three: " + Math.Max(x, Math.Max(y, z)));
//Console.WriteLine("Lowest of three: " + Math.Min(x, Math.Min(y, z)));

//Bai 40
//Console.WriteLine("Input first integer:");
//int x = int.Parse(Console.ReadLine());
//Console.WriteLine("Input second integer:");
//int y = int.Parse(Console.ReadLine());
//Console.WriteLine(Math.Abs(20-x) > Math.Abs(20 - y)? y : x);

//Bai 41
//Console.Write("Input a string (contains at least one 'w' char) : ");
//string str = Console.ReadLine();
//int count = 0;
//foreach( char c in str.ToCharArray())
//{
//    if(c == 'w')
//    {
//        count++;
//    }
//}
//Console.WriteLine("Test the string contains 'w' character between 1 and 3 times: ");
//Console.WriteLine(count >= 1 && count <= 3);

////Bai 42
//Console.Write("Input a String : ");
//string str = Console.ReadLine();
//Console.WriteLine((str.Length <= 3)? str.ToUpper() : str);

//bai 43



