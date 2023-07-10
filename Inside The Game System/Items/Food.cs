using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame.Inside_The_Game_System.Items
{
    /// <summary>
    /// Еда
    /// </summary>
    public class Food : Items
    {
        /// <summary>
        /// Срок годности Еды
        /// </summary>
        public ulong ExpirationDateDay { get; set; }
        public int SatietyFood { get; set; }
        /// <summary>
        /// Продукты
        /// </summary>
        public List<string>? Products { get; set; }
        public Food rawapple = new()
        {
            NameItems = "Яблоко",
            LvlItems = 1,
            WeightItems = 0.2,
            SatietyFood = 5,
            ExpirationDateDay = 30 //Day
        };
        public Food rawPear = new()
        {
            NameItems = "Груша",
            LvlItems = 1,
            WeightItems = 0.2,
            SatietyFood = 5,
            ExpirationDateDay = 30 //Day
        };
        public Food rawPeach = new()
        {
            NameItems = "Персик",
            LvlItems = 1,
            WeightItems = 0.2,
            SatietyFood = 5,
            ExpirationDateDay = 15 //Day
        };
        public Food rawTortilla = new()
        {
            NameItems = "Лепёшка из теста",
            LvlItems = 1,
            WeightItems = 0.3,
            SatietyFood = 10,
            ExpirationDateDay = 10 //Day
        };
        public Food rawBun = new()
        {
            NameItems = "Булочка из теста",
            LvlItems = 1,
            WeightItems = 0.1,
            SatietyFood = 15,
            ExpirationDateDay = 4 //Day
        };
        public Food rawMilk = new()
        {
            NameItems = "Молоко",
            LvlItems = 1,
            WeightItems = 0.5,
            SatietyFood = 10,
            ExpirationDateDay = 5 //Day
        };
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public Food rawSalad = new()
        {
            NameItems = "Салат",
            LvlItems = 2,
            WeightItems = 0.2,
            SatietyFood = 15,
            ExpirationDateDay = 2 //Day
        };
        public Food rawVegetableSoup = new ()
        {
            NameItems = "Овощной суп",
            LvlItems = 2,
            WeightItems = 0.5,
            SatietyFood = 25,
            ExpirationDateDay = 3 //Day
        };
        public Food rawHermitsStew = new()
        {
            NameItems = "Рагу отшельника",
            LvlItems = 2,
            WeightItems = 0.4,
            SatietyFood = 20,
            ExpirationDateDay = 3 //Day
        };
        public Food rawDriedMeat = new ()
        {
            NameItems = "Сушеное мясо",
            LvlItems = 2,
            WeightItems = 0.2,
            SatietyFood = 15,
            ExpirationDateDay = 90 //Day
        };
        public Food rawMushroomStar = new ()
        {
            NameItems = "Звёздный гриб",
            LvlItems = 2,
            WeightItems = 0.2,
            SatietyFood = 20,
            ExpirationDateDay = 80 //Day
        };
        public Food rawSandwich = new()
        {
            NameItems = "Сендвич",
            LvlItems = 2,
            WeightItems = 0.3,
            SatietyFood = 20,
            ExpirationDateDay = 7 //Day
        };
        public Food rawMeat = new()
        {
            NameItems = "Мясо сырое",
            LvlItems = 2,
            WeightItems = 1,
            SatietyFood = 25,
            ExpirationDateDay = 3 //Day
        };
        public Food rawChicken = new()
        {
            NameItems = "Курица сырая",
            LvlItems = 2,
            WeightItems = 1.4,
            SatietyFood = 25,
            ExpirationDateDay = 3 //Day
        };
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public Food rawFish = new()
        {
            NameItems = "Сушеная рыба",
            LvlItems = 3,
            WeightItems = 1,
            SatietyFood = 40,
            ExpirationDateDay = 70 //Day
        };
        public Food rawMixNuts = new()
        {
            NameItems = "Микс орехов",
            LvlItems = 3,
            WeightItems = 1.5,
            SatietyFood = 60,
            ExpirationDateDay = 1852 //Day
        };
        public Food rawMixPea = new()
        {
            NameItems = "Микс бобов",
            LvlItems = 3,
            WeightItems = 1.5,
            SatietyFood = 60,
            ExpirationDateDay = 1852 //Day
        };
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public Food rawEpicMeet = new()
        {
            NameItems = "Вяленое мясо монстра",
            LvlItems = 4,
            WeightItems = 1,
            SatietyFood = 80,
            ExpirationDateDay = 60 //Day
        };
        public Food rawEpicPotat = new()
        {
            NameItems = "Картофель богов",
            LvlItems = 4,
            WeightItems = 1.1,
            SatietyFood = 90,
            ExpirationDateDay = 70 //Day
        };
        ////////////////////////////////////////////////////////////////////////////////////////////////
        public Food() 
        {
            rawapple.Products!.Add("Яблоко");
            rawMeat.Products!.Add("Груша");
            rawChicken.Products!.Add("Персик");
            rawTortilla.Products!.Add("Лепёшка из теста");
            rawBun.Products!.Add("Булочка из теста");
            rawMilk.Products!.Add("Молоко");
            rawSalad.Products!.Add("Салат");
            rawVegetableSoup.Products!.Add("Овощной суп");
            rawHermitsStew.Products!.Add("Рагу отшельника");
            rawDriedMeat.Products!.Add("Сушеное мясо");
            rawMushroomStar.Products!.Add("Звёздный гриб");
            rawSandwich.Products!.Add("Сендвич");
            rawMeat.Products!.Add("Мясо сырое");
            rawChicken.Products.Add("Курица сырая");
            rawFish.Products!.Add("Сушеная рыба");
            rawMixNuts.Products!.Add("Микс орехов");
            rawMixPea.Products!.Add("Микс бобов");
            rawEpicMeet.Products!.Add("Вяленое мясо монстра");
            rawEpicPotat.Products!.Add("Картофель богов");
        }
    }
}
