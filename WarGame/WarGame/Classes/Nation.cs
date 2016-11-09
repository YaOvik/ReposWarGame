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
        private string _nationName;
        private int _nationEndurance;
        private Color _nationColor;
        private string _nationImagePath;


        public Nation(string name, int endurance, Color color, string imagePath)
        {
            _nationName = name;
            _nationEndurance = endurance;
            _nationColor = color;
            _nationImagePath = imagePath;
        }

    }
}
