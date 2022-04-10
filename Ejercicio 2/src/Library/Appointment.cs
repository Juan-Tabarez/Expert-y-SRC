using System;

namespace Library
{
    public class Appointment
    {
        public readonly string AppointmentPlace;
        public DateTime Date;
        public readonly long AppointmentId;
        public readonly bool isValidAppointment;

        //Lleva la cuenta de todas las Appointment creadas.
        private static long AppointmentNumber = 0;

        public Appointment(string appointmentPlace, DateTime date)
        {
            if (!string.IsNullOrEmpty(appointmentPlace))
            this.AppointmentPlace = appointmentPlace;
            this.Date = date;
            AppointmentNumber++;
            this.AppointmentId = AppointmentNumber;
            this.isValidAppointment = true;
        }
    }
}