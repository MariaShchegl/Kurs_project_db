using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace ARMLibrary3_2
{
    public partial class Form2 : Form
    {
        static MySqlCommand cmd;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < (this.Owner as Form1).checkedListBox1.Items.Count; i++)
                if ((this.Owner as Form1).checkedListBox1.GetItemChecked(i))
                {
                    string[] strSplit = (this.Owner as Form1).checkedListBox1.Items[i].ToString().Split(' ');
                    cmd = QueryDB.QueryResult("SELECT book.name_book, author.author, zhanr.zhanr, izdatelstvo.izdatelstvo, book.year, yazick.yazick, ceny.cena, book.description FROM book INNER JOIN author ON author.id_author = book.author_id INNER JOIN izdatelstvo ON izdatelstvo.id_izdatelstvo = book.izdatelstvo_id INNER JOIN zhanr ON zhanr.id_zhanr = book.zhanr_id INNER JOIN yazick ON yazick.id_yazick = book.yazick_id INNER JOIN ceny ON ceny.id_cena = book.cena_id WHERE book.id_book = " + strSplit[0]);
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                listBox1.Items.Add("Название:\t" + reader.GetString(0));
                                listBox1.Items.Add("Автор:\t\t" + reader.GetString(1));
                                listBox1.Items.Add("Жанр:\t\t" + reader.GetString(2));
                                listBox1.Items.Add("Издательство:\t" + reader.GetString(3));
                                listBox1.Items.Add("Год:\t\t" + reader.GetDateTime(4).Year.ToString());
                                listBox1.Items.Add("Язык:\t\t" + reader.GetString(5));
                                listBox1.Items.Add("Цена:\t\t" + reader.GetString(6));
                                listBox1.Items.Add("Описание:\t" + reader.GetString(7));
                                listBox1.Items.Add("");
                            }
                        }
                    }
                    QueryDB.connectionClose();
                }
        }
    }
}
