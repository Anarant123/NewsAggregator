using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Domain.Models.Database;

public class TextInput : DbEntity
{
    [Column("title")]
    [JsonPropertyName("title")]
    [XmlElement(ElementName = "title")]
    public string Title { get; set; } = string.Empty;
    
    [Column("description")]
    [JsonPropertyName("description")]
    [XmlElement(ElementName = "description")]
    public string Description { get; set; } = string.Empty;

    [Column("name")]
    [JsonPropertyName("name")]
    [XmlElement(ElementName = "name")]
    public string Name { get; set; } = string.Empty;

    [Column("link")]
    [JsonPropertyName("link")]
    [XmlElement(ElementName = "link")]
    public string Link { get; set; } = string.Empty;

    [Column("idChannel")]
    [JsonPropertyName("idChannel")]
    [XmlIgnore]
    public Guid IdChannel { get; set; }
    
    [JsonIgnore]
    [XmlIgnore]
    public List<Channel> Channels { get; set; }
    
    public TextInput (){}
}