using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarGame.Classes
{
    class Nation
    {
        public string _nationName;
        public int _nationEndurance;
        public int _nationXPosition;
        public int _nationYPosition;

        private Color _nationColor;
        private string _nationImagePath;


        public Nation(string name, int endurance, int xpos, int ypos, Color color, string imagePath)
        {
            _nationName = name;
            _nationEndurance = endurance;
            _nationXPosition = xpos;
            _nationYPosition = ypos;
            _nationColor = color;
            _nationImagePath = imagePath;
        }

    }
}
