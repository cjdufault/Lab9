using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class ToDo
    {
        public ToDo(string text, bool urgent)
        {
            Text = text;
            Urgent = urgent;
        }

        public string Text { get; set; }

        public bool Urgent { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;

        public override string ToString()
        {
            string displayText = $"{Text} - Created on {DateCreated:f}";
            if (Urgent)
            {
                displayText += " URGENT!";
            }
            return displayText;
        }
    }
}
