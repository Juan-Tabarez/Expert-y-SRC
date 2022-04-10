using System;

namespace Library
{
    public class Patient
    {
        public readonly string Name;

        public readonly string Id;

        public readonly string PhoneNumber;

        public readonly string Age;
        public readonly bool isValidPatient;

        public Patient(string name, string id, string phoneNumber, string age)
        {   
            if (!string.IsNullOrEmpty(name) || (!string.IsNullOrEmpty(id) || (!string.IsNullOrEmpty(phoneNumber) || (!string.IsNullOrEmpty(age)))))
            {
                this.Name = name;
                this.Id = id;
                this.PhoneNumber = phoneNumber;
                this.Age = age;
            }
        }
    }
}