using System;

namespace Library
{
    public class Appointment
    {
        public readonly string AppointmentPlace;
        
        public DateTime Date;
        
        public readonly long AppointmentId;

        //Lleva la cuenta de todas las Appointment creadas.
        private static long AppointmentsCreated = 0;

        public Appointment(string appointmentPlace, DateTime date)
        {
            this.AppointmentPlace = appointmentPlace;
            this.Date = date;
            AppointmentsCreated++;
            this.AppointmentId = AppointmentsCreated;
        }
    }
}
