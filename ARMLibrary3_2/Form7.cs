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
    public partial class Form7 : Form
    {
        static MySqlCommand cmd;
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strPassport = textBox5.Text;
            string strChitB = textBox7.Text;
            string surname = textBox1.Text;
            string name = textBox2.Text;
            string middle_name = textBox3.Text;
            string address = textBox4.Text;
            string phone = textBox6.Text;
            int idLichn;

            if (strPassport == "" || strChitB == "" || surname == "" || name == "" || middle_name == "" || address == "" || phone == "")
            {
                MessageBox.Show("Поля не могут быть пусты");
            }
            else
            {
                QueryDB.noQueryDB("INSERT INTO lichn_inf_chit(surname, name, second_name, address, phone, passport) VALUES ('" + surname + "', '" + name + "', '" + middle_name + "', '" + address + "', '" + phone + "', '" + strPassport + "')");
                
                cmd = QueryDB.QueryResult("SELECT LAST_INSERT_ID()");
                using (DbDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    idLichn = reader.GetInt32(0);
                }
                QueryDB.connectionClose();

                QueryDB.noQueryDB("INSERT INTO chitatel(lichn_inf_c_id, N_chit_bileta) VALUES (" + idLichn + ", '" + strChitB + "')");

                this.Dispose();
            }
        }
    }
}
