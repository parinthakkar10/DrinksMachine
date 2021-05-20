using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_Machine.Models
{
    public class Drinks
    {
        //public static int coke_count = 5;

        //public static int pepsi_count = 15;

        //public static int soda_count = 3;
        public int CokeQty { get; set; }
        public int CokeValue { get; set; }
        public int PepsiQty { get; set; }
        public int PepsiValue { get; set; }
        public int SodaQty { get; set; }
        public int SodaValue { get; set; }
        public int CentsValue { get; set; }
        public int Cents { get; set; }
        public int PennyValue { get; set; }
        public int Penny { get; set; }
        public int NickelsValue { get; set; }
        public int Nickels { get; set; }
        public int QuarterValue { get; set; }
        public int Quarter { get; set; }
        public int ChangeCents { get; set; }
        public int ChangePenny { get; set; }
        public int ChangeNickel { get; set; }
        public int ChangeQuarter { get; set; }
        public Dictionary<string, int> DrinksList { get; set; }
    }
}