namespace Microviz.Endpoints.Users.Gets
{
    /// <summary>
    /// Get user by id
    /// </summary>
    public class GetUserById : UsersController
    {
        /// <summary>
        /// ctor
        /// </summary>
        public GetUserById() : base()
        {

        }

        /// <summary>
        /// Get user by id 
        /// </summary>
        /// <remarks>
        /// Provide user id to get the user detail.
        /// </remarks>
        /// <param name="id">Id for the user</param>
        /// <returns>A matching user if id matches in datastore else return null</returns>
        [HttpGet(template: "{id}", Name = "Get user by id", Order = 2)]
        public async Task<ActionResult<Records.Outgoing.UserDRO>> ActionAsync([FromRoute]Guid id)
        {
            await EnsureAwait();
            return Ok(new Records.Outgoing.UserDRO());
        }
    }
}
