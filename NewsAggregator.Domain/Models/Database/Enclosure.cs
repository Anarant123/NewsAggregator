using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Domain.Models.Database
{
    public class Enclosure : DbEntity
    {
        [Column("type")]
        [JsonPropertyName("type")]
        [XmlElement(ElementName = "type")]
        public string Type { get; set; } = string.Empty;

        [Column("url")]
        [JsonPropertyName("url")]
        [XmlElement(ElementName = "url")]
        public string Url { get; set; }

        [Column("length")]
        [JsonPropertyName("length")]
        [XmlElement(ElementName = "length")]
        public int Length { get; set; }
        
        [Column("idItem")]
        [JsonPropertyName("idItem")]
        [XmlIgnore]
        public Guid IdItem { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        public List<Item>? Items { get; set; }
        
        public Enclosure() {}
    }
}