namespace Jumbo_Travez_Software_P01;

internal class Program
{
        public class Appointment
    {
        public Guid Id { get; private set; }
        public Guid PatientId { get; private set; }
        public Guid DentistId { get; private set; }
        public AppointmentStatus Status { get; private set; }
        public void Cancel(Appointment appointment)
        {
            if (appointment.Status == AppointmentStatus.Completed)
            {
                throw new Exception("No se puede cancelar");
            }
            appointment.Status = AppointmentStatus.Cancelled;
        }
    }
}
}