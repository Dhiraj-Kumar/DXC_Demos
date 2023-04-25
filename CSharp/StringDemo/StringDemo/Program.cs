using System.Text;
//string s = String.Empty;

//string s1 = "";

//string path = @"C:\Folder1\File1.txt";

//string str = "Welcome to CSharp";
//string res = str.Remove(0, 3);
//Console.WriteLine(res);

//string s2 = str.Insert(11, "Microsoft ");
//Console.WriteLine(s2);

//Console.WriteLine(str.Substring(8, 2));

//string s3 = null;
//s3 = String.Empty;

//string name = "John";
//Console.WriteLine(name.IndexOf('o'));

//string message = "Welcome to My First Program";
//Console.WriteLine(message.IndexOf('o'));
//Console.WriteLine(message.LastIndexOf('o'));

//string str1 = "hello";
//string str2 = "Hello";

//Console.WriteLine(str1.CompareTo(str2));
//Console.WriteLine(String.Compare(str1, str2));
//Console.WriteLine(str1.Equals(str2, StringComparison.OrdinalIgnoreCase));

//string msg = "Hello and welcome to the concept of string";
//Console.WriteLine(msg.StartsWith('H'));

//string[] result = msg.Split(" ");
//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

StringBuilder sb = new StringBuilder("Welcome to StringBuilder");
sb.Append("!");
sb.Insert(10, "new");
Console.WriteLine(sb);
//sb.Append("Hello");
//Console.WriteLine(sb.Capacity);
//Console.WriteLine(sb.Length);

