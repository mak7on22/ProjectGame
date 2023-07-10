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
        public ulong ExpirationDate { get; set; }
    }
}
