namespace Microviz.Endpoints.Users.Gets;

/// <summary>
/// Get users
/// </summary>
public class GetUsers : UsersController
{
    /// <summary>
    /// ctor
    /// </summary>
    public GetUsers() : base()
    {

    }

    /// <summary>
    /// Get all users
    /// </summary>
    /// <remarks>
    /// Get all users or 
    /// get users based on any of params firstname, lastname, email and username 
    /// </remarks>
    /// <param name="firstname">Firstname of user</param>
    /// <param name="email">Email of user</param>
    /// <param name="lastname">Lastname of user</param>
    /// <param name="username">Username of user</param>
    /// <returns>All users matching the constraints or empty array if no users in the store</returns>
    [HttpGet(template: "", Name = "Get all users", Order = 1)]
    public async Task<ActionResult<IEnumerable<Records.Outgoing.UserDRO>>> ActionAsync(
        [FromQuery]string firstname = "", 
        [FromQuery]string email="", 
        [FromQuery]string lastname = "",
        [FromQuery]string username = "")
    {
        await EnsureAwait();
        return Ok(new List<Records.Outgoing.UserDRO>());
    }
}
