using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMLibrary3_2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Окончание заказа
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите данные");
                return;
            }

            for (int i = 0; i < (this.Owner as Form1).checkedListBox1.Items.Count; i++)
                if ((this.Owner as Form1).checkedListBox1.GetItemChecked(i))
                {
                    string[] strSplit = (this.Owner as Form1).checkedListBox1.Items[i].ToString().Split(' ');
                    QueryDB.noQueryDB("INSERT INTO zakazi VALUES(" + Form1.idZakaz + ", " + strSplit[0] + ", '" + textBox1.Text + "', '" + DateTime.Now.ToString("hh:mm:ss") + "')");
                }

            this.Hide();
        }
    }
}
