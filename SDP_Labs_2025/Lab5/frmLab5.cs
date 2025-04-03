using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SDP_EntityModels;

namespace SDP_Labs_2025.Lab5
{
    public partial class frmLab5 : Form
    {
        public frmLab5()
        {
            InitializeComponent();
        }

        private async void frmLab5_Load(object sender, EventArgs e)
        {
            try
            {
                APICaller apiCaller = new APICaller();
                String jsonString = await apiCaller.GetApiResponse("/api/SimpleGetAPI/GetCustomerData");
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonString);
                dgvCustomerDetails.DataSource = dt;
                dt.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async void butSearch_Click(object sender, EventArgs e)
        {
            try
            {
                APICaller apiCaller = new APICaller();
                String jsonString;
                if (txtCustomerName.Text == "")
                {
                    jsonString = await apiCaller.GetApiResponse("/api/SimpleGetAPI/GetCustomerData");
                }
                else
                {
                    jsonString = await apiCaller.GetApiResponse($"/api/SimpleGetAPI/GetSpecificCustomerData?customerFirstName={txtCustomerName.Text}");
                } 
                DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonString);
                dgvCustomerDetails.DataSource = dt;
                dt.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            };
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            DataTable dtUpdated = (DataTable)dgvCustomerDetails.DataSource;
            dtUpdated = dtUpdated.GetChanges();

            if (dtUpdated != null)
            {
                int rowsUpdated = await UpdateCustomerDataToAPI(dtUpdated);
                if (rowsUpdated > 0)
                {
                    dtUpdated.AcceptChanges();
                    dgvCustomerDetails.DataSource = dtUpdated.Copy();
                }
                MessageBox.Show($"{rowsUpdated} rows updated successfully.");
            }
        }

        private async Task<int> UpdateCustomerDataToAPI(DataTable dtUpdated)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]);

                    // Serialize DataTable to JSON
                    DataTable dtAdded = dtUpdated.GetChanges(DataRowState.Added);
                    string jsonAdded = JsonConvert.SerializeObject(dtAdded, Formatting.Indented);
                    DataTable dtModified = dtUpdated.GetChanges(DataRowState.Modified);
                    string jsonModified = JsonConvert.SerializeObject(dtModified, Formatting.Indented);
                    DataTable dtDeleted = dtUpdated.GetChanges(DataRowState.Deleted);
                    string jsonDeleted = JsonConvert.SerializeObject(dtDeleted, Formatting.Indented);

                    JsonDataTable jsonDT = new JsonDataTable();
                    jsonDT.dtAdded = jsonAdded;
                    jsonDT.dtModified = jsonModified;
                    jsonDT.dtDeleted = jsonDeleted;
                    string jsonString = JsonConvert.SerializeObject(jsonDT);

                    StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");


                    // Send POST request to the Web API
                    HttpResponseMessage response = await client.PostAsync("/api/SimpleGetAPI/UpdateCustomerData", content);

                    // Ensure the request was successful
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string
                        string responseString = await response.Content.ReadAsStringAsync();

                        // Parse the response string to an integer
                        int rowsUpdated = int.Parse(responseString);

                        return rowsUpdated;
                    }
                    else
                    {
                        Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                        return 0;
                    }
                }
            }
            catch (HttpRequestException e)
            {
                // Log the exception message
                MessageBox.Show($"Request error: {e.Message}");
                throw e;
            }
            catch (Exception ex)
            {
                // Log any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
                throw ex;
            }
        }

    }
}
