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
//Console.Write("Input a string : ");
//string str = Console.ReadLine();
//var ctr = 0;
//for (var i = 0; i < str.Length - 1; i++)
//{
//    if (str[i].Equals('w'))
//        ctr++;
//    if (str.Substring(i, 2).Equals("ww") && ctr > 2)
//        Console.WriteLine("True"); 
//}
//Console.WriteLine("False");

//Bai 44
//Console.Write("Input a string : ");
//string str = Console.ReadLine();

//string output ="";
//for (int i = 0; i < str.Length; i+=2)
//{
//    output += str.ToCharArray()[i];
//}
//Console.WriteLine(output);

//basi 45
//Console.WriteLine("\nInput an integer:");
//int x = Convert.ToInt32(Console.ReadLine());
//int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
//Console.WriteLine("Number of " + x + " present in the said array:");
//Console.WriteLine(nums.Count(n => n == x));

//Bai 46
//Console.WriteLine("Input an integer:");
//int x = int.Parse(Console.ReadLine());
//int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
//Console.WriteLine((nums[0] == x) || (nums[nums.Length - 1] == x));

//Bai 47
//Console.WriteLine("Array1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]");
//int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
//Console.WriteLine(nums.Sum());

//Bai 48
//Console.WriteLine("Input an integer:");
//int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
//Console.WriteLine((nums[0] == nums[nums.Length]);

//Bai 49
//Console.WriteLine("Test Data:\r\nArray1: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1]\r\nArray2: [1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5]");
//int[] nums1 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
//int[] nums2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
//Console.WriteLine((nums1[0] == nums2[0]) || (nums1[nums1.Length - 1] == nums2[nums2.Length - 1]));

//bai 50
//int[] nums = { 1, 2, 8 };
//Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
//Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", nums.Reverse()));

////Bai 51
//int[] nums = { 1, 2, 5, 7, 8 };
//Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
//Console.WriteLine((nums[0] > nums[nums.Length-1])? nums[0]: nums[nums.Length-1]);

//Bai 52
//int[] array1 = { 1, 2, 5 };
//Console.WriteLine("\nArray1: [{0}]", string.Join(", ", array1));
//int[] array2 = { 0, 3, 8 };
//Console.WriteLine("\nArray2: [{0}]", string.Join(", ", array2));
//int[] array3 = { -1, 0, 2 };
//Console.WriteLine("\nArray3: [{0}]", string.Join(", ", array3));
//int[] new_array = { array1[1], array2[1], array3[1] };
//Console.WriteLine("\nNew array: [{0}]", string.Join(", ", new_array));

//bai 53
//int[] nums = { 2, 4, 7, 8, 6 };
//Console.WriteLine("\nOriginal array: [{0}]", string.Join(", ", nums));
//bool check = false;
//foreach (int i in nums)
//{
//    if(i%2==1) check = true;
//}
//Console.WriteLine(check);

//bai 54
//Console.Write("Enter a year: ");
//int year = int.Parse(Console.ReadLine());
//Console.WriteLine((int)(year / 100) + ((year % 100 == 0) ? 0 : 1));

//bai 55
//Console.WriteLine("Data test { 2, 4, 2, 6, 9, 3 } , max = 27");
//int[] input_array = { 2, 4, 2, 6, 9, 3 };
//int array_index = 0;
//int product = input_array[array_index] * input_array[array_index + 1];
//array_index++;
//while (array_index + 1 < input_array.Length)
//{
//    product = ((input_array[array_index] * input_array[array_index + 1]) > product) ?
//               (input_array[array_index] * input_array[array_index + 1]) :
//                product;
//    array_index++;
//}
//Console.WriteLine(product);

//bai 56
//Console.WriteLine("enter a string:");
//string str = "";
//str = Console.ReadLine();
//char[] c1 = str.ToCharArray();
//Array.Reverse(c1);
//Console.WriteLine(str.Equals(new string(c1)));

