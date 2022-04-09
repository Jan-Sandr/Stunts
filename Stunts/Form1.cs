using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic; //list
using System.Data;

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
                //Name
                textBoxName.Text = stunts[listBoxStunts.SelectedIndex].Name;
                //Difficulty progress bar
                progressBarDifficulty.Value = stunts[listBoxStunts.SelectedIndex].Difficulty * 10;
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
                //Difficulty

                double difficulty = Math.Ceiling((double)stunts[listBoxStunts.SelectedIndex].Difficulty / 3) - 1;

                comboBoxDifficulty.SelectedIndex = Convert.ToInt16(difficulty);
            }
        }


        private List<string> GetDataFromDatabase(string databaseName)
        {
            List<string> data = new List<string>();

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

            sqlDataAdapter.Fill(dataTable);

            sqlDataAdapter.Dispose();

            return dataTable;
        }

        private void Notify(string message)
        {
            MessageBox.Show(message);
        }
    }
}
