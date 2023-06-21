using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Test_Assignment
{
    public partial class frm_Home : Form
    {
        string connString = "Data Source=DESKTOP-B34TMHJ;Initial Catalog=Pool_DB;Integrated Security=True";
        string Total_number;
        string AVG_number;
        string Max_number;
        string Min_number;
        string Eat_pizza;
        string Eat_pasta;
        string Eat_papnwors;
        string Eatout_AVG;
        string Watchmovie_AVG;
        string WatchTV_AVG;
        string Listenradio_AVG;
        decimal Pizza_percent;
        decimal Pasta_percent;
        decimal Papwors_percent;

        public frm_Home()
        {
            InitializeComponent();
        }

        private void btn_Survey_Click(object sender, EventArgs e)
        {
            Survey surveyForm = new Survey();
            surveyForm.Show();
            this.Hide();
        }
        
        private void Btn_Results_Click(object sender, EventArgs e)
        {
           

            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand("retrieveInfo", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader rd = command.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                Total_number = rd["Total"].ToString();
                            }
                            if (rd.NextResult() && rd.Read())
                            {
                                AVG_number = rd["Average"].ToString();
                            }
                            if (rd.NextResult() && rd.Read())
                            {
                                Max_number = rd["Maxi"].ToString();
                            }
                            if (rd.NextResult() && rd.Read())
                            {
                                Min_number = rd["Mini"].ToString();
                            }
                            if (rd.NextResult() && rd.Read())
                            {
                                Eat_pizza = rd["EatPizza"].ToString();
                                Pizza_percent = (int.Parse(Eat_pizza) * int.Parse(Total_number)) / 100;
                                DisplayTextBox.Text = (Pizza_percent).ToString();
                            }
                            if (rd.NextResult() && rd.Read())
                            {
                                Eat_pasta = rd["EatPasta"].ToString();
                                Pasta_percent = (int.Parse(Eat_pasta) * int.Parse(Total_number))/100;
                                DisplayTextBox.Text = Pizza_percent.ToString();
                            }
                            if (rd.NextResult() && rd.Read())
                            {
                                Eat_papnwors = rd["EatPapWors"].ToString();
                                Papwors_percent = (int.Parse(Eat_papnwors) * int.Parse(Total_number)) / 100;
                                DisplayTextBox.Text = Papwors_percent.ToString();
                            }
                            if (rd.NextResult() && rd.Read())
                            {
                                Eatout_AVG = rd["EatoutAVG"].ToString();
                            }
                            if (rd.NextResult() && rd.Read())
                            {
                                Watchmovie_AVG = rd["WatchMovieAVG"].ToString();
                            }
                            if (rd.NextResult() && rd.Read())
                            {
                                WatchTV_AVG = rd["WatchTVAVG"].ToString();
                            }
                            if (rd.NextResult() && rd.Read())
                            {
                                Listenradio_AVG = rd["ListenRadioAVG"].ToString();
                               
                            }
                        }

                    }

                    MessageBox.Show("Success");
                }
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            frm_Surveyresults survey_res = new frm_Surveyresults();
            survey_res.res1 = Total_number;
            survey_res.res2 = AVG_number;
            survey_res.res3 = Max_number;
            survey_res.res4 = Min_number;
            survey_res.res5 = Eat_pizza + " %";
            survey_res.res6 = Eat_pasta + " %";
            survey_res.res7 = Eat_papnwors + " %";
            survey_res.res8 = Eatout_AVG;
            survey_res.res9 = Watchmovie_AVG;
            survey_res.res10 = WatchTV_AVG;
            survey_res.res11 = Listenradio_AVG;

            survey_res.Show();
        }
    }
}
