using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simplestProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int globalVariable = 0;

            public void myMeathod()
            {
                int localVariable = 0;
                localVariable++;
                globalVariable++;
            }
            globalVariable++;
        }
    }
}
