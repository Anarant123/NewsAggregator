using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Domain.Models.Database;

public class DbEntity
{
    [Key]
    [Column("id")]
    [JsonPropertyName("id")]
    public System.Guid Id { get; set; } = System.Guid.NewGuid();
}