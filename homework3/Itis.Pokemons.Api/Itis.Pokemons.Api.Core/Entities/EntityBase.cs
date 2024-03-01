using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Itis.Pokemons.Api.Core.Abstractions;

namespace Itis.Pokemons.Api.Core.Entities;

public class EntityBase : IEntity
{
    /// <summary>
    /// ИД сущности
    /// </summary>
    [ScaffoldColumn(false)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Id { get; set; }
}