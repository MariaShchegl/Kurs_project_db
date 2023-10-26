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
    public partial class Form1 : Form
    {
        static MySqlCommand cmd;
        static List<string> result = new List<string>();
        public static bool isAuthorize = false;
        public static int idBibliot = 0;
        public static int idZakaz;

        public Form1()
        {
            InitializeComponent();
        }

        private void добавитьЧитателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void войтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Вход/Выход */
            if (isAuthorize)
            {
                isAuthorize = false;
                idBibliot = 0;
                войтиToolStripMenuItem.Text = "Войти";
                действияToolStripMenuItem.Visible = false;
                button4.Visible = false;
            }
            else
            {
                Form5 fr5 = new Form5();
                fr5.Owner = this;
                fr5.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Поиск
            string test;
            string request = textBox1.Text;

            checkedListBox1.Items.Clear();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            if (request != "")
            {

                string[] mass_req = request.Split(' ');

                for (int i = 0; i < mass_req.Length; i++)
                {
                    cmd = QueryDB.QueryResult("SELECT book.id_book, book.name_book, author.author, zhanr.zhanr FROM book INNER JOIN author ON author.id_author = book.author_id INNER JOIN zhanr ON zhanr.id_zhanr = book.zhanr_id WHERE author_id = (SELECT id_author FROM author WHERE author like '%" + mass_req[i] + "%')");

                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                test = "";
                                for (int j = 0; j < reader.FieldCount; j++)
                                    test += reader.GetString(j) + " ";
                                result.Add(test);
                            }
                        }
                    }
                    QueryDB.connectionClose();

                    cmd = QueryDB.QueryResult("SELECT book.id_book, book.name_book, author.author, zhanr.zhanr FROM book INNER JOIN author ON author.id_author = book.author_id INNER JOIN zhanr ON zhanr.id_zhanr = book.zhanr_id WHERE zhanr_id = (SELECT id_zhanr FROM zhanr WHERE zhanr like '%" + mass_req[i] + "%')");

                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                test = "";
                                for (int j = 0; j < reader.FieldCount; j++)
                                    test += reader.GetString(j) + " ";
                                result.Add(test);
                            }
                        }
                    }
                    QueryDB.connectionClose();

                    cmd = QueryDB.QueryResult("SELECT book.id_book, book.name_book, author.author, zhanr.zhanr FROM book INNER JOIN author ON author.id_author = book.author_id INNER JOIN zhanr ON zhanr.id_zhanr = book.zhanr_id WHERE name_book like '%" + mass_req[i] + "%'");

                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                test = "";
                                for (int j = 0; j < reader.FieldCount; j++)
                                    test += reader.GetString(j) + " ";
                                result.Add(test);
                            }
                        }
                    }
                    QueryDB.connectionClose();
                }

                if (result.Count == 0)
                {
                    checkedListBox1.Items.Add("Ничего не найдено!");
                }
                else
                {
                    if (idBibliot == 0)
                        button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;

                    result = result.Distinct().ToList();

                    for (int i = 0; i < result.Count; i++)
                        checkedListBox1.Items.Add(result[i]);
                }
            }
            else
            {
                checkedListBox1.Items.Add("Введите критерии поиска (название, жанр, автор)!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Подробнее
            Form2 fr2 = new Form2();
            fr2.Owner = this;
            fr2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Заказать
            idZakaz = 0;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                if (checkedListBox1.GetItemChecked(i))
                {
                    cmd = QueryDB.QueryResult("SELECT COUNT(*) FROM zakazi");
                    using (DbDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        idZakaz = reader.GetInt32(0) + 1;
                    }
                    QueryDB.connectionClose();
                }

            if (idZakaz != 0)
            {
                Form3 fr3 = new Form3();
                fr3.Owner = this;
                fr3.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Выдать
            Form4 fr4 = new Form4();
            fr4.Owner = this;
            fr4.Show();
        }

        private void заказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Заказы
            Form6 fr6 = new Form6();
            fr6.Show();
        }

        private void добавитьЧитателяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.Show();
        }

        private void просмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr4 = new Form4();
            fr4.button2.Visible = false;
            fr4.Show();
        }

        private void должникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void принятьКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
