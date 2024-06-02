using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_02_06
{

    //Розробіть додаток, який знаходитиме мінімальне і
    //максимальне значення у двовимірному масиві.
    internal class MinMax
    {
        private int _min;
        private int _max;
        private int[,] _array;


        public MinMax() { }
        public MinMax(int[,] arr)
        {
            _array = arr;
        }


        public int getMin() { return _min; }
        public int getMax() { return _max; }


        public void showArr()
        {
            for(int i =0;i< _array.GetLength(0); i++)
            {
                for(int j =0;j< _array.GetLength(1); j++)
                {
                    Console.Write($"{_array[i, j]} ");
                }
                Console.Write("\n");
            }
        }

        public void searchMinInArr()
        {
            _min = _array[0, 0];
            for(int i =0;i < _array.GetLength(0); i++)
            {
                for(int j = 0;j< _array.GetLength(1); j++)
                {
                    if (_array[i,j] < _min)
                    {
                        _min = _array[i,j];
                    }
                }
            }
        }


        public void searchMaxInArr()
        {
            _max = _array[0, 0];
            for(int i =0;i< _array.GetLength(0); i++)
            {
                for(int j = 0;j< _array.GetLength(1); j++)
                {
                    if (_array[i,j] > _max)
                    {
                        _max = _array[i,j];
                    }
                }
            }
        }
    }
}
