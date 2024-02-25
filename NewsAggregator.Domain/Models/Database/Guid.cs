using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Domain.Models.Database
{
    public class Guid : DbEntity
    {
        [Column("title")]
        [JsonPropertyName("title")]
        [XmlText]
        public string Title { get; set; } = string.Empty;

        [Column("isPermaLink")]
        [JsonPropertyName("isPermaLink")]
        [XmlElement(ElementName = "isPermaLink")]
        public bool IsPermaLink { get; set; } = true;
        
        /// <summary>
        /// Элементы
        /// </summary>
        [JsonIgnore]
        [XmlIgnore]
        public List<Item>? Items { get; set; }
        
        public Guid () {}
    }
}