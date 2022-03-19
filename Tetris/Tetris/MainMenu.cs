using System;
using System.Collections.Generic;
using System.Text;



namespace Tetris
{
    class MainMenu
    {
        public static void writeTitle()
        {
            string title = @"
            
 _______  _______  _______  ______    ___   _______ 
|       ||       ||       ||    _ |  |   | |       |
|_     _||    ___||_     _||   | ||  |   | |  _____|
  |   |  |   |___   |   |  |   |_||_ |   | | |_____ 
  |   |  |    ___|  |   |  |    __  ||   | |_____  |
  |   |  |   |___   |   |  |   |  | ||   |  _____| |
  |___|  |_______|  |___|  |___|  |_||___| |_______|


";

            Console.WriteLine(title, System.Drawing.Color.Gold);
        }
    }
}
