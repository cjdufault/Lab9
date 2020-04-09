using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ToDo
    {
        public ToDo(string text, bool urgent, string category)
        {
            Text = text;
            Urgent = urgent;
            Category = category;
        }

        public string Text { get; set; }
        public bool Urgent { get; set; }
        public string Category { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public override string ToString()
        {
            string displayText = $"{Text} - Created on {DateCreated:f} - {Category}";
            if (Urgent)
            {
                displayText += " URGENT!";
            }
            return displayText;
        }
    }
}
