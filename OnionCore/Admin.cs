namespace OnionCore
{
    /// <summary>
    /// Admin class. Implements <c>IUser</c>.
    /// </summary>
    public class Admin : IUser
    {
        /// <inheritdoc cref="IUser.Id"/>
        public int Id { get; set; }
        
        /// <inheritdoc cref="IUser.Login"/>
        public string Login { get; set; }
        
        /// <inheritdoc cref="IUser.Password"/>
        public string Password { get; set; }
        
        /// <inheritdoc cref="IUser.PersonalInformation"/>
        public PersonalInformation PersonalInformation { get; set; }
    }
}