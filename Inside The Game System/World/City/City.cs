using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame.Inside_The_Game_System.World.City
{
    /// <summary>
    /// ГОРОДА
    /// </summary>
    public class City : InsideTheGameSystem
    {
        /// <summary>
        /// Название города
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Lvl города
        /// </summary>
        public byte? LvlCity { get; set; }
    }
}
