using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looking_at_putting_arrays_in_data_grid_view
{
    public partial class Form1 : Form
    {
        string[] names = new string[3];
        int[] scores = new int[3];

        int num1 = 1;
        int num2 = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            names[0] =  "Lee";
            names[1] =  "Chloe" ;
            names[2] = "Dave" ;

            scores[0] = 76;
            scores[1] = 87;
            scores[2] = 65;
            //not sure what this does, all i know is that it adds 2 columns, and with my modification on the 4th line it ads x amount of rows, x = array length. (src https://stackoverflow.com/questions/46632384/how-to-insert-data-from-list-array-to-datagridview)
            dataGridView1.Columns.Add("C1", "Header " + num1);
            dataGridView1.Columns["C1"].DataPropertyName = "Property1";
            //dataGridView1.Columns.Add("C2", "Header 2");
            //dataGridView1.Columns["C2"].DataPropertyName = "Property2";
            dataGridView1.DataSource = scores.Select(y => new { Property1 = y }).ToList();
            //dataGridView1.DataSource = scores.Select(x => new { Property2 = x }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
