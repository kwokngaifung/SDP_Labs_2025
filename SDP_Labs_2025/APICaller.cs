using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDP_Labs_2025
{
    public class APICaller
    {
        public async Task<String> GetApiResponse(string endpoint)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["ServerAddress"]); // Adjust the base address as needed
                    HttpResponseMessage response = await client.GetAsync(endpoint);

                    // Check if the response is successful
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsStringAsync();
                    }
                    else
                    {
                        // Log the status code and reason
                        string error = $"Error: {response.StatusCode} - {response.ReasonPhrase}";
                        MessageBox.Show(error);
                        return error;

                    }
                }
            }
            catch (HttpRequestException e)
            {
                // Log the exception message
                MessageBox.Show($"Request error: {e.Message}");
                return $"Request error: {e.Message}";
            }
            catch (Exception ex)
            {
                // Log any other exceptions
                MessageBox.Show($"An error occurred: {ex.Message}");
                return $"An error occurred: {ex.Message}";
            }
        }
    }


}
