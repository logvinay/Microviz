using System.Collections.Generic;

namespace Microviz.Endpoints.Users.Posts;

/// <summary>
/// Create users
/// </summary>
public class CreateUsers : UsersController
{
    /// <summary>
    /// ctor
    /// </summary>
    public CreateUsers() : base()
    {

    }

    /// <summary>
    /// Create multiple users
    /// </summary>
    /// <remarks>Create multiple users with provided users detail</remarks>
    /// <returns></returns>
    [HttpPost(template: "batch", Name = "Create multiple users", Order = 4)]
    public async Task<ActionResult> ActionAsync([FromBody]IEnumerable<Records.Incoming.UserDWO> user)
    {
        await EnsureAwait();
        return CreatedAtRoute(routeName: "", value: new { });
    }
}
