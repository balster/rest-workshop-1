using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Open.Documents.Handlers
{
    public class ReturnCoffeMate
    {
        public string CoffeeName { get; set; }

     
        public ReturnCoffeMate()
        {

        }

        public ReturnCoffeMate(string term)
        {
            if (term.Contains("coffee"))
            {
                CoffeeName = "Nescafe";
            }
            else
            {
                CoffeeName = "Teapot";
            }
                
        }
    }
}
