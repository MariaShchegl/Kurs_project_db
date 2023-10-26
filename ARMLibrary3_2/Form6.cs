using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace ARMLibrary3_2
{
    public partial class Form6 : Form
    {
        static MySqlCommand cmd;

        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Добавить читателя
            Form7 fr7 = new Form7();
            fr7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Выдать
            Form4 fr4 = new Form4();
            Form4.isZakaz = true;
            fr4.Owner = this;
            fr4.Show();
        }

        public void Form6_Shown(object sender, EventArgs e)
        {
            string lastContact = "";

            checkedListBox1.Items.Clear();

            cmd = QueryDB.QueryResult("SELECT zakazi.id_zak, zakazi.id_book, zakazi.contact_inf, book.name_book, author.author, zhanr.zhanr FROM zakazi INNER JOIN book ON book.id_book = zakazi.id_book INNER JOIN author ON author.id_author = book.author_id INNER JOIN zhanr ON zhanr.id_zhanr = book.zhanr_id ORDER BY zakazi.id_zak");
            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (lastContact != reader.GetString(2))
                        {
                            lastContact = reader.GetString(2);
                            checkedListBox1.Items.Add(lastContact);
                        }
                        checkedListBox1.Items.Add(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(3) + " " + reader.GetString(4) + " " + reader.GetString(5));
                    }
                }
            }
            QueryDB.connectionClose();
        }
    }
}
