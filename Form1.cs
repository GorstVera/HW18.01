using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HW_18._01
{
    public partial class Form1 : Form
    {
        WorkTable table;
        
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            table = new WorkTable(dataGridView1);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.StartWork();
        }

        private void СhoiceTable_Button_Click(object sender, EventArgs e)
        {
            table.ChoiceTable(comboBox1.SelectedIndex);
        }

        private void SaveChange_Button_Click(object sender, EventArgs e)
        {
            table.SaveChange(comboBox1.SelectedIndex);
        }

        private void Sort_Button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Введите параметр для поиска");
                return;
            }         
            table.FilterTable(comboBox2.SelectedIndex, textBox1.Text);
        }
    }
}
