using System.Collections;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string fname = firstNameTxt.Text;
            string lname = lastNameTxt.Text;
            string[] lines = textBox1.Lines;
            ArrayList subjects = new ArrayList();
            foreach (string line in lines)
            {
                subjects.Add(line);
            }
            bool confirmTagCheck = confirmTag.Checked;
            if (confirmTagCheck)
            {
                finalResult.Text = $"Student Data: \n\n Name: {fname} {lname}\n";

                if (subjects.Count > 0)
                {
                    finalResult.Text += "Subject Selected:\n";

                    foreach (string subject in subjects)
                    {
                        finalResult.Text += $"{subject}\n";
                    }
                }
                else
                {
                    finalResult.Text += "No subjects selected\n";
                }
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}