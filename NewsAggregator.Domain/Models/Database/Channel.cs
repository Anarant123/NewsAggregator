using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Domain.Models.Database
{
    public class Channel : DbEntity
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
        
        [JsonPropertyName("items")]
        [XmlElement(ElementName = "item")]
        public List<Item> Items { get; set; } = new List<Item>();

        [Column("language")]
        [JsonPropertyName("language")]
        [XmlElement(ElementName = "language")]
        public string? Language { get; set; }
        
        [Column("copyright")]
        [JsonPropertyName("copyright")]
        [XmlElement(ElementName = "copyright")]
        public string? Copyright { get; set; }
        
        [Column("docs")]
        [JsonPropertyName("docs")]
        [XmlElement(ElementName = "docs")]
        public string? Docs { get; set; }
        
        [Column("webmaster")]
        [JsonPropertyName("webmaster")]
        [XmlElement(ElementName = "webmaster")]
        public string? Webmaster { get; set; }
        
        [Column("pubDate")]
        [JsonPropertyName("pubDate")]
        [XmlElement(ElementName = "pubDate")]
        public string? PubDate { get; set; }
        
        [Column("managingEditor")]
        [JsonPropertyName("managingEditor")]
        [XmlElement(ElementName = "managingEditor")]
        public string? ManagingEditor { get; set; }
        
        [Column("lastBuildDate")]
        [JsonPropertyName("lastBuildDate")]
        [XmlElement(ElementName = "lastBuildDate")]
        public string? LastBuildDate { get; set; }
        
        [Column("generator")]
        [JsonPropertyName("generator")]
        [XmlElement(ElementName = "generator")]
        public string? Generator { get; set; }
        
        [JsonPropertyName("categories")]
        [XmlElement(ElementName = "category")]
        public List<Category>? Categories { get; set; }
        
        [Column("idCloud")]
        [JsonPropertyName("idCloud")]
        [XmlIgnore]
        public Guid IdCloud { get; set; }
        
        [Column("cloud")]
        [JsonPropertyName("cloud")]
        [XmlElement(ElementName = "cloud")]
        public Cloud? Cloud { get; set; }
        
        [Column("idImage")]
        [JsonPropertyName("idImage")]
        [XmlIgnore]
        public Guid IdImage { get; set; }
        
        [Column("image")]
        [JsonPropertyName("image")]
        [XmlElement(ElementName = "image")]
        public Image? Image { get; set; }
        
        [Column("rating")]
        [JsonPropertyName("rating")]
        [XmlElement(ElementName = "rating")]
        public string? Rating { get; set; }
        
        [Column("idTextInput")]
        [JsonPropertyName("idTextInput")]
        [XmlIgnore]
        public Guid IdTextInput { get; set; }
        
        [Column("textInput")]
        [JsonPropertyName("textInput")]
        [XmlElement(ElementName = "textInput")]
        public TextInput? TextInput { get; set; }
        
        [Column("skipHours")]
        [JsonPropertyName("skipHours")]
        [XmlElement(ElementName = "skipHours")]
        public string? SkipHours { get; set; }
        
        [Column("skipDays")]
        [JsonPropertyName("skipDays")]
        [XmlElement(ElementName = "skipDays")]
        public string? SkipDays { get; set; }
        
        public Channel() {}
    }
}