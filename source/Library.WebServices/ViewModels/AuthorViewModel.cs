namespace Library.WebServices.ViewModels
{
    using System;
    using Library.Domain;

    public class AuthorViewModel
    {
        public string FullName { get; }
        public AuthorViewModel(Name name)
        {
            if (name == null) 
                throw new ArgumentNullException(nameof(name));
            this.FullName = name.FullName;
        }
    }
}