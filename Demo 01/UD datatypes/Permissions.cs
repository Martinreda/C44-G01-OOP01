using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01.UD_datatypes
{
    [Flags] //handale these permissions as bits values [00000011111
    internal enum permissions : byte
    {
        //each byte hav 8 bits

        Delete=1 , //00000001
        excute=2,  //00000010
        read =4,   //00000100
        write =8,  //00001000
    }
}
