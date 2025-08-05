using Demo.InterfaceExample01;
using Demo.InterfaceExample02;
using System.Text;

namespace Demo
{
    internal class Program
    {

        //static void ProcessTypeSeries(TypeA input)
        //{
        //    for(int i = 0; i < 10; i++)
        //    {
        //        input.GetNext();
        //        Console.Write($"{input.Current}, ");
        //    }
        //    Console.WriteLine("===============================");
        //}
        //static void ProcessTypeSeries(TypeB input)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        input.GetNext();
        //        Console.Write($"{input.Current}, ");
        //    }
        //    Console.WriteLine("===============================");
        //}
        //static void ProcessTypeSeries(TypeC input)
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        input.GetNext();
        //        Console.Write($"{input.Current}, ");
        //    }
        //    Console.WriteLine("===============================");
        //}

        static void ProcessTypeSeries(ISeries input)
        {
            for (int i = 0; i < 10; i++)
            {
                input.GetNext();
                Console.Write($"{input.Current}, ");
            }
            Console.WriteLine("===============================");
        }
        static void Main(string[] args)
        {
            #region Interface
            //Interface.IType type = new Interface.Type();

            //type.Print();
            //type.PrintMessage();
            //Console.WriteLine(type.GetType());

            #region Interface Example01
            //ISeries typeA = new TypeA();
            //ISeries typeB = new TypeB();
            //ISeries typeC = new TypeC();

            //ProcessTypeSeries(typeA);
            //ProcessTypeSeries(typeB);
            //ProcessTypeSeries(typeC);

            #endregion

            #region Interface Example02
            // when class inherit from multiple interfaces have the same methods names, and use explicit implementation
            // then when we make object from class and want to use specfic method to specific interface,
            // we must bind the class object into the specific interface that contains the method

            //IMoveOnAir airPlane = new AirPlane();
            //airPlane.Forward();
            //IMoveOnGround moveOnGround = new AirPlane();
            //moveOnGround.Forward();

            #endregion

            #endregion

            #region Shallow Copy - Array of Value Type
            //int[] arr1 = [1, 2, 3];
            //int[] arr2 = new int[3];

            //// different addresses
            //Console.WriteLine($"Hashcode => arr1 > {arr1.GetHashCode()}");
            //Console.WriteLine($"Hashcode => arr2 > {arr2.GetHashCode()}");

            //arr2 = arr1;

            //// same addresses (same reference) any manipulation in either of arrays , it appears in the other
            //Console.WriteLine("============= After ================");
            //Console.WriteLine($"Hashcode => arr1 > {arr1.GetHashCode()}");
            //Console.WriteLine($"Hashcode => arr2 > {arr2.GetHashCode()}");
            #endregion

            #region Deep Copy - Array of Value Type
            //int[] arr1 = [1, 2, 3];
            //int[] arr2 = new int[3];

            //// different addresses
            //Console.WriteLine($"Hashcode => arr1 > {arr1.GetHashCode()}");
            //Console.WriteLine($"Hashcode => arr2 > {arr2.GetHashCode()}");

            //// here we can use also Array.Copy() make the same thing
            //arr2 = (int[])arr1.Clone(); //it  takes copy of arr1 and put it in new address, then put reference in arr2 to it

            //// different addresses (different references) - arr2 get new address
            //Console.WriteLine("============= After ================");
            //Console.WriteLine($"Hashcode => arr1 > {arr1.GetHashCode()}");
            //Console.WriteLine($"Hashcode => arr2 > {arr2.GetHashCode()}");
            //arr2[0] = 100;
            //Console.WriteLine(arr1[0]);

            #endregion

            #region Shallow Copy - Array of Reference Type [Immutable]
            //string[] name01 = ["Ahmed", "Ali", "Osama"];
            //string[] name02 = new string[3];

            //// different addresses
            //Console.WriteLine($"Hashcode => name01 > {name01.GetHashCode()}");
            //Console.WriteLine($"Hashcode => name02 > {name02.GetHashCode()}");

            //name02 = name01; // same as the shallow copy of the arr of value type (string act like value type)

            //// same address  - any manipulation in either arrays, appears in the two arrays
            //Console.WriteLine("============= After ================");
            //Console.WriteLine($"Hashcode => name01 > {name01.GetHashCode()}");
            //Console.WriteLine($"Hashcode => name02 > {name02.GetHashCode()}");

            //name02[0] = "Hossam";
            //Console.WriteLine(name01[0]);
            #endregion

            #region Deep Copy - Array of Reference Type [Immutable]
            //string[] name01 = ["Ahmed", "Ali", "Osama"];
            //string[] name02 = new string[3];

            //// different addresses
            //Console.WriteLine($"Hashcode => name01 > {name01.GetHashCode()}");
            //Console.WriteLine($"Hashcode => name02 > {name02.GetHashCode()}");

            //name02 = (string[])name01.Clone();   // same as the deep copy of the arr of value type (string act like value type)

            //// different addresses  
            //Console.WriteLine("============= After ================");
            //Console.WriteLine($"Hashcode => name01 > {name01.GetHashCode()}");
            //Console.WriteLine($"Hashcode => name02 > {name02.GetHashCode()}");

            //name02[0] = "Hossam";
            //Console.WriteLine(name01[0]);
            #endregion

            #region Shallow Copy - Array of reference Type [Mutable]
            //StringBuilder[] names01 = [new StringBuilder("Ahmed")];
            //StringBuilder[] names02 = [new StringBuilder("Ali")];

            //// different addresses
            //Console.WriteLine($"Hashcode => name01 > {names01.GetHashCode()}");
            //Console.WriteLine($"Hashcode => name02 > {names02.GetHashCode()}");

            //names02 = names01; // same as the shallow copy of the previous examples

            //// same addresses - any maniplulation in either of them , appears in the other
            //Console.WriteLine("============= After ================");
            //Console.WriteLine($"Hashcode => name01 > {names01.GetHashCode()}");
            //Console.WriteLine($"Hashcode => name02 > {names02.GetHashCode()}");


            #endregion

            #region Deep Copy - Array of reference Type [Mutable]
            //StringBuilder[] names01 = [new StringBuilder("Ahmed")];
            //StringBuilder[] names02 = [new StringBuilder("Ali")];

            //// different addresses
            //Console.WriteLine($"Hashcode => name01 > {names01.GetHashCode()}");
            //Console.WriteLine($"Hashcode => name02 > {names02.GetHashCode()}");

            //// here it take a copy of actual values of names01 (references) , put in new place ,
            //// and make names02 reference it
            //names02 = (StringBuilder[])names01.Clone();

            //// different addresses  
            //Console.WriteLine("============= After ================");
            //Console.WriteLine($"Hashcode => name01 > {names01.GetHashCode()}");
            //Console.WriteLine($"Hashcode => name02 > {names02.GetHashCode()}");

            //// here we affect the first stringbuilder in names02 inplace, and names01[0] still reference it
            //// so when we manipulate it , it appears in names01 also
            //names02[0].Append(" Khaled");
            //Console.WriteLine(names01[0]);
            //// here the two addresses are the same
            //Console.WriteLine(names01.GetHashCode());
            //Console.WriteLine(names02.GetHashCode());

            //// here we affect the first stringbuilder in names02 in new place (reference), and names01[0] still reference the old
            //// so when we manipulate it , it does not appear in names01 
            //names02[0] = new StringBuilder(" Khaled");
            //Console.WriteLine(names01[0]);
            //// here the two addresses are different 
            //Console.WriteLine(names01.GetHashCode());
            //Console.WriteLine(names02.GetHashCode());
            #endregion
        }
    }
}
