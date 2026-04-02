using System.Net.NetworkInformation;

namespace Jumbo_Travez_Software_P01;

internal class Program
{
    public class Appointment
    {
        public Guid Id { get; private set; }
        public Guid PatientId { get; private set; }
        public Guid DentistId { get; private set; }
        public AppointmentStatus Status { get; private set; }
        public Appointment(Guid _patientId, Guid _dentistId)
        {
            if (_patientId == Guid.Empty)
            {
                throw new BussinessRuleException("El paciente es requerido");
            }
             if (_dentistId == Guid.Empty )
            {
                throw new BusinessRuleException("El dentista es requerido");
            }
            Id = Guid.CreateVersion7();
            _patientId = PatientId;
            _dentistId = DentistId;
            Status = AppointmentStatus.Scheduled;
        }
        public void Cancel()
        {
            if(Status != AppointmentStatus.Scheduled)
            {
                throw new BussinessRuleException("No se puede cancelar una cita programda");
            }
            
            Status = Appoitment.Cancelled
        }
            
    }

}