// bai 57
//Console.WriteLine("Data test { 2, 4, 2, 6, 9, 3 }");
//int[] input_Array = { 2, 4, 2, 6, 9, 3 };
//int max = input_Array[0] * input_Array[1];
//for (int x = 1; x <= input_Array.Length - 2; x++)
//{
//    max = Math.Max(max, input_Array[x] * input_Array[x + 1]);
//}
//Console.WriteLine(max);

//bai 58
//Console.WriteLine("Data test { 1, 4, 5, 6, 10, 3 }");
//int[] input_Array = { 1, 4, 5, 6, 10, 3 };
//Array.Sort(input_Array);
//Console.WriteLine("\nArray1: [{0}]", string.Join(", ", input_Array));
//Console.WriteLine((input_Array[input_Array.Length - 1] - input_Array[0] - 1) - (input_Array.Length - 2));

//bai 59
//Console.WriteLine("Data test { 1, 4, 5, 6, 10, 3 }");
//int[] input_Array = { 1, 4, 5, 6, 10,3 };
//Array.Sort(input_Array);
//bool check = true;
//for (int i = 0; i < input_Array.Length - 1; i++)
//{
//    if (input_Array[i] == input_Array[i + 1])
//    {
//       check = false;
//    }

//}
//Console.WriteLine(check);

//bai 60
//int[][] a = {
//                new int[]{0, 2, 3, 2},
//                new int[]{0, 6, 0, 1},
//                new int[]{4, 0, 3, 0}
//            };
//Console.WriteLine("matrix =\r\n[0, 2, 3, 2],\r\n[0, 6, 0, 1],\r\n[4, 0, 3, 0]]");
//int sum = 0;
//for (int i = 0; i < a[0].Length; i++)
//{
//    sum += a[0][i];
//}
//for (int i = 1; i < a.Length; i++)
//{
//    for (int j = 0; j < a[i].Length; j++)
//    {
//        if (a[i-1][j] != 0)
//        {
//            sum+= a[i][j];
//        }
//    }
//}
//Console.WriteLine(sum);

//bai 63
//int[] nums = { 1, 3, 5, 7, 9 };
//int n = 6;
//Console.WriteLine(nums.Contains(n));
//n = 3;
//Console.WriteLine(nums.Contains(n));

//bai 64
//string file_path;
//file_path = "c:/csharp/ex/test.cpp";
//Console.WriteLine(file_path.Split('/').Last());
//file_path = "c:/movies/abc.mp4";
//Console.WriteLine(file_path.Split('/').Last());
//file_path = "test.txt";
//Console.WriteLine(file_path.Split('/').Last());

//bai 65
//Console.WriteLine("{ 1, 3, 5, 7, 9 }");
//int[] nums = { 1, 3, 5, 7, 9 };
//int[] result = nums.Select(x => x*nums.Length).ToArray();
//foreach (var item in result)
//{
//    Console.Write(item+", ");
//}

//Bai 66
//string so1 = "30", so2 = "45";
//Console.WriteLine((int.Parse(so1) < int.Parse(so2) ? so1 : so2));

//bai 67
//string str = "Nguyen Manh Hung";
//Console.WriteLine(str.Replace("P", "9").Replace("T", "0").Replace("S", "1").Replace("H", "6").Replace("A", "8"));

//bai 69
//string str1 = "Nguyen Manh Hung";

//Console.WriteLine(str1 == str1.ToUpper() || str1 == str1.ToLower());

//str1 = "NGUYEN MANH HUNG";

//Console.WriteLine(str1 == str1.ToUpper() || str1 == str1.ToLower());

//str1 = "nguyen manh hung";

//Console.WriteLine(str1 == str1.ToUpper() || str1 == str1.ToLower());

// Bai 70
//string str = "Nguyen Manh Hung";
//Console.WriteLine("after remove first element and last element: ");
//string output = str.Substring(1, str.Length-2);
//Console.WriteLine(output);

//Bai 71

//string str = "Nguyen Manh Huung";
//bool check = false;
//for (int i = 0; i < str.Length - 1; i++)
//{
//    if (str[i] == str[i + 1])
//    {
//        check =  true;
//    }
//}
//Console.WriteLine(check);

