﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Library.NH
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Класс-помощник, обеспечивающий настройку для конкретной сборки.
    /// </summary>
    class LibraryNHibernateConfigurator
    {
        [Obsolete("Стоит переписать на расширение с учётом регистрации правил отображения и конвенций.")]
        public static Assembly GetAssembly() => Assembly.GetExecutingAssembly();
    }
}
