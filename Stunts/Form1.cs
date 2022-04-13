using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

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

            pictureBoxNoVideo.Visible = false;
            LoadData();
        }

        private string GetConnectionPath()
        {
            string path = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename={0}; Integrated Security = True; Connect Timeout = 30";

            string localPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Database\\DatabaseStunts.mdf";

            return string.Format(path, localPath);
        }

        private void LoadData()
        {
            List<string> rows = GetDataFromDatabase("Acrobatics");

            for (int i = 0; i < rows.Count; i++)
            {
                string[] data = rows[i].Split(';');
                stunts.Add(new Stunt(Convert.ToInt16(data[0]), data[1], Convert.ToInt16(data[2]) - 1, Convert.ToInt16(data[3]), data[4], data[5], data[6], data[7], Convert.ToBoolean(Convert.ToInt16(data[8])), data[9]));
                listBoxStunts.Items.Add(stunts[i].Name);
            }

            listBoxStunts.SelectedIndex = listBoxStunts.Items.Count - 1;
        }

        private void DatabaseHotReload()
        {
            stunts = new List<Stunt>();
            listBoxStunts.Items.Clear();
            LoadData();
        }

        private void ListBoxStuntsSelectedIndexChanged(object sender, EventArgs e)
        {
            SetInterfaceFromObjectData();

            webBrowserVideo.Visible = listBoxStunts.SelectedIndex != -1;
        }

        private void SetInterfaceFromObjectData()
        {
            //Listing stunts in listbox
            if (listBoxStunts.SelectedIndex != -1)
            {
                pictureBoxNoVideo.Visible = false;
                //Name
                textBoxName.Text = stunts[listBoxStunts.SelectedIndex].Name;
                //Difficulty progress bar
                progressBarDifficulty.Value = stunts[listBoxStunts.SelectedIndex].Difficulty * 10;
                //Difficulty mumeric
                numericUpDownDifficulty.Value = stunts[listBoxStunts.SelectedIndex].Difficulty;
                //Category
                comboBoxCategory.SelectedIndex = (int)stunts[listBoxStunts.SelectedIndex].Category;
                //Requirements 
                textBoxRequirements.Text = stunts[listBoxStunts.SelectedIndex].Requirements;
                //Instructions
                textBoxInstructions.Text = stunts[listBoxStunts.SelectedIndex].Instructions;
                //AdvancedTechniques
                textBoxAdvancedTechniques.Text = stunts[listBoxStunts.SelectedIndex].AdvancedTechniques;
                //Experiences
                textBoxExperiences.Text = stunts[listBoxStunts.SelectedIndex].Experiences;
                //Equipment
                checkBoxEquipment.Checked = stunts[listBoxStunts.SelectedIndex].Equipment;
                //VideoLink
                textBoxVideoLink.Text = stunts[listBoxStunts.SelectedIndex].VideoLink;
                //Video
                try
                {
                    webBrowserVideo.Navigate(stunts[listBoxStunts.SelectedIndex].VideoLink);
                }
                catch
                {
                    pictureBoxNoVideo.Visible = true;
                    pictureBoxNoVideo.Image = Image.FromFile("novideo.png");
                }


                double difficulty = Math.Ceiling((double)stunts[listBoxStunts.SelectedIndex].Difficulty / 3) - 1;

                comboBoxDifficulty.SelectedIndex = Convert.ToInt16(difficulty);
            }
        }

        private List<string> GetDataFromDatabase(string databaseName)
        {
            List<string> data = new List<string>();
            /*
            string query = $"SELECT * FROM {databaseName}";

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            sqlConnection.Open();

            DataTable dataTable = FillDataTable(query);

            SqlDataReader inputData = sqlCommand.ExecuteReader();

            try
            {
                data = ReadRows(inputData, dataTable);
            }
            catch
            {
                Notify("Data se nepovedla z tabulky přečíst.");
            }
            finally
            {
                sqlConnection.Close();
            }
            */
            return data;
        }

        private List<string> ReadRows(SqlDataReader inputData, DataTable dataTable)
        {
            List<string> rows = new List<string>();

            string row = "";

            while (inputData.Read())
            {
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    row += inputData[dataTable.Columns[i].ColumnName] + ";";
                }

                rows.Add(row);

                row = "";
            }

            return rows;
        }

        private DataTable FillDataTable(string query)
        {
            DataTable dataTable = new DataTable();

            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            //sqlDataAdapter.Fill(dataTable);

            sqlDataAdapter.Dispose();

            return dataTable;
        }

        private void Notify(string message)
        {
            MessageBox.Show(message);
        }

        private void DatabaseActionButtonsClick(object sender, EventArgs e)
        {
            string action = (sender as Button).Name.Substring(6);

            switch (action)
            {
                case "Add":
                    {
                        if (AreInputsCorrect())
                        {
                            string command = $"INSERT INTO Acrobatics (Name, Category, Difficulty, Requirements, Instructions, AdvancedTechniques, Experiences, Equipment, VideoLink) VALUES ('{textBoxName.Text}', '{comboBoxCategory.SelectedIndex + 1}', '{numericUpDownDifficulty.Value}', '{textBoxRequirements.Text}', '{textBoxInstructions.Text}', '{textBoxAdvancedTechniques.Text}', '{textBoxExperiences.Text}', '{Convert.ToInt32(checkBoxEquipment.Checked)}', '{textBoxVideoLink.Text}')";
                            ExecuteDatabaseAction(command);
                            DatabaseHotReload();
                        }

                        break;
                    }
                case "Edit":
                    {
                        if (listBoxStunts.SelectedIndex != -1 && AreInputsCorrect())
                        {
                            string command = $"UPDATE Acrobatics SET Name = '{textBoxName.Text}', Category = '{comboBoxCategory.SelectedIndex + 1}', Difficulty = '{numericUpDownDifficulty.Value}', Requirements = '{textBoxRequirements.Text}', Instructions = '{textBoxInstructions.Text}', AdvancedTechniques = '{textBoxAdvancedTechniques.Text}', Experiences = '{textBoxExperiences.Text}', Equipment = '{Convert.ToInt32(checkBoxEquipment.Checked)}', VideoLink = '{textBoxVideoLink.Text}' WHERE Id = '{stunts[listBoxStunts.SelectedIndex].Id}'";
                            ExecuteDatabaseAction(command);
                            DatabaseHotReload();
                        }
                        break;
                    }
                case "Delete":
                    {
                        if (listBoxStunts.SelectedIndex != -1)
                        {
                            string command = $"DELETE FROM Acrobatics WHERE Id='{stunts[listBoxStunts.SelectedIndex].Id}'";
                            ExecuteDatabaseAction(command);
                            DatabaseHotReload();
                        }
                        break;
                    }
            }
        }

        private bool AreInputsCorrect()
        {
            bool areInputsCorrect = true;

            if (textBoxName.Text.Length <= 3)
            {
                areInputsCorrect = false;
                MessageBox.Show("Jméno musí mít minimálně 3 znaky dlouhé.");
            }

            if (comboBoxDifficulty.SelectedIndex == -1 || comboBoxCategory.SelectedIndex == -1)
            {
                areInputsCorrect = false;
                MessageBox.Show("Obtížnost a kategorie jsou povinné.");
            }

            return areInputsCorrect;
        }

        private void ExecuteDatabaseAction(string command)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(command, sqlConnection);

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        private void NumericUpDownDifficultyValueChanged(object sender, EventArgs e)
        {
            progressBarDifficulty.Value = Convert.ToInt32(numericUpDownDifficulty.Value * 10);
        }

        private void ComboBoxDifficultySelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDownDifficulty.Value = (comboBoxDifficulty.SelectedIndex + 1) * 3 - 1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Uložit do souboru?", "Uložení", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                StreamWriter souborzapsani;
                if (DialogResult.OK == saveFileDialogSaveFile.ShowDialog())
                {
                    string fileextract = "Id;Name;Category;Difficulty;Requirements;Instructions;AdvancedTechniques;Experiences;Equipment;VideoLink" + Environment.NewLine;
                    foreach (Stunt stunt in stunts)
                    {
                        fileextract = stunt.Id + ";" + stunt.Name + ";" + stunt.Category + ";" + stunt.Difficulty + ";" + stunt.Requirements + ";" + stunt.Instructions + ";" + stunt.AdvancedTechniques + ";" + stunt.Experiences + ";" + stunt.Equipment + ";" + stunt.VideoLink + ";" + Environment.NewLine;
                    }

                    souborzapsani = new StreamWriter(saveFileDialogSaveFile.FileName);
                    souborzapsani.Write(fileextract);
                    souborzapsani.Close();
                }
            }
        }
    }
}
