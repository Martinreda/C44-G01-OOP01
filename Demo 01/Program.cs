using commen;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System;
using Demo_01.UD_datatypes;

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
            //TypeA typeA = new TypeA();
            //typeA.x = 1; // invalid because protiction level
            //typeA.y = 2;// invalid because protiction level
            //typeA.z = 3;// valid because it Public
            #endregion

            #region 03 user define datatypes
            /*
             * 1-class
             * 2-struct
             * 3-interface
             * 4-Enum
             */
            /*Namespace
             * what i can write inside ?? -class -interface -struct -Enum
             * access modifier allowed insid ? -internal (defualt) -Public
             * Defualt access modifier ? No access modifier */
            /* 1-class
             * ---what i can write inside ??
             * attributes - functions (CTOR -setter Getter - method)
             * propertes (Full , automatic , indexer)
             * Events 
             * ---access modifier allowed inside?
             * all 6 access modifier 
             * Private (Defualt)
             * ---Defualt access modifier class?
             * internal 
             */


            #endregion

            #region 04 UD Struct
            /*    ---what i can write inside ??
            *attributes - functions(CTOR - setter Getter - method)
            * propertes(Full, automatic, indexer)
            * Events
            * 
            *    ---access modifier allowed inside?
            * privte -  internal   -  Public
             *Private(Defualt)
             * ---Defualt access modifier class?
             * internal
             */

            #endregion

            #region 05 UD Interface
            /*    ---what i can write inside ??
            1-signature for property
            2-signature for method
            3-defualt implimented meathod => C# 8.0 . net core 2019


            *    ---access modifier allowed inside?
            without implimintion 
            any access modifier work exepet private
            defualt AD (public)
            defualt implimented meathod any access is valied


            * ---Defualt access modifier interface ?
             internal
             */


            #endregion

            #region 06 UD Enum
            /*what i can write inside ?? 
             Labels -- a sey of Names constans


             * access modifier allowed inside?
             No access allowed inside Enum
             
             * Defualt access modifier ? No access modifier
             Internal
             */
            #endregion

            #region 07 EX1 , EX 2 Enum
            //EX 01 
            //Person person = new Person();
            //person.Id = 10;
            //person.Name = "Martin";
            //person.Gender = Gender.Male;

            //Console.WriteLine(person);

            ////Ex02
            //Grades G01 = new Grades();


            //G01 = Grades.B;
            //G01 = (Grades)5;
            ////Console.WriteLine(G01);
            //if (G01==Grades.A || G01 == Grades.B)
            //    Console.WriteLine("GOOD");
            //else
            //    Console.WriteLine( "Bad");
            #endregion

            #region EX 03 Enum
            /* permissions : Delete | Write | Excute */
            Users user01 = new Users();
            user01.iD = 10;
            user01.Permissions = (permissions)4;
            //Console.WriteLine( user01.Permissions);

            Users user02 = new Users();

            user02.iD = 20;
            user02.Permissions = (permissions)2;
            Console.WriteLine( user02.Permissions);

            //bygm3 albainry number m4 2 + 8 la 

            //add new permission => Bitwise operoteor ^ XOR operoter
            user02.Permissions = user02.Permissions ^ permissions.read;
            Console.WriteLine(user02.Permissions);

            //deny permission with xor ^ 
            //checked if have permisssion or not frist
            user02.Permissions = user02.Permissions ^= permissions.write;
            Console.WriteLine(user02.Permissions);

            //check if user have excute or not
            //if ((user02.Permissions & permissions.Delete) == permissions.Delete)
            //    Console.WriteLine("have excute");
            //else
            //{
            //    user02.Permissions = user02.Permissions ^ permissions.Delete;
            //}
            //Console.WriteLine(user02.Permissions);

            //check with has flag 
            bool haswrite = user02.Permissions.HasFlag(permissions.write);
            if (haswrite)
                Console.WriteLine("a");
            else
                Console.WriteLine("b");

            // OR operoteor |
            //check if permission exsit or not
            //exiset =>do nothing
            //not => add permission 

            user02.Permissions = user02.Permissions | permissions.Delete;
            Console.WriteLine(user02.Permissions);
            // or if permission exist its ok if not will add it 

            // ^ add
            // ^= deny
            // | if have ok not add it

            #endregion


        }
    }
}
