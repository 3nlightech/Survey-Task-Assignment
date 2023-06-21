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
    public partial class Survey : Form
    {

        string connString = "Data Source=DESKTOP-B34TMHJ;Initial Catalog=Pool_DB;Integrated Security=True";
        public Survey()
        {
            InitializeComponent();
        }

        private void Survey_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {
            label14.MaximumSize = new Size(200, 0);
            label14.AutoSize = true;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {


            // SqlConnection conn = new SqlConnection(connString);
            string name;
            string surname;
            string contact;
            int age;
            string food_Item1;
            string food_Item2;
            string food_Item3;
            string food_Item4;
            string food_Item5;
            string food_Item6;

            name = txt_FName.Text;
            surname = txt_Surname.Text;
            contact = txt_Phone.Text;
            age = Convert.ToInt32(txt_Age.Text);
            DateTime today = DateTime.Now.Date;


            food_Item1 = "Pizza";
            food_Item2 = "Pasta";
            food_Item3 = "Pap and Wors";
            food_Item4 = "Chicken Stirfry";
            food_Item5 = "Beef Stirfry";
            food_Item6 = "other";
            List<string> checkedCheckboxValues = new List<string>();

            CheckBox[] checkboxes = { chk_Pizza, chk_Pasta, chk_PnWors, chk_Chickensfry, chk_Beefsfry, chk_Other };
            
            foreach (CheckBox checkBox in checkboxes)
            {
                if (checkBox.Checked)
                {
                    checkedCheckboxValues.Add(checkBox.Text);
                }
            }
          using (SqlConnection conn = new SqlConnection(connString))
{
    conn.Open();

    foreach (string value in checkedCheckboxValues)
    {
        string statement = "exec dbo.StatsInfo @Surname, @FName, @Phone, @Today, @Age, @CheckboxValue, @RdoVal, @RdoVal2, @RdoVal3, @RdoVal4";

        using (SqlCommand sqlcomm = new SqlCommand(statement, conn))
        {
            // Set parameter values
            sqlcomm.Parameters.AddWithValue("@Surname", txt_Surname.Text);
            sqlcomm.Parameters.AddWithValue("@FName", txt_FName.Text);
            sqlcomm.Parameters.AddWithValue("@Phone", txt_Phone.Text);
            sqlcomm.Parameters.AddWithValue("@Today", today);
            sqlcomm.Parameters.AddWithValue("@Age", txt_Age.Text);
            sqlcomm.Parameters.AddWithValue("@CheckboxValue", value);
            sqlcomm.Parameters.AddWithValue("@RdoVal", Get_Rdo_Val());
            sqlcomm.Parameters.AddWithValue("@RdoVal2", Get_Rdo_Val2());
            sqlcomm.Parameters.AddWithValue("@RdoVal3", Get_Rdo_Val3());
            sqlcomm.Parameters.AddWithValue("@RdoVal4", Get_Rdo_Val4());

            sqlcomm.ExecuteNonQuery();
        }
    }

                MessageBox.Show("Survey Succesfully Completed");
                frm_Home home_scr = new frm_Home();
                this.Hide();
                home_scr.Show();
            }
            
        }

        private int Get_Rdo_Val()
        {
            if (rdo_SA1.Checked)

                return 1;

            else if (rdo_A1.Checked)

                return 2;

            else if (rdo_N1.Checked)

                return 3;

            else if (rdo_D1.Checked)

                return 4;
            else return 5;
        }
        private int Get_Rdo_Val2()
        {
            if (rdo_SA2.Checked)

                return 1;

            else if (rdo_A2.Checked)

                return 2;

            else if (rdo_N2.Checked)

                return 3;

            else if (rdo_D2.Checked)

                return 4;
            else return 5;
        }
        private int Get_Rdo_Val3()
        {
            if (rdo_SA3.Checked)

                return 1;

            else if (rdo_A3.Checked)

                return 2;

            else if (rdo_N3.Checked)

                return 3;

            else if (rdo_D3.Checked)

                return 4;
            else return 5;
        }
        private int Get_Rdo_Val4()
        {
            if (rdo_SA4.Checked)

                return 1;

            else if (rdo_A4.Checked)

                return 2;

            else if (rdo_N4.Checked)

                return 3;

            else if (rdo_D4.Checked)

                return 4;
            else return 5;
        }

        private void rdo_SA1_CheckedChanged(object sender, EventArgs e)
        {
           
        }


    }
}

