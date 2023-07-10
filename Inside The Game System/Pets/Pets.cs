using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame.Inside_The_Game_System.Pets
{
    /// <summary>
    /// Питомцы
    /// </summary>
    public class Pets : InsideTheGameSystem
    {
        /// <summary>
        /// ИМЯ ПИТОМЦА
        /// </summary>
        public string? NamePets { get; set; }
        /// <summary>
        /// ЛВЛ ПИТОМЦА
        /// </summary>
        public float LvlPets { get; set; }
        /// <summary>
        /// РАСА ПИТОМЦА
        /// </summary>
        public string? SpeciesPets { get; set; }
        /// <summary>
        /// РЕДКОСТЬ ПИТОМЦА
        /// </summary>
        public string? RarePets { get; set; }

        public void SetRandomRarity()
        {
            Random random = new();
            int randomNumber = random.Next(100); 
            if (randomNumber < 50)
                RarePets = "обычный";
            else if (randomNumber < 90)
                RarePets = "эпический";
            else
                RarePets = "легендарный";
        }
    }
}
