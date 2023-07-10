using ProjectGame.Inside_The_Game_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame.Inside_The_Game_System.Items
{
    /// <summary>
    /// Предметы
    /// </summary>
    public class Items 
    {
        /// <summary>
        /// НАзвание предмета
        /// </summary>
        public string? NameItems { get; set; }
        /// <summary>
        /// Левл предмета
        /// </summary>
        public float? LvlItems { get; set; }
        /// <summary>
        /// Вес предмета
        /// </summary>
        public byte Weight { get; set; }
    }
}
