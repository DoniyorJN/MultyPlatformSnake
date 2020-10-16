using System;

namespace Reptile
{
    
    class Control
    {
        private string key = string.Empty;
        public string Key { private set; get; }
        public bool isDownShift { private set; get;}
        ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
          public void Input()
        {
            if (Console.KeyAvailable)
            {
                keyInfo = Console.ReadKey(true);
                key = keyInfo.Key.ToString();
                if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    if (isDownShift)
                    {
                        isDownShift = false;
                    }
                    else
                    {
                        isDownShift = true;
                    }
                }
                //flushing
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                
            }
            switch (key)
            {
                case "W":
                case "UpArrow":
                    Key = "Up";
                    break;
                case "S":
                case "DownArrow":
                    Key = "Down";
                    break;
                case "A":
                case "LeftArrow":
                    Key = "Left";
                    break;
                case "D":
                case "RightArrow":
                    Key = "Right";
                    break;
                case "P":
                    Key = "Pause";
                    break;
                case "Escape":
                    Key = "Escape";
                    break;
            }
            


        }
    }
}
