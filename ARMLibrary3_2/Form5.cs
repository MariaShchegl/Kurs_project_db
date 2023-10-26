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
using System.Security.Cryptography;

namespace ARMLibrary3_2
{
    public partial class Form5 : Form
    {
        static MySqlCommand cmd;

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Авторизация
            string strLogin = textBox1.Text;
            string strPassword = textBox2.Text;

            if (strLogin == "" || strPassword == "" || strPassword.Length < 5)
            {
                MessageBox.Show("Логин и пароль обязательны, пароль не меньше 5 знаков");
            }
            else
            {
                cmd = QueryDB.QueryResult("SELECT id_bibliot, password FROM bibliotekar WHERE login = '" + strLogin + "'");
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if (reader.GetString(1) == GetHash(strPassword))
                        {
                            Form1.idBibliot = reader.GetInt32(0);
                            (this.Owner as Form1).войтиToolStripMenuItem.Text = "Выйти";
                            (this.Owner as Form1).действияToolStripMenuItem.Visible = true;
                            (this.Owner as Form1).button4.Visible = true;
                            Form1.isAuthorize = true;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль!");
                    }
                }
                QueryDB.connectionClose();
            }
        }

        public static string GetHash(string password)
        {
            using (var hash = SHA1.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(x => x.ToString("X2")));
            }
        }
    }
}
