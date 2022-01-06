using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinuVorm
{
    class Start_form:System.Windows.Forms.Form//сообщаем что он форма(классу) ( : - сообщаем)
    {
        public Start_form()//public - конструктор
        {
            Button Start_btn = new Button
            {
                Text = "Minu oma aken",
                Location = new System.Drawing.Point(10, 10)//если последнее свойство, то ставить запятую не надо
            };
            Start_btn.Click += Start_btn_Click;
            this.Controls.Add(Start_btn);//Добавление в форму (кнопку)

            Button Start_btn_2 = new Button
            {
                Text = "Veel aken",
                Location = new System.Drawing.Point(10, 60)//если последнее свойство, то ставить запятую не надо
            };
            this.Controls.Add(Start_btn_2);
            Start_btn_2.Click += Start_btn_2_Click;
        }

        private void Start_btn_2_Click(object sender, EventArgs e)
        {
            MyForm uus_aken = new MyForm(10,10);//запускает пустую форму
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            MyForm uus_aken = new MyForm("Mina olen ilus aken", "Vali midagi", "Üks", "Kaks", "Kolm", "Neli");//запускает форму в котором есть что-то
            uus_aken.StartPosition = FormStartPosition.CenterScreen;
            uus_aken.ShowDialog();
        }
    }
}
