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


namespace Test_Assignment
{
    public partial class frm_Surveyresults : Form
    {
        string connString = "Data Source=DESKTOP-B34TMHJ;Initial Catalog=Pool_DB;Integrated Security=True";
        private List<string> sqlStatements;

        public string res1 { get; set; }
        public string res2 { get; set; }
        public string res3 { get; set; }
        public string res4 { get; set; }
        public string res5 { get; set; }
        public string res6 { get; set; }
        public string res7 { get; set; }
        public string res8 { get; set; }
        public string res9 { get; set; }
        public string res10 { get; set; }
        public string res11 { get; set; }
        

        public frm_Surveyresults()
        {
            InitializeComponent();
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Surveyresults_Click(object sender, EventArgs e)
        {

        }

        private void frm_Surveyresults_Load(object sender, EventArgs e)
        {
            textBox1.Text = res1;
            textBox2.Text = res2;
            textBox3.Text = res3;
            textBox4.Text = res4;
            textBox5.Text = res5;
            textBox6.Text = res6;
            textBox7.Text = res7;
            textBox8.Text = res8;
            textBox9.Text = res9;
            textBox10.Text = res10;
            //textBox11.Text = res11;

        }
    }
}
            
        


        
