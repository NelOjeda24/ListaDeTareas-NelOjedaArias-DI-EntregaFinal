using EntregaFinal2._0_NelOjeda_ListaTareas.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EntregaFinal2._0_NelOjeda_ListaTareas.MVVM.ViewModels
{
    public class TareaViewModel
    {
        public ObservableCollection<Tarea> Tareas { get; set; }
        public TareaViewModel() {

            Tareas = new ObservableCollection<Tarea>
            {
new Tarea
    {
        Name = "Comprar",
        Done = false,
        Descripcion = "Ir al supermercado y comprar frutas, verduras y pan."
    },

    new Tarea
    {
        Name = "Estudiar para el examen",
        Done = false,
        Descripcion = "Revisar las notas de la última clase de matemáticas y practicar ejercicios."
    },

    new Tarea
    {
        Name = "Llamar al dentista",
        Done = false,
        Descripcion = "Agendar una cita para una limpieza dental el próximo mes."
    },

    new Tarea
    {
        Name = "Pagar las facturas",
        Done = false,
        Descripcion = "Pagar el recibo de la luz, agua y el internet antes del viernes."
    },

    new Tarea
    {
        Name = "Preparar presentación",
        Done = false,
        Descripcion = "Terminar las diapositivas para la reunión del lunes por la mañana."
    }
            };
        }


        public ICommand DeleteCommand => new Command((t) =>
        {
            if (t is Tarea)
                Tareas.Remove((Tarea)t);

        });
    }
}
