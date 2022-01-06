using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinuVorm
{
    class Start_menu : System.Windows.Forms.Form
    {
        public Start_menu()
        {
            Button Kinozal_btn = new Button
            {
                Text = "Kupit",
                Location = new System.Drawing.Point(220,40),//Point(x,y)
                Height = 40,
                Width = 120
        };
            this.Controls.Add(Kinozal_btn);
            this.Height = 500;//свойство высота формы
            this.Width = 600;
        }
    }
}
