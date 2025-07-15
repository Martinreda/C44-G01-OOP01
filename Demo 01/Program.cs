using commen;

namespace Demo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 01 class Library

            /*class library
             * what is class library ?? 
             * types of projects - identity i can use it for many apps like (webapp , desc app , ai pp , mobile app).
             * 2-collectionn of classes , interfaces that can can used in multiable projects 
             * cannot be executable ()No running
             */
            //Prouduct p1 = new Prouduct()
            //{
            //    Id = 10,
            //    name = "martin",
            //    price = 6000 ,
            //};
            //Console.WriteLine(p1);
            ///*
            // * ay ta8er f al class library htsm3 f al proggram 3ndy */

            #endregion

            #region 02 Access Modifiers
            /*
             * 1- privte
             * 2- privte protected
             * 3- protected
             * 4- internal
             * 5- protected internal
             * 6- Public
             */
            TypeA typeA = new TypeA();
            typeA.x = 1; // invalid because protiction level
            typeA.y = 2;// invalid because protiction level
            typeA.z = 3;// valid because it Public
            #endregion

        }
    }
}
