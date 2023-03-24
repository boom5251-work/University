namespace University.DataAccess.Models.Base
{
    /// <summary>
    /// Интерфейс пользователя.
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Адрес электронной почты.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Пароль.
        /// </summary>
        string Password { get; set; }
    }
}