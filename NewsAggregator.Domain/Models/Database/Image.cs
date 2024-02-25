using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Domain.Models.Database;

public class Image : DbEntity
{
    // Обязательные элементы
    
    /// <summary>
    /// Указывает URL-адрес изображения.
    /// </summary>
    [Column("url")]
    [JsonPropertyName("url")]
    [XmlElement(ElementName = "url")]
    public string Url { get; set; } = string.Empty;
    
    /// <summary>
    /// Определяет текст для отображения, если изображение не удалось отобразить.
    /// </summary>
    [Column("title")]
    [JsonPropertyName("title")]
    [XmlElement(ElementName = "title")]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Определяет гиперссылку на веб-сайт, предлагающий канал.
    /// </summary>
    [Column("link")]
    [JsonPropertyName("link")]
    [XmlElement(ElementName = "link")]
    public string Link { get; set; } = string.Empty;
    
    // Опциональные элементы

    /// <summary>
    /// Содержит текст, который включен в атрибут TITLE ссылки, созданной вокруг изображения при рендеринге HTML
    /// </summary>
    [Column("description")]
    [JsonPropertyName("description")]
    [XmlElement(ElementName = "description")]
    public string? Description { get; set; }

    /// <summary>
    /// Определяет ширину изображения. По умолчанию - 88. Максимальное значение - 144
    /// </summary>
    [Column("width")]
    [JsonPropertyName("width")]
    [XmlElement(ElementName = "width")]
    [MaxLength(144)]
    [MinLength(88)]
    public int? Width { get; set; } = 88;

    /// <summary>
    /// Определяет высоту изображения. По умолчанию - 31. Максимальное значение - 400
    /// </summary>
    [Column("height")]
    [JsonPropertyName("height")]
    [XmlElement(ElementName = "height")]
    [MaxLength(400)]
    [MinLength(31)]
    public int? Height { get; set; } = 31;
    
    /// <summary>
    /// Внешний ключ на канал
    /// </summary>
    [Column("idChannel")]
    [JsonPropertyName("idChannel")]
    [XmlIgnore]
    public Guid IdChannel { get; set; }
    
    [JsonIgnore]
    [XmlIgnore]
    public List<Channel> Channels { get; set; }
    
    public Image(){}
}