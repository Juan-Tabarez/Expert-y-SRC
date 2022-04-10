using System;
using System.Text;

namespace Library
{
    public class Patient
    {
        public readonly string Name;
        public readonly string Id;
        public readonly string PhoneNumber;
        public readonly int Age;

        public Patient(string name, string id, string phoneNumber, int age)
        {   
            this.Name = name;
            this.Id = id;
            this.PhoneNumber = phoneNumber;
            this.Age = age;     
        }

        public static (string, Patient) AddPatient(string name, string id, string phoneNumber, int age)
        {
            StringBuilder response = new StringBuilder("Adding Patient...\n");

            if (!string.IsNullOrEmpty(name) && (!string.IsNullOrEmpty(id) && (!string.IsNullOrEmpty(phoneNumber) && (age >= 0))))
            {
                Patient patient = new Patient(name, id, phoneNumber, age);
                response.Append("Patient added successfully...\n");
                return (response.ToString(),patient);
            }
            response.Append("Patient could not be added...\n");
            return (response.ToString(),null);
        }
    }
}