using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{

    class A
    {
        public void Driver()
        {
            Console.WriteLine("this is the driver method of the class A");
        }

    }

    class B : A
    {

        new public void Driver()
        {
            Console.WriteLine("this is the over ridden driver method of the class b");
        }

    }


    class C : A
    {

        new public void Driver(int x, int y)
        {

            int A = x;
            int B = y;


            Console.WriteLine(A + B);

        }
    }
        class D : A
        {

            new public void Driver(int F, int G)
            {

                int l = F;
                int m = G;


                Console.WriteLine(l * m);

            }


        }

        class Test
        {
            static void Main(string[] args)
            {

                B objB = new B();
                objB.Driver();

                C objC = new C();
                objC.Driver(15, 20);

                D objD = new D();
                objD.Driver(15, 20);

                Console.ReadKey();

            }
        }
    }

