using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
       static public int BinaryGap(int value)
        {
            int maxGap = 0;
            int count = 0;
            //int value = 1041;
            string binary = Convert.ToString(value, 2);

            for (int i = 0; i < binary.Length; i++)
            {
                if (binary[i] == '1')
                {
                    while (i + 1 < binary.Length && binary[i + 1] == '0')
                    {
                        count++;
                        i++;
                    }
                }
                if (i + 1 < binary.Length && binary[i + 1] == '1' && count > maxGap)
                {
                    maxGap = count;
                    count = 0;
                }
            }
            return maxGap;
        }


        static void Main(string[] args)
        {
           
            Console.WriteLine(BinaryGap(529));
            Console.ReadKey();
    }

}
}


