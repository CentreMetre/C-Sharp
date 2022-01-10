using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looking_at_coordinates_in_datagridview
{
    public partial class Form1 : Form
    {
        //string[] namesArray = { "Alex", "Barry", "Chloe" };
        //int[] scoresArray = { 86, 48, 95 };

        List<string> namesList = new List<string>();
        List<string> scoresList = new List<string>();
        List<double> scoresListDouble = new List<double>();

        int currentStudentIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int listCount = namesList.Count;
            for (int i = 0; i < listCount; i++)
            {
                dgv1.Rows.Add();
                dgv1.Rows[i].Cells[0].Value = namesList[i];
                dgv1.Rows[i].Cells[1].Value = scoresList[i];
                
            }
            button1.Enabled = false;
            //dgv1.
        }

        private void txtboxInputName_TextChanged(object sender, EventArgs e)
        {
            /* not working
            lblScoreOfStudent.Text = "";
            string name = lblScoreOfStudent.Text;
            lblScoreOfStudent.Text = "Score of " + name;
            */
        }

        private void checkboxReady_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxReady.Checked == false)
            {
                button1.Enabled = false;
            }
            else if (checkboxReady.Checked == true)
            {
                button1.Enabled = true;
            }
        }

        private void butInputCurInfo_Click(object sender, EventArgs e)
        {
            string Name = txtboxInputName.Text;
            string Score = txtboxInputScore.Text;
            double scoreDouble = 0; 

            
            /*switch ()*/
            try
            {
                scoreDouble = Convert.ToDouble(txtboxInputScore.Text);
            }
            catch (Exception)
            {
                lblErrorOutput.Text = "Could not convert score into a double";
            }
            namesList.Add(Name);
            scoresList.Add(Score);
            scoresListDouble.Add(scoreDouble);
            currentStudentIndex++;
        }
    }
}
