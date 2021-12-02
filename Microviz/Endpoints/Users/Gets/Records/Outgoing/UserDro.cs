namespace Microviz.Endpoints.Users.Gets.Records.Outgoing
{
    /// <summary>
    /// User record
    /// </summary>
    public class UserDRO
    {
        /// <summary>
        /// UUID user id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Unique name for user.
        /// </summary>
        public string Username { get; set; } = "";

        /// <summary>
        /// Display name for user.
        /// </summary>
        public string Displayname { get; set; } = "";

        /// <summary>
        /// Age of user.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Email of user.
        /// </summary>
        public string Email { get; set; } = "";

        /// <summary>
        /// Contact number of user in format +00.0000000000.
        /// </summary>
        public string Contact { get; set; } = "";

        /// <summary>
        /// Firstname of the user.
        /// </summary>
        public string Firstname { get; set; } = "";

        /// <summary>
        /// Lastname of the user.
        /// </summary>
        public string Lastname { get; set; } = "";

        /// <summary>
        /// Middlename of the user.
        /// </summary>
        public string Middlename { get; set; } = "";
    }
}
