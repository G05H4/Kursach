using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_EF_MVVM_SA_Proj.Resources.MVVM.Models
{
    public class Cabinet
    {
        public int Id { get; set; }
        public int CabinetNumber { get; set; }
        public string CabinetName { get; set; } = null!;
    }
}
