using System.Collections.Generic;
using ListaDoZrobienia.DataModel;

namespace ListaDoZrobienia.Services
{
    public class ToDoListService
    {
        public IEnumerable<ToDoItem> GetItems() => new[]
        {
            new ToDoItem { Description = "mleko" },
            new ToDoItem { Description = "Ser" },
            new ToDoItem { Description = "chleb", IsChecked = true },
        };
    }
}
