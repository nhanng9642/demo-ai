using System;
using System.Collections.Generic;

namespace DoAnNMLT_20880040_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CATEGORY> categories = new List<CATEGORY>();
            List<PRODUCT> products = new List<PRODUCT>();

            HandleCLI.main(products, categories);
        }
    }
}
