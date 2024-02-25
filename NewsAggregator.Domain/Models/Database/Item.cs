using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Domain.Models.Database;

public class Item : DbEntity
{
    // Обязательные элементы
    
    /// <summary>
    /// Название элемента
    /// </summary>
    [Column("title")]
    [JsonPropertyName("title")]
    [XmlElement(ElementName = "title")]
    public string Title { get; set; } = string.Empty;
    
    /// <summary>
    /// URL-адрес элемента
    /// </summary>
    [Column("link")]
    [JsonPropertyName("link")]
    [XmlElement(ElementName = "link")]
    public string Link { get; set; } = string.Empty;

    /// <summary>
    /// Краткое описание элемента
    /// </summary>
    [Column("description")]
    [JsonPropertyName("description")]
    [XmlElement(ElementName = "description")]
    public string Description { get; set; } = string.Empty;
    
    // Опциональные элементы

    /// <summary>
    /// Адрес электронной почты автора статьи
    /// </summary>
    [Column("author")]
    [JsonPropertyName("author")]
    [XmlElement(ElementName = "author")]
    public string? Author { get; set; }

    /// <summary>
    /// Категории
    /// </summary>
    [JsonPropertyName("categories")]
    [XmlElement(ElementName = "category")]
    public List<Category>? Categories { get; set; }

    /// <summary>
    /// URL-адрес страницы для комментариев, относящихся к товару
    /// </summary>
    [Column("comments")]
    [JsonPropertyName("comments")]
    [XmlElement(ElementName = "comments")]
    public string? Comments { get; set; }

    /// <summary>
    /// Описывает мультимедийный объект, прикрепленный к элементу
    /// </summary>
    [Column("enclosure")]
    [JsonPropertyName("enclosure")]
    [XmlElement(ElementName = "enclosure")]
    public Enclosure? Enclosure { get; set; }

    /// <summary>
    /// Строка, которая однозначно идентифицирует элемент
    /// </summary>
    [Column("guid")]
    [JsonPropertyName("guid")]
    [XmlElement(ElementName = "guid")]
    public Domain.Models.Database.Guid? Guid { get; set; }
    
    /// <summary>
    /// Дата публикации контента на канале
    /// </summary>
    [Column("pubDate")]
    [JsonPropertyName("pubDate")]
    [XmlElement(ElementName = "pubDate")]
    public string? PubDate { get; set; }

    /// <summary>
    /// RSS-канал, с которого был получен элемент
    /// </summary>
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