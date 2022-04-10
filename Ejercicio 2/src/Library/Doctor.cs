using System;
using System.Text;

namespace Library
{
    public class Doctor
    {
        public readonly string DoctorName;

        public readonly string Specialty;

        public readonly bool isValidDoctor;
        public Doctor(string doctorName,string specialty)
        {
            if (!string.IsNullOrEmpty(doctorName) || !string.IsNullOrEmpty(specialty))
            {
                this.DoctorName = doctorName;
                this.Specialty = specialty;
                this.isValidDoctor = true;
            }
        }
    }
}