//bai 72
//Console.WriteLine("nums = { 1, 2, 3, 5, 4, 2, 3, 4 }");
//int[] nums = { 1, 2, 3, 5, 4, 2, 6, 4 };
//double avg = nums.Average();
//Console.WriteLine(avg);
//Console.WriteLine((avg == ((int)avg))? true : false);

// bai 73
//string str = "nguyenmanhhung";
//char[] str2 = str.ToCharArray();
//Array.Sort(str2);
//Console.WriteLine(new string(str2));

//bai 74
//Action<string> lengthCheck = (str) =>
//{
//    Console.WriteLine(str.Length % 2 == 0 ? "even length" : "odd length");
//};

//string inputString = "nguyenmanhhung";
//lengthCheck(inputString);

//bai 75
//Func<int, int> old = (int i) =>
//{
//    return i * 2 - 1;
//};
//Console.WriteLine("1st odd number: " + old(1));
//Console.WriteLine("2nd odd number: " + old(2));
//Console.WriteLine("4th odd number: " + old(4));
//Console.WriteLine("100th odd number: " + old(100));


//bai 76
//Func<char, int> test = (c) => {
//    return (int)c;
//};

//Console.WriteLine("Ascii value of 1 is: " + test('1'));
//Console.WriteLine("Ascii value of A is: " + test('A'));
//Console.WriteLine("Ascii value of a is: " + test('a'));
//Console.WriteLine("Ascii value of # is: " + test('#'));

// bai 77
//Func<string, bool> test = (s) =>
//{
//    return s.EndsWith("s");
//};

//Console.WriteLine("Is 'Exercise' plural? " + test("Exercise"));
//Console.WriteLine("Is 'Exercises' plural? " + test("Exercises"));
//Console.WriteLine("Is 'Books' plural? " + test("Books"));
//Console.WriteLine("Is 'Book' plural? " + test("Book"));

//bai 78
//Func<int[], int> test = (int[] a) =>
//{
//    return a.Sum(b => b * b);
//};
//int[] nums = { 1, 2, 3 };
//Console.WriteLine("{ 1, 2, 3 }");
//Console.WriteLine("Sum of squares of elements of the said array: " + test(nums));

//int[] nums1 = { -2, 0, 3, 4 };
//Console.WriteLine("{ -2, 0, 3, 4 }");
//Console.WriteLine("Sum of squares of elements of the said array: " + test(nums1));

//bai 80

//object[] mixedArray = new object[5];
//mixedArray[0] = 25; 
//mixedArray[1] = "Anna";
//mixedArray[2] = false; 
//mixedArray[3] = System.DateTime.Now; 
//mixedArray[4] = 112.22; 


//Console.WriteLine("Printing original array elements and their types:");
//for (int i = 0; i < mixedArray.Length; i++)
//{
//    Console.WriteLine("Value-> " + mixedArray[i] + " :: Type-> " + mixedArray[i].GetType());
//}
//Console.WriteLine("mixed values to string values :");
//for (int i = 0; i < mixedArray.Length; i++)
//{
//    Console.WriteLine("Value-> " + mixedArray[i] + " :: Type-> " + mixedArray[i].ToString());
//}

//bai 81
//Console.WriteLine("Enter a number : ");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine((int)(num / 10) >= num % 10);

// bai 82
//Func<string, string> test = (s) =>
//{
//    return Regex.Replace(s, @"[^a-zA-Z]", "");
//};

//string text;

//text = "Py@th12on";
//Console.WriteLine("Orginal string: " + text);
//Console.WriteLine("Remove all characters from the said string which are non-letters: " + test(text));

//text = "Python 3.0";
//Console.WriteLine("\nOrginal string: " + text);
//Console.WriteLine("Remove all characters from the said string which are non-letters: " + test(text));

//text = "2^sdfds*^*^jlljdslfnoswje34u230sdfds984";
//Console.WriteLine("\nOrginal string: " + text);
//Console.WriteLine("Remove all characters from the said string which are non-letters: " + test(text));

