using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Domain.Models.Database;

public class Item : DbEntity
{
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
    public string Description { get; set; } = string.Empty;
    
    [Column("author")]
    [JsonPropertyName("author")]
    [XmlElement(ElementName = "author")]
    public string? Author { get; set; }
    
    [JsonPropertyName("categories")]
    [XmlElement(ElementName = "category")]
    public List<Category>? Categories { get; set; }
    
    [Column("comments")]
    [JsonPropertyName("comments")]
    [XmlElement(ElementName = "comments")]
    public string? Comments { get; set; }

    [Column("idEnclosure")]
    [JsonPropertyName("idEnclosure")]
    [XmlIgnore]
    public Guid IdEnclosure { get; set; }
    
    [Column("enclosure")]
    [JsonPropertyName("enclosure")]
    [XmlElement(ElementName = "enclosure")]
    public Enclosure? Enclosure { get; set; }

    [Column("idGuid")]
    [JsonPropertyName("idGuid")]
    [XmlIgnore]
    public Guid IdGuid { get; set; }
    
    [Column("guid")]
    [JsonPropertyName("guid")]
    [XmlElement(ElementName = "guid")]
    public Domain.Models.Database.Guid? Guid { get; set; }

    [Column("pubDate")]
    [JsonPropertyName("pubDate")]
    [XmlElement(ElementName = "pubDate")]
    public string? PubDate { get; set; }

    [Column("idSource")]
    [JsonPropertyName("idSource")]
    [XmlIgnore]
    public Guid IdSource { get; set; }
    
    [Column("source")]
    [JsonPropertyName("source")]
    [XmlElement(ElementName = "source")]
    public Source? Source { get; set; }
    
    
    [Column("idChannel")]
    [JsonPropertyName("idChannel")]
    [XmlIgnore]
    public Guid IdChannel { get; set; }

    [JsonIgnore]
    [XmlIgnore]
    public Channel Channel { get; set; }
    
    public Item() { }
}