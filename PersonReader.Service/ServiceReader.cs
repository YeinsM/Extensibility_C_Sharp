using PersonReader.Interface;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace PersonReader.Service
{
    
    public class ServiceReader : IPersonReader
    {
        /// <summary>
        /// Method <c>client</c> for use http client without asyncronism.
        /// </summary>
        WebClient client = new WebClient();
        string baseUri = "http://localhost:9874";
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public IEnumerable<Person> GetPeople()
        {
            // Specific name for base url
            string address = $"{baseUri}/people";
            // Container for our URL
            string reply = client.DownloadString(address);
            // Deserealize the string to C# Object
            return JsonSerializer.Deserialize<IEnumerable<Person>>(reply, options);
        }

        public Person GetPerson(int id)
        {
            // Specific name for base url
            string address = $"{baseUri}/people/{id}";
            // Container for our URL
            string reply = client.DownloadString(address);
            // Deserealize the string to C# Object
            return JsonSerializer.Deserialize<Person>(reply, options);
        }
    }
}