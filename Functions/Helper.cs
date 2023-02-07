using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Helper
    {
        public static void swap(double[] array, int i, int j)
        {
            double temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
