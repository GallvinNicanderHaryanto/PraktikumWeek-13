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

namespace PraktikumWeek_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtTypePemain = new DataTable();
 
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM dt_type";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain);
            IsiDataPemain(0);
        }
        public void IsiDataPemain(int Poisisi)
        {
            textBox1.Text = dtTypePemain.Rows[0][0].ToString();
            textBox2.Text = dtTypePemain.Rows[0][1].ToString();
            comboBox1.Text = dtTypePemain.Rows[0][2].ToString();
            textBox4.Text = dtTypePemain.Rows[0][3].ToString();
            comboBox2.Text = dtTypePemain.Rows[0][4].ToString();
            numericUpDown1.Text = dtTypePemain.Rows[0][5].ToString();                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtTypePemain.Rows.Count - 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IsiDataPemain(- 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IsiDataPemain(+ 1);
        }
    }
}
