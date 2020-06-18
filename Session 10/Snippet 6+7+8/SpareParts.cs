using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_6_7_8
{
    public class SpareParts
    {
        string spareName;
        public SpareParts()
        {
            spareName = "Gear Box";
        }
        public void Display()
        {
            Console.WriteLine("Spare Part name: " + spareName);
        }
    }
}
