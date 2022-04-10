using System;
using Library;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");

            Patient jose = new Patient("Jose", "986782342", "5555-555-555", "22");
            
            Doctor house = new Doctor("House", "Gastroenterólogo");

            Appointment appointment = new Appointment("Queen Street", DateTime.Now);

            string appointmentResult = AppointmentService.CreateAppointment(jose, appointment , house);

            Console.WriteLine(appointmentResult);

        }
    }
}
