using System;
using System.Text;

namespace Library
{
    
    public class AppointmentService
    {
        Patient Patient;
        Doctor Doctor;
        Appointment Appointment;

        public static string CreateAppointment(Patient patient, Appointment appointment, Doctor doctor)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            if (!doctor.isValidDoctor || !appointment.isValidAppointment || !patient.isValidPatient)
            {
                isValid = false;
            }
            


            if (isValid)
            {
                stringBuilder.Append("Appointment Scheduled");
            }

            return stringBuilder.ToString();
        }
    }
}