using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class RobotMove
    {
        private string name;
        private (int, int) coordinates;
        string t;

        public RobotMove(string name, int x, int y)
        {
            this.name = name;
            this.coordinates = (x, y);

        }
        public void Move()
        {

            Random rnd = new Random();
            int direction = rnd.Next(0, 4);
            switch (direction)
            {
                case 0:

                    this.coordinates.Item2++;
                    this.t = "Вперед";

                    break;

                case 1:

                    this.coordinates.Item1++;
                    this.t = "Вправо";
                    break;

                case 2:

                    this.coordinates.Item2--;
                    this.t = "Назад";
                    break;

                case 3:

                    this.coordinates.Item1--;
                    this.t = "Влево";
                    break;
            }

        }

        public string GetInfo()
        {
            return $"Робот {this.name} {t} ({this.coordinates.Item1}, {this.coordinates.Item2})";
        }
    }
}