using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class bus : Form
    {
        public bus()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DELL LATITUDE\OneDrive\Documents\MaintanenceBd.mdf"";Integrated Security=True;Connect Timeout=30;Encrypt=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (busmark.SelectedIndex == -1 || bnumparc.Text == "" || bmatricul.SelectedIndex == -1 || bnumchassi.Text == "" || bmitrage.Text == "" || bcolor.Text == "")
            {
                MessageBox.Show("Missing information");
                    } else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into bustlb (busMarc,busnumparc,busMatricul,busnumch,busmitrag,buscolor) values(@bMc,@bnp,@bMt,@bnch,@bmtg,@bcol)", Con);
                    cmd.Parameters.AddWithValue("@bMc", busmark.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@bnp", bnumparc.Text);
                    cmd.Parameters.AddWithValue("@bMt", bmatricul.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@bnch", bnumchassi.Text);
                    cmd.Parameters.AddWithValue("@bmtg", bmitrage.Text);
                    cmd.Parameters.AddWithValue("@bcol", bcolor.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("bus Enregistrè");
                    Con.Close();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            }
        }
    }
}
