using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
namespace JsonSerialization;
public class Program
{
    public static async Task Main()
    {
        Employee employee = new Employee
        {
            Name = "Alice",
            Age = 28,
            Department = "IT"
        };

        // Serialize employee object to JSON string
        string jsonString = JsonSerializer.Serialize(employee);

        // Post method
        using (HttpClient client = new HttpClient())
        {
            string apiUrl = "https://localhost:6001/api/employees";
            StringContent content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(apiUrl, content);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Data has been successfully sent to the server.");
            }
            else
            {
                Console.WriteLine($"Failed to send data. Status Code: {response.StatusCode}");
            }
        }
    }
}
