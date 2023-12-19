using Ijuba.Webapi.Shared.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace Ijuba.Webapi.Infrastructure.Auth.Permissions;

public class MustHavePermissionAttribute : AuthorizeAttribute
{
    public MustHavePermissionAttribute(string action, string resource) =>
        Policy = FSHPermission.NameFor(action, resource);
}