namespace Microviz.Endpoints.Users
{
    /// <summary>
    /// Users controller
    /// </summary>
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// ctor
        /// </summary>
        public UsersController() : base()
        {

        }

        /// <summary>
        /// Ensure await for all users controller
        /// </summary>
        /// <returns></returns>
        [NonAction]
        public Task EnsureAwait()
        {
            return Task.Delay(0);
        }
    }
}
