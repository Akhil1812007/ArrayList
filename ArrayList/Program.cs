using System;

namespace ArrayList
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            // consider -1 as an exception for this 
            ArrayList d=new ArrayList();
            for (int i = 1; i < 100; i++)
            {
                d.add(100 + i);
            }
            Console.WriteLine(d.size());
            Console.WriteLine(d.get(2));
            d.set(3, 170);
            Console.WriteLine(d.get(3));

            while (!d.IsEmpty())
            {
                Console.WriteLine(d.RemoveLast());
                Console.WriteLine("size- " + d.size());
            }
        }

    }
    public class ArrayList
    {
        private int[] data;
        private int NextElementIndex;
        public ArrayList()
        {
            data = new int[5];
            NextElementIndex = 0;
        }
        public int size()
        {
            return NextElementIndex;
        }
        public Boolean IsEmpty()
        {
            return NextElementIndex == 0;
        }
        public int get(int i)
        {
            if(i >= NextElementIndex)
            {
                 return -1;
                
            }
            return data[i];
        }
        public void add(int elem)
        {
            if (NextElementIndex == data.Length)
            {
                DoubleCapacity();
            }
            data[NextElementIndex] = elem;
            NextElementIndex++;
        }

        private void DoubleCapacity() // increasing the size two times 
        {
            int[] temp = data;
            data = new int[2*temp.Length];    
            for(int i = 0; i < temp.Length; i++)
            {
                data[i] = temp[i];
            }
        }
        public void set(int i,int element)
        {
            if (i >= NextElementIndex)
            {
                return ;

            }
            data[i]=element;

        }
        public int RemoveLast()
        {
            if (NextElementIndex == 0)
            {
                return -1;
            }
            int temp = data[NextElementIndex - 1];
            data[NextElementIndex-1] = 0;
            NextElementIndex--;
            return temp;
        }
    }
}
