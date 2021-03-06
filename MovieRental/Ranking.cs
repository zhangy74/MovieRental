﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace MovieRental
{
    public partial class Ranking : UserControl
    {
        private static Ranking _instance;
        public static Ranking Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Ranking();
                return _instance;
            }
        }
        public Ranking()
        {
            InitializeComponent();
        }

        private void Ranking_Load(object sender, EventArgs e)
        {

            update();                   
        }

        public void update() {
            panelInRanking.Controls.Clear();
            //MessageBox.Show("update");
            SqlConnection connection = new SqlConnection(Form4.connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT top 5 Poster, MovieName, M.MID, rate from(Select AVG(Rating) as rate, MID FROM MovieRating group by MID) as T , Movie M where T.MID = M.MID Order by rate DESC", connection);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            int i = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                //foreach (DataColumn column in dataTable.Columns)
                //{
                MovieBoxRent movieBoxRent = new MovieBoxRent(row["MID"].ToString());
                movieBoxRent.createNewBox(panelInRanking, i, 0);
                //MessageBox.Show(row["MID"].ToString().Trim());
                if (row["Poster"] == DBNull.Value)
                {
                    //MessageBox.Show("image null");
                    //MemoryStream ms = new MemoryStream((byte[])Properties.Resources.ResourceManager.GetObject("001"));
                    movieBoxRent.CreatePictureImage((Image)Properties.Resources.ResourceManager.GetObject("Noimage"));
                }
                else
                {
                    byte[] ImageArray = (byte[])row["Poster"];
                    Image image = Image.FromStream(new MemoryStream(ImageArray));

                    movieBoxRent.CreatePictureImage(image);
                }

                //movieBoxRent.CreatePicture(row["MID"].ToString().Trim());
                movieBoxRent.CreateName(row["MovieName"].ToString());
                //MessageBox.Show(row["MovieName"].ToString());
                movieBoxRent.CreateScore(row["rate"].ToString());
                movieBoxRent.CreateButtonRent();
                Console.WriteLine(row["MovieName"]);
                i++;
                //}
            }
            connection.Close();

        }

    }
}
