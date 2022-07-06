using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindPathRobot
{
    internal class Cell : Button
    {
        public int Value { get; set; }
        public bool IsLocked { get; set; }
        public int CellRow { get; set; }
        public int CellCol { get; set; }
    }
}
