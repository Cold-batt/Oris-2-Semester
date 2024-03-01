using Itis.Pokemons.Api.Core.Entities;
using Itis.Pokemons.Api.Core.Managers;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Itis.Pokemons.Api.PostgreSql.Extensions;

public static class ModelBuilderExtensions
{
    /// <summary>
    /// Конфигурация моделей при запуске
    /// </summary>
    /// <param name="modelBuilder">ModelBuilder</param>
    public static void Seed(this ModelBuilder modelBuilder)
    {
    }
}