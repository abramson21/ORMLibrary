namespace Library.NH
{
    using System;
    using System.Reflection;

    public class LibraryNHibernateConfigurator
    {
        /// <summary>
        /// Метод получения сборки.
        /// </summary>
        /// <returns>Исполняемая сборка.</returns>
        [Obsolete("Стоит переписать на расширение с учётом регистрации правил отображения и конвенций.")]
        public static Assembly GetAssembly() => Assembly.GetExecutingAssembly();
    }
}
