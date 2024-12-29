using redTaller.Util;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;

public class ServicioConexion
{

    private string user;
    private string password;
    private readonly string connectionString;
    public Boolean estado;

    public ServicioConexion(string user, string password)
    {
        this.user = user;
        this.password = password;
        estado = false;

        try
        {
            var jwt = ObtenerTokenDesdeServicio();
            var config = ObtenerAccessDb(jwt, user, password);
            if (config != null)
            {
                connectionString = config.connection;
                if (!string.IsNullOrEmpty(connectionString))
                {
                    Session.Instance.ConnectionString = connectionString;
                    estado = true;
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error inesperado: {e.Message}");
        }

    }

    private string ObtenerTokenDesdeServicio()
    {

        using (var httpClient = new HttpClient())
        {
            httpClient.Timeout = TimeSpan.FromSeconds(10);
            try
            {
                var response = httpClient.GetStringAsync("https://redtaller.jlizquierdo.com/security/jwt.php").Result;
                var json = JsonDocument.Parse(response);
                return json.RootElement.GetProperty("jwt").GetString();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error al obtener el token: {e.Message}");
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return null;
            }
        }
    }

    private ConfigService ObtenerAccessDb(string token, string user, string password)
    {

        using (var httpClient = new HttpClient())
        {
            httpClient.Timeout = TimeSpan.FromSeconds(5);

            var byteArray = new System.Text.UTF8Encoding().GetBytes($"{user}:{password}");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            httpClient.DefaultRequestHeaders.Add("Token", token); // bearer

            try
            {
                var response = httpClient.GetStringAsync("https://redtaller.jlizquierdo.com/security/connection.php").Result;
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    WriteIndented = true
                };

                return JsonSerializer.Deserialize<ConfigService>(response, options); ;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error al obtener el acceso: {e.Message}");
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return null;
            }
        }
    }


    private class ConfigService
    {
        public string connection { get; set; }
    }


}
