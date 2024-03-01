﻿namespace Itis.Pokemons.Api.Core.Abstractions;

/// <summary>
/// Сервис работы с http запрсоами
/// </summary>
public interface IHttpHelperService
{
    /// <summary>
    /// Get запрос
    /// </summary>
    /// <param name="uri">Uri - Запрос</param>
    /// <param name="cancellationToken">Токен отмены запроса</param>
    /// <returns>Ответ HTTP</returns>
    public Task<HttpResponseMessage> GetAsync(string uri, CancellationToken cancellationToken);

    /// <summary>
    /// Post запрос
    /// </summary>
    /// <param name="uri">Uri - Запрос</param>
    /// <param name="content">Параметры</param>
    /// <param name="cancellationToken">Токен отмены запроса</param>
    /// <returns></returns>
    public Task<HttpResponseMessage> PostAsync(string uri, HttpContent content, CancellationToken cancellationToken);
}