//bai 83

//Func<string, string> test = (s) =>
//{
//    return new Regex(@"[aeiouAEIOU]").Replace(s, "");
//};

//string text = "";

//text = "Python";
//Console.WriteLine("Orginal string: " + text);
//Console.WriteLine("After removing all the vowels from the said string: " + test(text));

//text = "C Sharp";
//Console.WriteLine("\nOrginal string: " + text);
//Console.WriteLine("After removing all the vowels from the said string: " + test(text));

//text = "JavaScript";
//Console.WriteLine("\nOrginal string: " + text);
//Console.WriteLine("After removing all the vowels from the said string: " + test(text));

//bai 84
//string str = "Nguyen Manh Hung";
//char[] str2 = str.ToCharArray();
//int[] output = new int[str2.Length];
//int count = 0;
//for (int i = 0; i < str2.Length - 1; i++)
//{
//    if (str2[i] >= 'a' && str2[i] <= 'z')
//    {
//        output[count++] = i;
//    }
//}
//foreach(int i in output)
//{
//    if (i != 0)
//    {
//        Console.Write(i + ", ");
//    }
//}

//bai 85
//Func<double[], double[]> test = (a) =>
//{
//    double[] x = new double[a.Length];
//    double sum = 0;
//    for (int i = 0; i < a.Length; i++)
//    {
//        sum += a[i];
//        x[i] = sum;
//    }
//    return x;
//};
//double[] nums = { 1, 3, 4, 5, 6, 7 };
//Console.WriteLine("\nOrginal Array elements: ");
//foreach (var item in nums)
//{
//    Console.Write(item.ToString() + " ");
//}

//Console.WriteLine("\nCumulative sum of the said array elements:");
//double[] result = test(nums);
//foreach (var item in result)
//{
//    Console.Write(item.ToString() + " ");
//}

//double[] nums1 = { 1.2, -3, 4.1, 6, -5.47 };

//Console.WriteLine("\nOrginal Array elements: ");
//foreach (var item in nums1)
//{
//    Console.Write(item.ToString() + " ");
//}
//Console.WriteLine("\nCumulative sum of the said array elements:");
//double[] result1 = test(nums1);
//foreach (var item in result1)
//{
//    Console.Write(item.ToString() + " ");
//}

//bai 86
//Func<string, int> letter = (s) =>
//{
//    int n = 0;
//    char[] c = s.ToCharArray();
//    foreach (char c2 in c)
//    {
//        if(((int)c2 >= 'a' &&  (int)c2 <='z')|| ((int)c2 >= 'A' && (int)c2 <= 'Z'))
//        { n++; }
//    }
//    return n;
//};

//Func<string, int> digit = (s) =>
//{
//    int n = 0;
//    char[] c = s.ToCharArray();
//    foreach (char c2 in c)
//    {
//        if (((int)c2 >= '0' && (int)c2 <= '9'))
//        { n++; }
//    }
//    return n;
//};

//string test = "Hung vip 999";
//Console.WriteLine("Data test : "+test);
//Console.WriteLine("Number of letters: " + letter(test));
//Console.WriteLine("Number of digits : " + digit(test));

//bai 87
//bool test1 = true;
//bool test2 = false;
//Console.WriteLine("origin test 1 : "+ test1);
//Console.WriteLine("origin test 2 : "+ test2);
//Console.WriteLine("reverse of test 1 : "+ !test1);
//Console.WriteLine("reverse of test 2 : "+ !test2 );

//bai 88
//Func<int, int> test = (num) => 180 * (num - 2);

//Console.WriteLine("Input number of straight lines of the polygon:");
//int n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Sum of the interior angles (in degrees) of the said polygon: " + test(n));

//bai 89
//Func<int[], string> test = (a) =>
//{
//    int pos = 0, neg = 0;
//    foreach (var x in a)
//    {
//        if (x < 0) { neg++; } else if(x>0) {  pos++; }
//    }
//    return $"\nNumber of positive num: {pos}\nNumber of negative num: {neg}";
//};

