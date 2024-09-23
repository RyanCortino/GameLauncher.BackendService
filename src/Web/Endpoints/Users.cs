using GameLauncher.BackendService.Infrastructure.Identity;

namespace GameLauncher.BackendService.Web.Endpoints;

public class Users : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapIdentityApi<ApplicationUser>();
    }
}
