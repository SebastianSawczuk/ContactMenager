using ClassLibrary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonLibrary
{
    [Info("bebe")]
    public class JsonExtension : IPluginable
    {        
        public string Format => "JSON";

        public List<Contact> Load(string filePath)
        {
            List<Contact> contacts;
            using (Stream stream = File.OpenRead(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                contacts = JsonSerializer.Deserialize<List<Contact>>(jsonString);
            }
            
            return contacts;
        }

        public void Save(List<Contact> contacts, string filePath)
        {
            using (Stream stream = File.Create(filePath))
            {
                string jasonString = JsonSerializer.Serialize(contacts);
                File.WriteAllText(filePath, jasonString);
            }
            
        }
    }
}