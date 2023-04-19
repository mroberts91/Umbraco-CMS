﻿using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Services.OperationStatus;
using Umbraco.New.Cms.Core.Models;

namespace Umbraco.Cms.Core.Services;

public interface IPartialViewService : IService
{
    Task<IPartialView?> GetAsync(string path);

    Task<PartialViewOperationStatus> DeleteAsync(string path, Guid performingUserKey);

    Task<PagedModel<PartialViewSnippet>> GetPartialViewSnippetsAsync(int skip, int take);

    Task<Attempt<IPartialView?, PartialViewOperationStatus>> CreateAsync(PartialViewCreateModel createModel, Guid performingUserKey);

    Task<Attempt<IPartialView?, PartialViewOperationStatus>> UpdateAsync(PartialViewUpdateModel updateModel, Guid performingUserKey);
}
