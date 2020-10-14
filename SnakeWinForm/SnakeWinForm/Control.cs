using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SnakeWinForm
{
    class Control
    {
        private string key = string.Empty;
        public string Key { private set; get; }
        public bool isDownShift { set; get; }

        public Control()
        {
        }
        public void Input(string key)
        {
            switch (key)
            {
                case "W":
                case "Up":
                    Key = "Up";
                    break;
                case "S":
                case "Down":
                    Key = "Down";
                    break;
                case "A":
                case "Left":
                    Key = "Left";
                    break;
                case "D":
                case "Right":
                    Key = "Right";
                    break;
                case "P":
                    Key = "Pause";
                    break;
                case "Escape":
                    Key = "Escape";
                    break;
                case "ShiftKey":
                    isDownShift = true;
                    break;
            }
        }
    }
}
