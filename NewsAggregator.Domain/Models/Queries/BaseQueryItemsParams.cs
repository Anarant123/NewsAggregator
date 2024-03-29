﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Domain.Models.Queries;

public class BaseQueryItemsParams : BaseQuery
{
    [JsonIgnore]
    public static int DefaultItemsCount => 200;
    [JsonIgnore]
    public static int DefaultPageNumber => 1;
    [JsonIgnore]
    public static int DefaultOrderByColumn => -1;
    
    /// <summary>
    /// Номер страницы запроса
    /// </summary>
    [Range(0, int.MaxValue)]
    public int PageNumber { get; set; } = DefaultPageNumber;

    /// <summary>
    /// Количество элементов на странице
    /// </summary>
    [Range(0, int.MaxValue)]
    public int ItemsOnPage { get; set; } = DefaultItemsCount;
    /// <summary>
    /// Текстовый фильтр для поиска
    /// </summary>
    public string? FilterText { get; set; }

    /// <summary>
    /// Сортировка по номеру колонки(свойства)
    /// </summary>
    public string? OrderBy { get; set; }
}