//int[] nums = { 10, -11, 12, -13, 14, -18, 19, -20 };
//Console.WriteLine("Original Array elements:");
//foreach (var item in nums)
//{
//    Console.Write(item.ToString() + " ");
//}

//Console.WriteLine(test(nums));

//int[] nums1 = { -4, -3, -2, 0, 3, 5, 6, 2, 6 };

//Console.WriteLine("\nOriginal Array elements:");
//foreach (var item in nums1)
//{
//    Console.Write(item.ToString() + " ");
//}

//Console.WriteLine(test(nums1));

//int[] nums2 = { };

//Console.WriteLine("\nOriginal Array elements:");
//foreach (var item in nums2)
//{
//    Console.Write(item.ToString() + " ");
//}

//Console.WriteLine(test(nums2));

//bai 90
//Func<int, string> test = num =>
//{
//    string numB = Convert.ToString(num, 2);
//    int one = numB.Count(x => x == '1');
//    int zero = numB.Count(x => x == '0');
//    Console.WriteLine("After conver: "+numB);
//    return $"\nNumber of 1 in {num} :{one}\nNumber of 0 in {num} :{zero}";
//};

//int num;
//num = 12;
//Console.WriteLine("origin num: "+ num);
//Console.WriteLine(test(num));

//num = 24;
//Console.WriteLine("origin num: " + num);
//Console.WriteLine(test(num));

//bai 91
//Func<object[], int[]> test = o =>
//{
//    return o.OfType<int>().ToArray();
//};

//object[] mixedArray = new object[6];
//mixedArray[0] = 25;
//mixedArray[1] = "Anna";
//mixedArray[2] = false;
//mixedArray[3] = System.DateTime.Now;
//mixedArray[4] = -112;
//mixedArray[5] = -34.67;

//Console.WriteLine("Original array elements:");
//for (int i = 0; i < mixedArray.Length; i++)
//{
//    Console.Write(mixedArray[i] + " ");
//}

//int[] new_nums = test(mixedArray);

//Console.WriteLine("\n\nAfter removing all the values except integer values from the said array of mixed values:");
//for (int i = 0; i < new_nums.Length; i++)
//{
//    Console.Write(new_nums[i] + " ");
//}

//bai 92
//Func<int, bool> isPrice = num =>
//{
//    if (num == 2)
//    {
//        return true;
//    }
//    for (int i = 2; i<= Math.Sqrt(num); i++)
//    {
//        if(num%i == 0)
//        {
//            return false;
//        }
//    }
//    return true;

//};
//Func<int, int> nextPrice = a => {
//    if (isPrice(a))
//    {
//        return a;
//    }
//    while (true)
//    {
//        a++;
//        if (isPrice(a))
//        {
//            return a;
//        }
//    };
//};

//int num;
//Console.Write("Enter number : ");
//num = int.Parse(Console.ReadLine());
//Console.WriteLine($"Next price number of {num} is " + nextPrice(num));

//bai 93
//int num;
//Console.Write("Enter a number: ");
//num = 120;
//Console.WriteLine($"({num}) -> "+ (int)Math.Sqrt(num)) ;

//Console.Write("Enter a number: ");
//num = 225;
//Console.WriteLine($"({num}) -> " + (int)Math.Sqrt(num));

//Console.Write("Enter a number: ");
//num = 335;
//Console.WriteLine($"({num}) -> " + (int)Math.Sqrt(num));

//bai 94

//Func<string[], string> test = o =>
//{
//    for (int i = 0; i < o[0].Length; i++)
//    {
//        char currentChar = o[0][i];
//        for (int j = 1; j < o.Length; j++)
//        {
//            if (i >= o[j].Length || o[j][i] != currentChar)
//            {
//                return o[0].Substring(0, i);
//            }
//        }
//    }
//    return o[0]; 
//};

