using System;


namespace SampleConApp3
{
    class ObjectDemo
    {
        static void Main(string[] args)
        {
            object data = 123;  //stored as int. BOXING is implicit(Internally)
            Console.WriteLine("The data type is " + data.GetType());
            //data += 123;//Not possible to directly perform computation as the variable has boxed content.
            int tempValue = (int)data;//UNBOXING is explicit(You should typecast, else its a compile error)
            tempValue += 123;
            data = tempValue;
        }
    }
}

