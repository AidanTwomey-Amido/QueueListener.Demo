using Newtonsoft.Json;

namespace QueueListener
{
    public class ExampleTemplateData
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }
    }
}