//string[] arr_strings1 = { "Padas", "Packed", "Pace", "Pacha" };
//Console.WriteLine("Original strings: " + $"{string.Join(", ", arr_strings1)}");
//Console.WriteLine("Longest common prefix from the said array of strings: " + test(arr_strings1));

//string[] arr_strings2 = { "Jacket", "Joint", "Junky", "Jet" };
//Console.WriteLine("\nOriginal strings: " + $"{string.Join(", ", arr_strings2)}");
//Console.WriteLine("Longest common prefix from the said array of strings: " + test(arr_strings2));

//string[] arr_strings3 = { "Bort", "Whang", "Yarder", "Zoonic" };
//Console.WriteLine("\nOriginal strings: " + $"{string.Join(", ", arr_strings3)}");
//Console.WriteLine("Longest common prefix from the said array of strings: " + test(arr_strings3));

//bai 96
//Func<string, bool> test = str =>
//{
//    char[] cha = str.ToCharArray(); 
//    for (int i = 0; i < cha.Length-2; i++)
//    {
//        if (cha[i] != cha[i + 1])
//        {
//            return false;
//        }
//    }
//    return true;
//};

//string text = "aaa";
//Console.WriteLine("Original string: " + text);
//Console.WriteLine("Check whether all the characters in the said string are same or not! " + test(text));

//text = "abcd";
//Console.WriteLine("Original string: " + text);
//Console.WriteLine("Check whether all the characters in the said string are same or not! " + test(text));

//text = "3333";
//Console.WriteLine("Original string: " + text);
//Console.WriteLine("Check whether all the characters in the said string are same or not! " + test(text));

//text = "2342342";
//Console.WriteLine("Original string: " + text);
//Console.WriteLine("Check whether all the characters in the said string are same or not! " + test(text));

// bai 97
//Func<string, bool> test = str =>
//{
//    double Result = 0; 
//    return double.TryParse(str, out Result);
//};

//string text = "123";
//Console.WriteLine("Original string: " + text);
//Console.WriteLine("Check if the said string is numeric or not! " + test(text));

//text = "123.33";
//Console.WriteLine("Original string: " + text);
//Console.WriteLine("Check if the said string is numeric or not! " + test(text));

//text = "33/33";
//Console.WriteLine("Original string: " + text);
//Console.WriteLine("Check if the said string is numeric or not! " + test(text));

//text = "234234d2";
//Console.WriteLine("Original string: " + text);
//Console.WriteLine("Check if the said string is numeric or not! " + test(text));

//bai 98
//Func<int, bool> isPrice = num =>
//{
//    if (num == 2)
//    {
//        return true;
//    }
//    for (int i = 2; i <= Math.Sqrt(num); i++)
//    {
//        if (num % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//};

//Func<int, bool> isDescending = num =>
//{
//    if (num < 10)
//        return true;

//    int lastDigit = num % 10;
//    num /= 10;

//    while (num > 0)
//    {
//        int nextDigit = num % 10;
//        if (nextDigit < lastDigit)
//            return false;

//        lastDigit = nextDigit;
//        num /= 10;
//    }
//    return true;
//};
//int num = 2;
//int[] output = new int[999];
//int i = 0;
//while (num <= 9999999)
//{
//    if (isDescending(num) && isPrice(num))
//    {
//        output[i] = num;
//        i++;
//        if (i == 999) break;
//    }
//    num++;
//}
//for (int j = 0; j < output.Length; j++)
//{

//        if (output[j] != 0)
//        {
//            Console.Write($"{output[j],10}");
//        }
//    if(j%5 == 0 )
//    Console.WriteLine();
//}

//bai 99
//Func<int, bool> isPrice = num =>
//{
//    if (num == 2)
//    {
//        return true;
//    }
//    for (int i = 2; i <= Math.Sqrt(num); i++)
//    {
//        if (num % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//};

//Func<int, bool> isInce = num =>
//{
//    if (num < 10)
//        return true;

//    int lastDigit = num % 10;
//    num /= 10;

//    while (num > 0)
//    {
//        int nextDigit = num % 10;
//        if (nextDigit > lastDigit)
//            return false;

