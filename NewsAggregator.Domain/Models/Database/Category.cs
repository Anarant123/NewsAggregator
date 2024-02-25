using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Domain.Models.Database
{
    public class Category : DbEntity
    {
        [Column("title")]
        [JsonPropertyName("title")]
        [XmlElement(ElementName = "title")] 
        [XmlText]
        public string Title { get; set; }
        
        [Column("domain")]
        [JsonPropertyName("domain")]
        [XmlElement(ElementName = "domain")] 
        public string? Domain { get; set; }
        
        [JsonIgnore]
        [XmlIgnore]
        public List<Item>? Items { get; set; }
        
        [JsonIgnore]
        [XmlIgnore]
        public List<Channel>? Channels { get; set; }
        
    }
}