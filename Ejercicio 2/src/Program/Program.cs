using System;
using Library;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            string appointmentResult = AppointmentService.CreateAppointment("Steven Jhonson", "986782342", "5555-555-555", 84, DateTime.Now, "Wall Street", "Armand", "Dentist");
            Console.WriteLine(appointmentResult);

            string appointmentResult2 = AppointmentService.CreateAppointment("Ralf Manson", "094562131", "5555-555-555", -5, DateTime.Now, "Queen Street", "", "General");
            Console.WriteLine(appointmentResult2);

            string appointmentResult3 = AppointmentService.CreateAppointment("Jhon Doe", "54231597", "8888-445-654", 45, new DateTime(21, 5, 15), "Wall Street", "House", "General");
            Console.WriteLine(appointmentResult3);
        }
    }
}
