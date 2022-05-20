using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WPF_EF_MVVM_SA_Proj.Resources.MVVM.Models
{
    public class BusyCabinet
    {
        public int Id { get; set; }
        public int CabinetId { get; set; }
        public virtual Cabinet Cabinet { get; set; } = null!;
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; } = null!;

        public string IsBusy { get; set; } = null!;

        //[NotMapped]
        //ATO NADO
        //public Teacher BusyCabinetTeacher
        //{
            //get
            //{
            //    return DataWorker.GetStudentById((int)StudentId);
            //}
        //}
        //[NotMapped]
        //public Cabinet BusyCabinetCabinet
        //{
            //get
            //{
            //    return DataWorker.GetDisciplineById((int)DisciplineId);
            //}
        //}
    }
}
