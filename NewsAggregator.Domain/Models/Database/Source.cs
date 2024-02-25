using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Domain.Models.Database;

public class Source : DbEntity
{
    [Column("title")]
    [JsonPropertyName("title")]
    [XmlElement(ElementName = "title")]
    public string Title { get; set; } = string.Empty;

    [Column("url")]
    [JsonPropertyName("url")]
    [XmlElement(ElementName = "url")]
    public string Url { get; set; } = string.Empty;
    
    [Column("idItem")]
    [JsonPropertyName("idItem")]
    [XmlIgnore]
    public Guid IdItem { get; set; }

    [JsonIgnore]
    [XmlIgnore]
    public List<Item>? Items { get; set; }
    
    public Source(){}
}