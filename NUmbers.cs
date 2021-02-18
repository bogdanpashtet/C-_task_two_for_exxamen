using System;

namespace var_2
{
    public class NUmbers : IArOperations, ILogOperations
    {
        public int a;
        public int b;

        #region constructors

        public NUmbers()
        {
            a = 0;
            b = 0;
        }

        public NUmbers(int a1, int b1)
        {
            a = a1;
            b = b1;
        }

        #endregion
        
        #region IArOperationd
        
        public int summ()
        {
            return a + b;
        }

        public int subtraction()
        {
            return a - b;
        }

        public int multiplication()
        {
            return a * b;
        }

        public int division()
        {
            if (b == 0)
            {
                Console.WriteLine("Error: division by zero is not possible."); 
                return 0; 
            }
            else
            {
                return a / b;
            }
        }
        
        #endregion
        
        #region ILogOperations

        public int conjunction()
        {
            return a & b;
        }

        public int disjunction()
        {
            return a|b;
        }

        #endregion
    }
}