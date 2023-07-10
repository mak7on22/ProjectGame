using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame.Inside_The_Game_System.NPC
{
    /// <summary>
    /// БОТ
    /// </summary>
    public class Npc : InsideTheGameSystem
    {
        /// <summary>
        /// Имя  Бота
        /// </summary>
        public string? NameNpc { get; set; }
        /// <summary>
        /// Lvl  Бота
        /// </summary>
        public float LvlNpc { get; set; }
    }
}
