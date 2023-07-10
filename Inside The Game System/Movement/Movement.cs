using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGame.Inside_The_Game_System.Movement
{
    /// <summary>
    /// Передвижение 
    /// </summary>
    public class Movement : InsideTheGameSystem
    {
        /// <summary>
        /// НАЗВАНИЕ ОБЪЕКТА ДЛЯ ПЕРЕДВИЖЕНИЯ
        /// </summary>
        public string? NameMovement {  get; set; }
        /// <summary>
        /// Лвл ОБЪЕКТА ДЛЯ ПЕРЕДВИЖЕНИЯ
        /// </summary>
        public float LvlMovement { get; set; }
    }
}
