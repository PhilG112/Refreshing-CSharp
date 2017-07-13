using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : BaseEntity
    {
        public Customer() { }

        public Customer(int customerId)
        {
            Id = customerId;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
        public string Email { get; set; }
        public static int InstanceCount { get; set; }
        public string FullName
        { 
            get
            {
                var fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public bool Save()
        {
            // Code that saves the defined customer
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
        }

    }
}
