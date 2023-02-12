// See https://aka.ms/new-console-template for more information
using Basic;

//int num;
//Solution.Assignment1(105, 100, out num);
//Console.WriteLine(num);

////Solution.Assignment3();

//double[] arrDoubles = Solution.Assignment4(true, 4.4, 5.5, 7.1, 4.2);

//char[] letters = { 'i', 'a' };
//string str = "arrayAsSpan[i]";
////Solution.Assignment5(str, letters);
////Console.WriteLine(str);

//bool r = Solution.Assignment6("oopoo");
//bool r2 = Solution.Assignment6("opoo");


//int[] arr = new int[] { 4, 1, 1, 2, 2 };
//Console.WriteLine(Solution.Assignment7(arr));

bool[,] board = new bool[4, 3] { { false, true, false }, { false, false, true }, { true, true, true }, { false, false, false } };
const int rowsCount = 4;
const int colsCount = 3;
bool[,] newBoard = Solution.Assignment8(board, rowsCount, colsCount);
for (int i = 0; i < rowsCount; ++i)
{
    for (int j = 0; j < colsCount; ++j)
    {
        Console.Write($"{newBoard[i, j]} ");
    }
    Console.WriteLine();
}

//int number = Solution.Assignment9();

Console.ReadLine();