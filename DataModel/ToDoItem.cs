using System;

namespace ListaDoZrobienia.DataModel
{
    public class ToDoItem
    {
        public string Description { get; set; } = String.Empty;
        public bool IsChecked { get; set; }
    }
}
