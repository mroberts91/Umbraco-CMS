﻿using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Api.Management.Routing;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Mapping;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Services.OperationStatus;

namespace Umbraco.Cms.Api.Management.Controllers.Script.Folder;

[ApiVersion("1.0")]
[ApiController]
[VersionedApiBackOfficeRoute($"{Constants.UdiEntityType.Script}/folder")]
[ApiExplorerSettings(GroupName = "Script")]
public class ScriptFolderBaseController : PathFolderManagementControllerBase<ScriptOperationStatus>
{
    private readonly IScriptFolderService _scriptFolderService;

    public ScriptFolderBaseController(IUmbracoMapper mapper, IScriptFolderService scriptFolderService) : base(mapper)
    {
        _scriptFolderService = scriptFolderService;
    }

    protected override async Task<PathContainer?> GetContainerAsync(string path)
    {
        PathContainer? scriptContainer = await _scriptFolderService.GetAsync(path);

        if (scriptContainer is null)
        {
            return null;
        }

        return scriptContainer;
    }

    protected override Task<Attempt<PathContainer, ScriptOperationStatus>> CreateContainerAsync(PathContainer container, Guid performingUserId) => throw new NotImplementedException();

    protected override Task<Attempt<PathContainer, ScriptOperationStatus>> UpdateContainerAsync(PathContainer container, Guid performingUserId) => throw new NotImplementedException();

    protected override Task<ScriptOperationStatus> DeleteContainerAsync(string path, Guid performingUserId) => throw new NotImplementedException();

    protected override IActionResult OperationStatusResult(ScriptOperationStatus status) => throw new NotImplementedException();
}
