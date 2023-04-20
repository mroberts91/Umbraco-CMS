﻿using Umbraco.Cms.Core.Models;

namespace Umbraco.Cms.Core.Services;

public interface IStylesheetService
{
    Task<IStylesheet?> GetAsync(string path);
}
