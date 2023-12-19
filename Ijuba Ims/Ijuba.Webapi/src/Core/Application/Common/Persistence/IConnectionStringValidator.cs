﻿namespace Ijuba.Webapi.Application.Common.Persistence;

public interface IConnectionStringValidator
{
    bool TryValidate(string connectionString, string? dbProvider = null);
}