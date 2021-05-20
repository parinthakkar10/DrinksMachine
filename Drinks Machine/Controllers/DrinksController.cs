using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drinks_Machine.Models;

namespace Drinks_Machine.Controllers
{
    public class DrinksController : Controller
    {
        Dictionary<string, int> drinksList = new Dictionary<string, int>();

        public static int coke_count = 5;

        public static int coke_value = 25;
        
        public static int pepsi_count = 15;

        public static int pepsi_value = 36;

        public static int soda_count = 3;

        public static int soda_value = 45;

        public static int cents_count = 100;

        public static int centsValue = 10;

        public static int penny_count = 10;

        public static int pennyValue = 1;

        public static int nickel_count = 5;

        public static int nickelValue = 5;

        public static int quarter_count = 25;

        public static int quarterValue = 25;
        public DrinksController()
        {
            drinksList.Add("Coke", coke_count);
            drinksList.Add("Pepsi", pepsi_count);
            drinksList.Add("Soda", soda_count);
            drinksList.Add("Cents", cents_count);
            drinksList.Add("Penny", penny_count);
            drinksList.Add("Nickels", nickel_count);
            drinksList.Add("Quarter", quarter_count);
        }
        public IActionResult Index()
        {
            Drinks drinksModel = new Drinks();
            drinksModel.DrinksList = drinksList;
            drinksModel.CentsValue = centsValue;
            drinksModel.PennyValue = pennyValue;
            drinksModel.NickelsValue = nickelValue;
            drinksModel.QuarterValue = quarterValue;
            drinksModel.CokeValue = coke_value;
            drinksModel.PepsiValue = pepsi_value;
            drinksModel.SodaValue = soda_value;
            return View(drinksModel);
        }

        [HttpPost]
        public IActionResult Purchase(Drinks drinksModel)
        {
            int cokeQty = drinksModel.CokeQty;
            int pepsiQty = drinksModel.PepsiQty;
            int sodaQty = drinksModel.SodaQty;
            coke_count -= cokeQty;
            pepsi_count -= pepsiQty;
            soda_count -= sodaQty;
            cents_count -= drinksModel.Cents;
            penny_count -= drinksModel.Penny;
            nickel_count -= drinksModel.Nickels;
            quarter_count -= drinksModel.Quarter;
            return RedirectToAction("Index");
        }
    }
}