//        lastDigit = nextDigit;
//        num /= 10;
//    }
//    return true;
//};
//int num = 2;
//int[] output = new int[999];
//int i = 0;
//while (num <= 9999999)
//{
//    if (isInce(num) && isPrice(num))
//    {
//        output[i] = num;
//        i++;
//        if (i == 999) break;
//    }
//    num++;
//}
//for (int j = 0; j < output.Length; j++)
//{

//    if (output[j] != 0)
//    {
//        Console.Write($"{output[j],10}");
//    }
//    if (j % 5 == 0)
//        Console.WriteLine();
//}

//bai 100
//Func<object, object, bool> test = (x, y) =>
//{
//    if (!x.Equals(y))
//    {
//        return false;
//    }

//    // Check if the objects are of the same type
//    if (!x.GetType().Equals(y.GetType()))
//    {
//        return false;
//    }

//    // If both checks pass, return true
//    return true;
//};

//string text1 = "AAA";
//string text2 = "BBB";
//Console.WriteLine("Original values: " + text1 + ", " + text2);
//Console.WriteLine("Check the equality of the said values: " + test(text1, text2));

//Boolean v1 = true;
//Boolean v2 = false;
//Console.WriteLine("Original values: " + v1 + ", " + v2);
//Console.WriteLine("Check the equality of the said values: " + test(v1, v2));

//// Here, the code seems to have a typo in the output statements (v1, v2) are used instead of (v1, text3)
//// Corrected the output statement below:
//Boolean v3 = true;
//string text3 = "true";
//Console.WriteLine("Original values: " + v1 + ", " + text3);
//Console.WriteLine("Check the equality of the said values: " + test(v1, text3));

//int n1 = 10;
//int n2 = 10;
//Console.WriteLine("Original values: " + n1 + ", " + n2);
//Console.WriteLine("Check the equality of the said values: " + test(n1, n2));

//bai 102

//Console.WriteLine("Enter a number: ");
//int num = int.Parse(Console.ReadLine());

//int[][] output = new int[num][];
//for (int i = 0; i < num; i++)
//{
//    output[i] = new int[num];
//}
//for (int i = 0; i < num-1; i++)
//{
//    for (int j = 0; j < num-1; j++)
//    {
//        if (i == j)
//        {
//            output[i][j] = 1;
//        }
//        else
//        {
//            output[i][j] = 0;
//        }
//    }
//}
//for (int i = 0; i < num - 1; i++)
//{
//    for (int j = 0; j < num - 1; j++)
//    {
//        Console.Write($"[{output[i][j] }]");
//    }
//    Console.WriteLine();
//}

// bai 103
//Func<string, string> test = str =>
//{
//    char[] chars = str.ToCharArray();

//    // Sort the character array
//    Array.Sort(chars);

//    // Convert the sorted character array back to a string
//    string sortedString = new string(chars);

//    return sortedString;
//};

//string text = "AAAbfed231";
//Console.WriteLine("Original string: " + text);
//Console.WriteLine("Sorted string: " + test(text));

//text = " ";
//Console.WriteLine("Original string: " + text);
//Console.WriteLine("Sorted string: " + test(text));

//text = "Python";
//Console.WriteLine("Original string: " + text);
//Console.WriteLine("Sorted string: " + test(text));

//text = "W3resource";
//Console.WriteLine("Original string: " + text);
//Console.WriteLine("Sorted string: " + test(text));

//bai 104
//Func<int, int, int, int> test = (a, b, c) =>
//{
//    int num = 2;
//    if(a == b && c == a)
//    {
//        num = 3;
//    }
//    if(a!= b && c != a && b!= c)
//    {
//        num = 0;
//    }
//    return num;
//};

//int x = 1, y = 2, z = 3;
//Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);
//Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));

//x = 1; y = 3; z = 3;
//Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);
//Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));

//x = 3; y = 3; z = 3;
//Console.WriteLine("Original numbers: " + x + ',' + y + ',' + z);
//Console.WriteLine("Number of equality of the said numbers: " + test(x, y, z));