using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Domain.Models.Database
{
    public class Channel : DbEntity
    {
        /// Обязательные элементы

        /// <summary>
        /// Заголовок ленты
        /// </summary>
        [Column("title")]
        [JsonPropertyName("title")]
        [XmlElement(ElementName = "title")] 
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Ссылка на веб страницу, связанную с лентой
        /// </summary>
        [Column("link")]
        [JsonPropertyName("link")]
        [XmlElement(ElementName = "link")] 
        public string Link { get; set; } = string.Empty;

        /// <summary>
        /// Описание ленты
        /// </summary>
        [Column("description")]
        [JsonPropertyName("description")]
        [XmlElement(ElementName = "description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Статьи
        /// </summary>
        [JsonPropertyName("items")]
        [XmlElement(ElementName = "item")]
        public List<Item> Items { get; set; } = new List<Item>();
        
        // Опциональные элеменеты

        /// <summary>
        /// Язык на котором представлен контент в ленте
        /// </summary>
        [Column("language")]
        [JsonPropertyName("language")]
        [XmlElement(ElementName = "language")]
        public string? Language { get; set; }

        /// <summary>
        /// Уведомление об авторских правах на контент на канале
        /// </summary>
        [Column("copyright")]
        [JsonPropertyName("copyright")]
        [XmlElement(ElementName = "copyright")]
        public string? Copyright { get; set; }

        /// <summary>
        /// Ссылка на документацию, связанную с форматом ленты
        /// </summary>
        [Column("docs")]
        [JsonPropertyName("docs")]
        [XmlElement(ElementName = "docs")]
        public string? Docs { get; set; }

        /// <summary>
        /// Адрес электронной почты лица, ответственного за технические вопросы, связанные с каналом
        /// </summary>
        [Column("webmaster")]
        [JsonPropertyName("webmaster")]
        [XmlElement(ElementName = "webmaster")]
        public string? Webmaster { get; set; }

        /// <summary>
        /// Дата публикации контента на канале
        /// </summary>
        [Column("pubDate")]
        [JsonPropertyName("pubDate")]
        [XmlElement(ElementName = "pubDate")]
        public string? PubDate { get; set; }

        /// <summary>
        /// Адрес электронной почты лица, ответственного за редакционный контент
        /// </summary>
        [Column("managingEditor")]
        [JsonPropertyName("managingEditor")]
        [XmlElement(ElementName = "managingEditor")]
        public string? ManagingEditor { get; set; }

        /// <summary>
        /// Дата и время последнего обновления ленты
        /// </summary>
        [Column("lastBuildDate")]
        [JsonPropertyName("lastBuildDate")]
        [XmlElement(ElementName = "lastBuildDate")]
        public string? LastBuildDate { get; set; }

        /// <summary>
        /// Инструмент или программное обеспечение, которое создало ленту
        /// </summary>
        [Column("generator")]
        [JsonPropertyName("generator")]
        [XmlElement(ElementName = "generator")]
        public string? Generator { get; set; }

        /// <summary>
        /// Категория к которой относится канал
        /// </summary>
        [JsonPropertyName("categories")]
        [XmlElement(ElementName = "category")]
        public List<Category>? Categories { get; set; }

        /// <summary>
        /// Позволяет процессам регистрироваться в облаке, чтобы получать уведомления об обновлениях канала, реализуя упрощенный протокол публикации-подписки для RSS-каналов. Дополнительная информация здесь.
        /// </summary>
        [Column("cloud")]
        [JsonPropertyName("cloud")]
        [XmlElement(ElementName = "cloud")]
        public Cloud? Cloud { get; set; }

        /// <summary>
        /// Указывает изображение в формате GIF, JPEG или PNG, которое может отображаться вместе с каналом.
        /// </summary>
        [Column("image")]
        [JsonPropertyName("image")]
        [XmlElement(ElementName = "image")]
        public Image? Image { get; set; }

        /// <summary>
        /// Рейтинг фотографий для канала.
        /// </summary>
        [Column("rating")]
        [JsonPropertyName("rating")]
        [XmlElement(ElementName = "rating")]
        public string? Rating { get; set; }

        /// <summary>
        /// Указывает поле ввода текста, которое может отображаться вместе с каналом.
        /// </summary>
        [Column("textInput")]
        [JsonPropertyName("textInput")]
        [XmlElement(ElementName = "textInput")]
        public TextInput? TextInput { get; set; }

        //todo 24 эл. от 0 до 23
        /// <summary>
        /// Подсказка для агрегаторов, сообщающая им, какие часы они могут пропустить.
        /// </summary>
        [Column("skipHours")]
        [JsonPropertyName("skipHours")]
        [XmlElement(ElementName = "skipHours")]
        public string? SkipHours { get; set; }

        // todo 7 эл
        /// <summary>
        /// Подсказка для агрегаторов, сообщающая им, какие дни они могут пропустить.
        /// </summary>
        [Column("skipDays")]
        [JsonPropertyName("skipDays")]
        [XmlElement(ElementName = "skipDays")]
        public string? SkipDays { get; set; }
        
        
        public Channel() {}
    }
}