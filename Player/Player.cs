using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame.Player
{
    /// <summary>
    /// Игрок
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Имя игрока должно быть скрыто
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Фамилия игрока должно быть скрыто
        /// </summary>
        public string? Surname { get; set; }
        /// <summary>
        /// НикНейм игрока
        /// </summary>
        public string? NackName { get; set; }
        /// <summary>
        /// Наальные Жизни Игрока
        /// </summary>
        public int Hitpoint { get; set; }
        /// <summary>
        /// Сытость Игрока
        /// </summary>
        public int Satiety { get; set; }
        /// <summary>
        /// Возвраст игрока
        /// </summary>
        public byte Age { get; set; }
        /// <summary>
        /// Lvl Игрока
        /// </summary>
        public float Lel { get; set; }
        /// <summary>
        /// Раса Игрока
        /// </summary>
        public string? Species { get; set; }
        /// <summary>
        /// Вес Игрока
        /// </summary>
        private double weight;
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 100) //kg
                    weight = value;
                else
                    Console.WriteLine("Вес игрока не может превышать 100 kg.");
            }
        }
    }
}
