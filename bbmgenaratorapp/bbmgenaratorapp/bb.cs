using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bbmgenaratorapp
{
    public class bb
    {
       HashSet<int> myh = new HashSet<int> { };
        Random gen = new Random();
        public int g;

        public HashSet<int> bbhold() { 
             g =gen.Next(1000000,9999999);
             if (!(myh.Contains(g)))
             {
                 myh.Add(g);
             }
            

            return myh;
        }
        

    }
}
