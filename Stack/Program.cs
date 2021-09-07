using System;
using System.Collections;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            CollectionStack obj = new CollectionStack();
            obj.StackMethod();
            Console.ReadKey();
        }
    }

    class CollectionStack
    {
        public void StackMethod()
        {
            StackEx st = new StackEx();
            //Program st = new Program();
            st.Push("A");
            st.Push(1);
            st.Push(2);



            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("******END LOOP********");
            Console.WriteLine(st.Pop());
            Console.WriteLine("******Deleted Element******");

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("******END LOOP********");

            Console.WriteLine("Top most item to be delete" + st.Peek());




        }

        class stackEx
        {
            public void  


        }
        
        
    
    }
}
