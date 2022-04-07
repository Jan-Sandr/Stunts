﻿using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic; //list

namespace Stunts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection;

        string connectionPath = string.Empty;

        List<Stunt> stunts = new List<Stunt>(); 

        private void ApplicationLoaded(object sender, EventArgs e)
        {
            connectionPath = GetConnectionPath();

            sqlConnection = new SqlConnection(connectionPath);

            sqlConnection.Open();

            sqlConnection.Close();
        }

        private string GetConnectionPath()
        {
            string path = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename={0}; Integrated Security = True; Connect Timeout = 30";

            string localPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Database\\DatabaseStunts.mdf";

            return string.Format(path, localPath);
        }

        private void listBoxStunts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Listing stunts in listbox
            if (listBoxStunts.SelectedIndex != -1)
            {
                //Name
                textBoxName.Text = stunts[listBoxStunts.SelectedIndex].Name;
                //Difficulty progress bar
                progressBarDifficulty.Value = stunts[listBoxStunts.SelectedIndex].Difficulty * 10;
                //Category
                comboBox2Category.SelectedIndex = stunts[listBoxStunts.SelectedIndex].Category;
                //Requirements 
                textBoxRequirements.Text = stunts[listBoxStunts.SelectedIndex].Requirements;
                //Instructions
                textBoxInstructions.Text = stunts[listBoxStunts.SelectedIndex].Instructions;
                //AdvancedTechniques
                textBoxAdvancedTechniques.Text = stunts[listBoxStunts.SelectedIndex].AdvancedTechniques;
                //Experiences
                textBoxExperiences.Text = stunts[listBoxStunts.SelectedIndex].Experiences;
            }
        }
    }
}
