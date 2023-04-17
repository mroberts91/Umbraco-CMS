﻿using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Mapping;
using Umbraco.Cms.Core.Services;

namespace Umbraco.Cms.Api.Management.Controllers.Script.Folder;

public class ByPathScriptFolderController : ScriptFolderBaseController
{
    public ByPathScriptFolderController(IUmbracoMapper mapper, IScriptFolderService scriptFolderService) : base(mapper, scriptFolderService)
    {
    }

    [HttpGet]
    [MapToApiVersion("1.0")]
    public Task<IActionResult> ByPath(string path) => GetFolderAsync(path);
}
