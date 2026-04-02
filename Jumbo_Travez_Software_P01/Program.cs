namespace Jumbo_Travez_Software_P01;

internal class Program
{
    public class Appointment
    {
        public Guid Id { get; private set; }
        public Guid PatientId { get; private set; }
        public Guid DentistId { get; private set; }
        public AppointmentStatus Status { get; private set; }
        public Appointment(Guid _patientId, Guid _DentistId)
        {
            if (_patientId == Guid.Empty)
            {
                throw new BussinessRuleException("El paciente es requerido");
            }
             if () { }
    }
            
        }
    }

