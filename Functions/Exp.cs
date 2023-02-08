using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Basic;

bool[,] board = new bool[,]
{
    { false, true, false },
    { false, false, true },
    { true, true, true },
    { false, false, false }
};
Solution.Assignment8(board, 4, 3);
Helper.Print2DArray(board);