using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Domain.Models.Database;

public class Image : DbEntity
{
    [Column("url")]
    [JsonPropertyName("url")]
    [XmlElement(ElementName = "url")]
    public string Url { get; set; } = string.Empty;
    
    [Column("title")]
    [JsonPropertyName("title")]
    [XmlElement(ElementName = "title")]
    public string Title { get; set; } = string.Empty;
    
    [Column("link")]
    [JsonPropertyName("link")]
    [XmlElement(ElementName = "link")]
    public string Link { get; set; } = string.Empty;
    
    [Column("description")]
    [JsonPropertyName("description")]
    [XmlElement(ElementName = "description")]
    public string? Description { get; set; }
    
    [Column("width")]
    [JsonPropertyName("width")]
    [XmlElement(ElementName = "width")]
    [MaxLength(144)]
    [MinLength(88)]
    public int? Width { get; set; } = 88;
    
    [Column("height")]
    [JsonPropertyName("height")]
    [XmlElement(ElementName = "height")]
    [MaxLength(400)]
    [MinLength(31)]
    public int? Height { get; set; } = 31;
    
    [Column("idChannel")]
    [JsonPropertyName("idChannel")]
    [XmlIgnore]
    public Guid IdChannel { get; set; }
    
    [JsonIgnore]
    [XmlIgnore]
    public List<Channel> Channels { get; set; }
    
    public Image(){}
}