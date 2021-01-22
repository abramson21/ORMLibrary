namespace Library.Domain
{
    using System;
    using Infrastructure.Extensions;

    public class Name
    {
        public string FirstName { get; }

        public string LastName { get; }

        public string MiddleName { get; }

        protected Name() { }

        public Name(string firstName, string lastName, string middleName)
        {
            this.FirstName = firstName.NullIfNullOrWhiteSpace() ??
                             throw new ArgumentOutOfRangeException(nameof(firstName));

            this.LastName = lastName.NullIfNullOrWhiteSpace() ??
                             throw new ArgumentOutOfRangeException(nameof(lastName));

            if (middleName == null && string.IsNullOrWhiteSpace(middleName))
            {
                throw new ArgumentOutOfRangeException(nameof(middleName));
            }

            this.MiddleName = middleName.NullIfNullOrWhitespaceTrim();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.FirstName, this.LastName, this.MiddleName ?? string.Empty);
        }

        public override bool Equals(object obj)
        {
            if (object.ReferenceEquals(obj, null))
            {
                return false;
            }

            if (object.ReferenceEquals(obj, this))
            {
                return true;
            }

            return obj is Name other
                && string.Equals(this.FirstName, other.FirstName, StringComparison.InvariantCulture)
                && string.Equals(this.LastName, other.LastName, StringComparison.InvariantCulture)
                && string.Equals(this.MiddleName, other.MiddleName, StringComparison.InvariantCulture);
        }

        public override string ToString() => FullName;

        public virtual string FullName => $"{this.FirstName} {this.LastName} {this.MiddleName}".Trim();

    }
}
