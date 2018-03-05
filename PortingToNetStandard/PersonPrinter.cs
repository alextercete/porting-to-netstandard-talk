using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PortingToNetStandard
{
    public class PersonPrinter
    {
        private readonly TextWriter _output;

        public PersonPrinter(TextWriter output)
        {
            _output = output;
        }

        public void Print(Person person)
        {
            var json = JsonConvert.SerializeObject(person, new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented
            });

            _output.WriteLine(json);
        }
    }
}