using SchedulingBox.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchedulingBox.Services
{
  public  interface IAppointmentService
    {

        public List<DoctorVM> GetDoctorList();
        public List<PatientVM> GetPatientList();
    }
}
