int[] arr = new int[5];
arr[0] = 10;


int[] arr2 = { 10, 20, 30 };

int[] arr3 = new int[] { 10, 20, 30, 40 };

//Multi Dimensional Array
int[,] num = new int[2, 3];

num[0, 0] = 10;
num[0, 1] = 20;

int[,] num2 = new int[,] { { 1, 2, 3 }, { 5, 6, 7 } };

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"{num2[i, j]} ");
    }
    Console.WriteLine();
}

int[,] num3 = { { 10, 20 }, { 30, 40 } };

// Jagged Array
int[][] jagArr = new int[3][];
jagArr[0] = new int[] { 10, 20, 30 };
jagArr[1] = new int[] { 1, 2 };
jagArr[2] = new int[] { 5, 6, 7, 8 };

for (int i = 0; i < jagArr.Length; i++)
{
    for (int j = 0; j < jagArr[i].Length; j++)
    {
        Console.Write(jagArr[i][j] + " ");
    }
    Console.WriteLine();
}

//int[] arr1 = new int[5];

//for (int i = 0; i < arr1.Length; i++)
//{
//    arr1[i] = Convert.ToInt16(Console.ReadLine());
//}

//foreach (int item in arr1)
//{
//    Console.WriteLine(item);
//}

//for(int j = 0; j < arr1.Length; j++)
//{
//    Console.WriteLine(arr1[j]);
//}
