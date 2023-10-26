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
    public partial class Form4 : Form
    {
        static MySqlCommand cmd;
        public static bool isZakaz = false;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            cmd = QueryDB.QueryResult("SELECT chitatel.id_chitatel, chitatel.N_chit_bileta, lichn_inf_chit.passport FROM chitatel INNER JOIN lichn_inf_chit ON lichn_inf_chit.id_lichn_inf_ch = chitatel.lichn_inf_c_id");

            using (DbDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetString(0) + " : " + reader.GetString(1) + "  |  " + reader.GetString(2));
                    }
                }
            }
            QueryDB.connectionClose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Поиск
            string str = textBox1.Text;
            for (int i = 0; i < comboBox1.Items.Count;  i++)
            {
                if (str == comboBox1.Items[i].ToString().Split(' ')[2] || str == comboBox1.Items[i].ToString().Split(' ')[4])
                {
                    comboBox1.SelectedIndex = i;
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Выдать
            if (comboBox1.SelectedItem != null)
            {
                int idChit = Convert.ToInt32(comboBox1.SelectedItem.ToString().Split(' ')[0]);
                int idZak = 1, idBook;
                bool fl = false;

                if (isZakaz)
                {
                    for (int i = 0; i < (this.Owner as Form6).checkedListBox1.Items.Count; i++)
                        if ((this.Owner as Form6).checkedListBox1.GetItemChecked(i))
                        {
                            idZak = Convert.ToInt32((this.Owner as Form6).checkedListBox1.Items[i].ToString().Split(' ')[0]);
                            idBook = Convert.ToInt32((this.Owner as Form6).checkedListBox1.Items[i].ToString().Split(' ')[1]);
                            QueryDB.noQueryDB("INSERT INTO knigi_na_rukax(book_id, chitatel_id, bibliotekar_id, data_vidachi, data_vozvrata) VALUES(" + idBook + ", " + idChit + ", " + Form1.idBibliot + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.AddDays(7).ToString("yyyy-MM-dd") + "')");
                            fl = true;
                        }
                    if (fl)
                    {
                        QueryDB.noQueryDB("DELETE FROM zakazi WHERE id_zak = " + idZak.ToString());
                    }
                    isZakaz = false;
                    (this.Owner as Form6).Form6_Shown(null, null);
                }
                else
                {
                    for (int i = 0; i < (this.Owner as Form1).checkedListBox1.Items.Count; i++)
                        if ((this.Owner as Form1).checkedListBox1.GetItemChecked(i))
                        {
                            idBook = Convert.ToInt32((this.Owner as Form1).checkedListBox1.Items[i].ToString().Split(' ')[0]);
                            QueryDB.noQueryDB("INSERT INTO knigi_na_rukax(book_id, chitatel_id, bibliotekar_id, data_vidachi, data_vozvrata) VALUES(" + idBook + ", " + idChit + ", " + Form1.idBibliot + ", '" + DateTime.Now.ToString("yyyy-mm-dd") + "', '" + DateTime.Now.AddDays(7).ToString("yyyy-mm-dd") + "')");
                        }
                }

                this.Dispose();
            }
            else
            {
                MessageBox.Show("Выберите читателя");
            }
        }
    }
}
