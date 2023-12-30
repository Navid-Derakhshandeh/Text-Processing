using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;

namespace textprocessingtest1
{
    public partial class Form1 : Form
    {
        public int c;
        public string d;
        string connString = @"Data Source=DESKTOP-21H6HAU\DESKTOP;Initial Catalog=scraper;Integrated Security=True;
                                Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        
        
        SqlConnection conn;
        
        public Form1()
        {
            
            InitializeComponent();
        }
        private void scrape()
        {
            ChromeOptions OP = new ChromeOptions();
            OP.AddArgument("--headless");
            IWebDriver Dri = new ChromeDriver(/*options*/);
            Dri.Navigate().GoToUrl(txtLink.Text);

            //"https://en.wikipedia.org/wiki/Knapsack_problem"

            var Para = Dri.FindElements(By.TagName("html"));
            int c = Para.Count;

            var FPara = Para.First(e => !string.IsNullOrEmpty(e.Text));
            d = FPara.Text;

        } 
        private void button1_Click(object sender, EventArgs e)
        {
            scrape();

            textMain.Text = d;

            txtP.Text = c.ToString();

            string a = textMain.Text.ToString();
            if(a.Contains("knapsack")==true)
            {
                string k = "Knapsack";
                listContain.Items.Add($"Knapsack word is found");
                SqlCommand command;
                string insert = @"insert into MWS(Date_Added, Link_Added, Match)

                               values(@Date_Added, @Link_Added, @Match)";
                using (conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        command = new SqlCommand(insert, conn);
                        command.Parameters.AddWithValue(@"Date_Added", txtDate.Text);
                        command.Parameters.AddWithValue(@"Link_Added", txtLink.Text);
                        command.Parameters.AddWithValue(@"Match", k);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }


                }
            }
            if(a.Contains("items")==true)
            {
                string i = "Items";
                listContain.Items.Add($"Items Word is Found");
                SqlCommand command;
                string insert = @"insert into MWS(Date_Added, Link_Added, Match)

                               values(@Date_Added, @Link_Added, @Match)";
                using (conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        command = new SqlCommand(insert, conn);
                        command.Parameters.AddWithValue(@"Date_Added", txtDate.Text);
                        command.Parameters.AddWithValue(@"Link_Added", txtLink.Text);
                        command.Parameters.AddWithValue(@"Match", i);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }


                }
            }
            else
            {
                listContain.Items.Add($"word is not found");
                string b = "empty";
                SqlCommand command;
                string insert = @"insert into MWS(Date_Added, Link_Added, Match)

                               values(@Date_Added, @Link_Added, @Match)";
                using (conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        command = new SqlCommand(insert, conn);
                        command.Parameters.AddWithValue(@"Date_Added", txtDate.Text);
                        command.Parameters.AddWithValue(@"Link_Added", txtLink.Text);
                        command.Parameters.AddWithValue(@"Match", b);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }


                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            DateTime DT = DateTime.Now;
            txtDate.Text = (DT.ToString("MM/dd/yyyy HH:mm:ss"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void pannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Summary frm = new Summary();
            frm.Show();
        }
    }
}
