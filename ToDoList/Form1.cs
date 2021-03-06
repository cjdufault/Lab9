﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        List<string> categories = new List<string> { "Work", "Chores", "Errands" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxCategory.Items.AddRange(categories.ToArray());
        }

        private void btnAddToDo_Click(object sender, EventArgs e)
        {
            string toDoText = txtNewToDo.Text;

            if (!string.IsNullOrWhiteSpace(toDoText) && cbxCategory.SelectedIndex != -1){ // do nothing if field is empty
                bool urgent = chkUrgent.Checked;
                string category = cbxCategory.SelectedItem.ToString();

                ToDo todDoItem = new ToDo(toDoText, urgent, category);

                if (!ItemExists(todDoItem)) // check if item is a duplicate
                {
                    clsToDo.Items.Add(todDoItem);
                    txtNewToDo.Text = "";
                }
                else
                {
                    MessageBox.Show("Item has already been added.", "Duplicate Item");
                    txtNewToDo.Text = "";
                }
            }
            else
            {
                MessageBox.Show("There is at least one empty field", "Missing information");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<ToDo> toRemove = new List<ToDo>();

            // add checked items to lstDone and toRemove
            foreach(ToDo item in clsToDo.CheckedItems)
            {
                toRemove.Add(item);
                lstDone.Items.Add(item);
            }

            // remove all items that were added to toRemove from clsToDo.Items
            foreach(ToDo item in toRemove)
            {
                clsToDo.Items.Remove(item);
            }
        }

        // tests if an item is already in clsToDo.Items, regardless of case
        private bool ItemExists(ToDo testItem)
        {            
            // compare each item to testItem, set exists to true and break if one does
            foreach(ToDo compareItem in clsToDo.Items)
            {
                if (testItem.Text.Equals(compareItem.Text, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
