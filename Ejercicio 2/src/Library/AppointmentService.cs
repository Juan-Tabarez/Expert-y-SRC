using System;
using System.Text;

namespace Library
{
    
    public class AppointmentService
    {

        public static string CreateAppointment(String name, String id, String phoneNumber, int age, DateTime appointmentDate, string appointmentPlace, String doctorName, String doctorSpecialty)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            
            Boolean isValid = true;

            (string, Patient) patientAdd = Patient.AddPatient(name, id, phoneNumber,age);
            stringBuilder.Append(patientAdd.Item1);

            (string, Doctor) doctorAdd = Doctor.AddDoctor(doctorName, doctorSpecialty);
            stringBuilder.Append(doctorAdd.Item1);

            if (patientAdd.Item2 == null || doctorAdd.Item2 == null)
            {
                isValid = false;
                stringBuilder.Append("Appointment could not be created, check patient, doctor and appointment data...\n");
            }

            if (isValid)
            {
                Appointment appointment = new Appointment(appointmentPlace, appointmentDate);
                stringBuilder.Append("Appointment completed successfully...\n");
            }

            return stringBuilder.ToString();
        }
    }
}
