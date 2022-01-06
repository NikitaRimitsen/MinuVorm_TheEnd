using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinuVorm
{
    public partial class MyForm: Form
    {
        Label message = new Label();
        Button[] btn = new Button[4];//создали массив(список) btn - название массива
        string[] texts = new string[4];//создали массив(список) texts - название массива
        TableLayoutPanel tlp = new TableLayoutPanel();
        Button btn_tabel;
        int btn_w, btn_h;
        public MyForm()//пустая форма
        {}
        //Форма с кнопками
        public MyForm(string title, string body, string button1, string button2, string button3, string button4)//нельзя создавать два пустых конструктора польностью одинаковых // в скобках то , от чего она зависит (то что будем вызывать в конструктор)
        {
            texts[0] = button1;
            texts[1] = button2;
            texts[2] = button3;
            texts[3] = button4;
            this.ClientSize = new System.Drawing.Size(400, 100); //размер окна
            this.Text = title;//используем title, потому что мы его вызывали и можем его использовать
            int x = 10;
            for (int i = 0; i < 4; i++)
            {
                btn[i] = new Button
                {
                    Location = new System.Drawing.Point(x, 50),//расположение
                    Size = new System.Drawing.Size(80, 25),//размер кнопки
                    Text = texts[i]
                };
                btn[i].Click += MyForm_Click;

                x += 100;//будет изменять переменную x на 100
                this.Controls.Add(btn[i]);// добавляем кнопки


            }
            message.Location = new System.Drawing.Point(10, 10);//расположение message
            message.Text = body;
            this.Controls.Add(message);//добавили message 

        }

        //форма с кнопочками в ввиде рядов и мест
        public MyForm(int read, int kohad)
        {
            this.tlp.ColumnCount = kohad;
            this.tlp.RowCount = read;
            this.tlp.ColumnStyles.Clear();
            this.tlp.RowStyles.Clear();
            int i, j;
            for (i = 0; i < read; i++)
            {
                this.tlp.RowStyles.Add(new RowStyle(SizeType.Percent/*, 100 / read*/));
                this.tlp.RowStyles[i].Height = 100 / read;
            }
            
            for (j = 0; j < kohad; j++)
            {
                this.tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent/*, 100 / kohad*/));
                this.tlp.ColumnStyles[j].Width = 100 / kohad;
            }
            
            this.Size = new System.Drawing.Size(kohad * 100, read * 100);
            for (int r = 0; r< read; r++)
            {
                for (int k = 0; k < kohad; k++)
                {
                    btn_tabel = new Button
                    {
                        Text = string.Format("rida {0} kohad {1}", r+1, k+1),
                        Name = string.Format("btn_{0}{1}", r, k),
                        Dock = DockStyle.Fill

                    };
                    this.tlp.Controls.Add(btn_tabel, k, r);

                }

            }
            //делаем чтобы кнопки были нормальные

            //btn_w = (int)(100 / kohad);
            //btn_h = (int)(100 / read);
            this.tlp.Dock = DockStyle.Fill;
            //this.tlp.Size = new System.Drawing.Size(tlp.ColumnCount * btn_w*4, tlp.RowCount*btn_h*4);
            this.Controls.Add(tlp);
        }



        private void MyForm_Click(object sender, EventArgs e)
        {
            Button btn_click = (Button)sender;//последная кнопка, которая была нажата и была сработана функция
            MessageBox.Show("Oli valitud "+btn_click.Text+" nupp");
        }
    }

}
