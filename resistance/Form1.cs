using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resistance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            amperage.Location = new Point(280, 91);
            voltage.Location = new Point(500, 91);

        }

        

        private void calcullink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            const string message =
            "Открыть сайт, с формулами рассчёта? ";
            const string caption = "Открытие ссылки!";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
         
            if (result == DialogResult.Yes)
            {
                Process process = System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://kupi-elektriku.ru/izmereniya-i-raschyot/kal-kulyator-soprotivleniya-onlayn-formuly-rascheta-dlya-resheniya-zadach/",
                    UseShellExecute = true
                });
            }
            else
            {
              
            }
            

        }
        

        int y = 91;
        double R;
        
        private void calculate_Click(object sender, EventArgs e)
        {
            double I = Convert.ToDouble(amperage.Text);
           
            double U = Convert.ToDouble(voltage.Text);
            MessageBox.Show(""+ I + ","+ U + ".");
            R = U / I;

            MessageBox.Show("Сопротивление =" + R +" Ом\n");
            /*
             вот это пример, по которому можно что-то придумать, но я не понимаю что он делает, как рабоатет...
            for (int n = 0; n < i; n++)//0...23
            {
                string s = Convert.ToString(n);
                TextBox tb2 = (TextBox)(from t in this.Controls.OfType<TextBox>() where t.Name == "textBox" + s select t).First();
                string st2 = tb2.Text;
                TextBox tb1 = (TextBox)(from t in this.Controls.OfType<TextBox>() where t.Name == "textBox" + s + s select t).First();
                string st1 = tb1.Text;
                label.Text = label.Text + Convert.ToString(Class1.R(Convert.ToDouble(st1), Convert.ToDouble(st2)));

            }
            */
            // int i = Convert.ToInt32(textBox1.Text);


        }

        // int i = 1, o = 1, p = 1;
        int k = 1;
        short s = 1; //количество строк (элементов электроцепи)


        private void addstring_Click(object sender, EventArgs e)
        {
            if (s <= 19)
            {

                k++;
                label1.Text = "f" + k + "+";



                addstring.Top += 50;
                calculate.Top += 50;
                s++; // увилечение переменной, по нажатию кнопки "Добавить элемент"
                y += 50;


                TextBox text;
                text = new TextBox();
                text.Location = new Point(12, y);
                text.Size = new Size(215, 25);
                text.Name = "discript" + s;
                this.Controls.Add(text);

                // MessageBox.Show("yop");

                TextBox amperage;
                amperage = new TextBox();
                amperage.Location = new Point(280, y);
                amperage.Size = new Size(180, 25);
                amperage.Name = "amperage" + s;
                this.Controls.Add(amperage);

                TextBox voltage;
                voltage = new TextBox();
                voltage.Location = new Point(500, y);
                voltage.Size = new Size(180, 25);
                voltage.Name = "voltage" + s;
                this.Controls.Add(voltage);

                MessageBox.Show("" + s + "");
            }

            else 
            {
                MessageBox.Show("Достигнуто ограничение количества элементов элетроцепи.");
            }

          
            /* int i = 1, o =1, p=1, i1=1;

            i += 1;
            o += 1;
            p += 1;
            i1++;

            string s1 = i.ToString();
            string s2 = o.ToString();
            string s3 = p.ToString(); */

            // Convert.ToBase64String
            // MessageBox.Show("s=" s, "\n y=" y);
            // descript2.Enabled = true;

 // "\n o= " s2 "\n p= " s3);
                                 //MessageBox.Show(s);






            // this.Controls.Add();
            // Text = new amperage();


            // TextBox amperagenew;
            /* amperage.Top += 50;
               voltage.Top += 50;
               descript.Top += 50;
            */

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
