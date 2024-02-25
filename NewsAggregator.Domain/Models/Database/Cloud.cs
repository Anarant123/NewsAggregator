using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Domain.Models.Database
{
    public class Cloud : DbEntity
    {
        [Column("domain")]
        [JsonPropertyName("domain")]
        [XmlElement(ElementName = "domain")]
        public string Domain { get; set; } = string.Empty;

        [Column("port")]
        [JsonPropertyName("port")]
        [XmlElement(ElementName = "port")]
        public int Port { get; set; }

        [Column("path")]
        [JsonPropertyName("path")]
        [XmlElement(ElementName = "path")]
        public string Path { get; set; } = string.Empty;

        [Column("registerProcedure")]
        [JsonPropertyName("registerProcedure")]
        [XmlElement(ElementName = "registerProcedure")]
        public string RegisterProcedure { get; set; } = string.Empty;

        [Column("protocol")]
        [JsonPropertyName("protocol")]
        [XmlElement(ElementName = "protocol")]
        public string Protocol { get; set; } = string.Empty;
        
        [JsonIgnore]
        [XmlIgnore]
        public List<Channel> Channels { get; set; }

        public Cloud() { }
    }
}