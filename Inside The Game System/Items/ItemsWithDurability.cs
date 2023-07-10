using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame.Inside_The_Game_System.Items
{
    /// <summary>
    /// Предметы С прочностью
    /// </summary>
    public class ItemsWithDurability : Items 
    {
        /// <summary>
        /// Прочность предмета
        /// </summary>
        public float Endurance { get; set; }

    }
}
