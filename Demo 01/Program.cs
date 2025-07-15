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
            Prouduct p1 = new Prouduct()
            {
                Id = 10,
                name = "martin",
                price = 6000 ,
            };
            Console.WriteLine(p1);
            /*
             * ay ta8er f al class library htsm3 f al proggram 3ndy */

            #endregion
        }
    }
}
