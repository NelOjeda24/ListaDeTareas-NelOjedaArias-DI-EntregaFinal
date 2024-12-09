using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntregaFinal2._0_NelOjeda_ListaTareas.MVVM.Model
{
    [AddINotifyPropertyChangedInterface]
    public class Tarea
    {
        public String Name { get; set; } = string.Empty;
        public bool Done { get; set; }
        public String Descripcion { get; set; } = string.Empty;
    }
}
