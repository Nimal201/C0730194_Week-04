using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0730194
{
    class Program
    {
        static void Main(string[] args)
        {
            countryside c = new countryside();
        }
    }

    class village
    {
       public bool isAstrildeHere;
        public village nextvillage;
        public village prevvillage;
        public String villagName;


    }


    class countryside
    {
        village Maple ,Toronto, Ajax;

        public void run()
        {
            Maple = new village();
            Maple.villagName = "Toronto";
            Maple.villagName = Toronto;

        }

    }
}

