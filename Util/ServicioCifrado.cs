using System.IO;
using System;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;

public class ServicioCifrado
{
    private readonly byte[] Key;
    private readonly byte[] Vector;

    public ServicioCifrado()
    {
        // Obtener el JWT para el bearer
        var jwt = ObtenerTokenDesdeServicio();

        // Luego, usar el JWT para obtener la clave y el Vector
        var config = ObtenerConfigDesdeServicio(jwt);
        Key = Convert.FromBase64String(config.Key);
        Vector = Convert.FromBase64String(config.IV);
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

    private ConfigService ObtenerConfigDesdeServicio(string token)
    {

        using (var httpClient = new HttpClient())
        {
            httpClient.Timeout = TimeSpan.FromSeconds(5);

            var byteArray = new System.Text.UTF8Encoding().GetBytes("master:master");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));
            httpClient.DefaultRequestHeaders.Add("Token", token); // bearer

            try
            {
                var response = httpClient.GetStringAsync("https://redtaller.jlizquierdo.com/security/encryption.php").Result;
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    WriteIndented = true
                };

                return JsonSerializer.Deserialize<ConfigService>(response, options); ;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error al obtener la clave y el IV: {e.Message}");
                return null;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error inesperado: {e.Message}");
                return null;
            }
        }
    }


    public string Cifrar(string textoClaro)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Key;
            aesAlg.IV = Vector;

            ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                {
                    swEncrypt.Write(textoClaro);
                }
                return Convert.ToBase64String(msEncrypt.ToArray());
            }
        }
    }

    public string Descifrar(string textoCifrado)
    {
        using (Aes aesAlg = Aes.Create())
        {
            aesAlg.Key = Key;
            aesAlg.IV = Vector;

            ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
            using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(textoCifrado)))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }

    public class ConfigService
    {
        public string Key { get; set; }
        public string IV { get; set; }
    }
}
