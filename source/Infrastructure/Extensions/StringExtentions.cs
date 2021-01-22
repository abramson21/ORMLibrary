namespace Infrastructure.Extensions
{
    using System.Collections.Generic;

    public static class StringExtentions
    {
        /// <summary>
        /// Метод, проверяющий входной параметр на null или пустое значение.
        /// </summary>
        /// <param name="str">Входная строка</param>
        public static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str);

        /// <summary>
        /// Метод, проверяющий входной параметр на null или пустое значение. Удаляет пробелы.
        /// </summary>
        /// <param name="str">Входная строка</param>
        /// <returns></returns>
        public static bool IsNullOrWhiteSpace(this string str) => string.IsNullOrEmpty(str?.Trim());

        /// <summary>
        /// Метод, возвращающий строку null или str. Проверка IsNullOrEmpty()
        /// </summary>
        /// <param name="str">Входная строка</param>
        /// <returns></returns>
        public static string NullIfNullOrEmpty(this string str) => str.IsNullOrEmpty() ? null : str;

        /// <summary>
        /// Метод, возвращающий строку null или str. Проверка IsNullOrWhitespace()
        /// </summary>
        /// <param name="str">Входная строка</param>
        /// <returns></returns>
        public static string NullIfNullOrWhiteSpace(this string str) => str.IsNullOrWhiteSpace() ? null : str;

        /// <summary>
        /// Метод, проверяющий на пустое значение. Удаляет пробелы у строки.
        /// Сделано для MiddleName, так как данный параметр может иметь пустую строку, а два других нет.
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string NullIfNullOrWhitespaceTrim(this string str) =>
            str.IsNullOrWhiteSpace() ? null : str.Trim();

        /// <summary>
        /// Метод формирующий строку из коллекции.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source">Коллекция</param>
        /// <param name="separator">Разделитель</param>
        /// <param name="defaultResult">Значение по умолчанию</param>
        /// <returns></returns>
        public static string Join<T>(this IEnumerable<T> source, string separator = ", ", string defaultResult = "")
        {
            return source is null ? defaultResult : string.Join(separator, source);
        }
    }
}
