using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form9._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
           // this.CenterToScreen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 10)
            {
                Button button1 = new Button(); //založení instance tlačítka
                button1.DialogResult = DialogResult.OK;//nastavení výsledku po zobrazení
                button1.Location = new Point(40, 189);//umístění tlačítka, souřadnice x,y
                button1.Size = new Size(75, 23);//velikost tlačítka
                button1.Text = "Ulož";
                Button button2 = new Button();//založení instance tlačítka
                button2.DialogResult = DialogResult.Cancel;
                button2.Location = new Point(148, 188);
                button2.Size = new Size(75, 23);
                button2.Text = "Cancel";
                TextBox textBox = new TextBox();//založení instance TextBoxu
                textBox.Location = new Point(49, 40);
                textBox.Size = new Size(188, 22);
                textBox.Text = label1.Text;
                Form form2 = new Form(); //založení instance formuláře
                form2.Location = new Point(0, 1000);
                form2.Controls.Add(textBox);//přidání komponenty na formulář
                form2.Controls.Add(button2);
                form2.Controls.Add(button1);
                form2.ActiveControl = textBox;
                form2.AcceptButton = button1;
                textBox.Clear();
                form2.Text = "Nabídka";
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Add(textBox.Text);
                }
                i++;
            }
            
        }
    }
}
