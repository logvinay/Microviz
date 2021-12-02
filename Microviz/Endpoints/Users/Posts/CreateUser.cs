namespace Microviz.Endpoints.Users.Posts;

/// <summary>
/// Create a user
/// </summary>
public class CreateUser : UsersController
{
    /// <summary>
    /// ctor
    /// </summary>
    public CreateUser() : base()
    {

    }

    /// <summary>
    /// Create a user
    /// </summary>
    /// <remarks>Create a user with provided user detail</remarks>
    /// <returns></returns>
    [HttpPost(template: "", Name = "Create a user", Order = 3)]
    public async Task<ActionResult> ActionAsync([FromBody]Records.Incoming.UserDWO user)
    {
        await EnsureAwait();
        return CreatedAtRoute(routeName: "", value: new { });
    }
}
