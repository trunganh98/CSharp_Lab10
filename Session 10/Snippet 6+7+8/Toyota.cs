using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_6_7_8
{
    class Toyota
    {
        static void Main(string[] args)
        {
            Category objCategory = new Category();
            SpareParts objSpare = new SpareParts();
            objCategory.Display();
            objSpare.Display();
        }
    }
}
