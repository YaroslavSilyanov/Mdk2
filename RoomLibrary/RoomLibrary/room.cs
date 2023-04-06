using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class room
    {
        double roomLength;
        double roomWidth;
        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value; }
        }
        public double RoomWidth
        {
            get { return RoomWidth; }
            set { RoomWidth = value; }
        }
        /// <summary>
        /// метод вычисляет периметр комнаты
        /// </summary>
        /// <returns>возвращает значение периметра</returns>
        public double RoomPerimetr()
        {
            return 2 * (roomLength + RoomWidth);
        }
        /// <summary>
        /// метод вычисляет площадь комнаты
        /// </summary>
        /// <returns>возвращает значение площади</returns>
        public double RoomArea()
        {
            return roomLength * RoomWidth;
        }
        /// <summary>
        /// метод вычисляет число квадратных метров на одного человека
        /// </summary>
        /// <param name="np"></param>
        /// <returns>возвращает число квадратных метров</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;

        }

    }
    
}
