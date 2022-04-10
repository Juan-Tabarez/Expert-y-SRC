using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public readonly string DoctorName;

        public readonly string Specialty;

        public Doctor(string doctorName,string specialty)
        {        
            this.DoctorName = doctorName;
            this.Specialty = specialty;
        }

        public static (string, Doctor) AddDoctor(string doctorName,string specialty)
        {
            StringBuilder response = new StringBuilder("Adding Doctor...\n");

            if (!string.IsNullOrEmpty(doctorName) && !string.IsNullOrEmpty(specialty))
            {
                Doctor doctor = new Doctor(doctorName, specialty);
                response.Append("Doctor added successfully...\n");
                return (response.ToString(), doctor);
            }
            response.Append("Doctor could not be added...\n");
            return (response.ToString(),null);

        }
    }
}