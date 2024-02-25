using System.Xml.Serialization;

namespace Domain.Models.Database;

[XmlRoot(ElementName = "rss")]
public class RSS : DbEntity
{
    [XmlElement(ElementName = "channel")] 
    public Channel Channel { get; set; } = new();
    
    [XmlAttribute(AttributeName = "version")]
    public string Version { get; set; } = string.Empty;
}