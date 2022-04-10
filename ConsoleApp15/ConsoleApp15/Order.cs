using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15
{
    class Order
    {
        public int No { get; set; }
        public List<Menultem> Orderitems { get; set } = new List<Menultem>();
        public double TotalAmount { get; set; }
        public DateTime Date { get; set; }
    }
}
