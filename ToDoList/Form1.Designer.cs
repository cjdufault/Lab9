namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNewToDo = new System.Windows.Forms.TextBox();
            this.btnAddToDo = new System.Windows.Forms.Button();
            this.clsToDo = new System.Windows.Forms.CheckedListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstDone = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkUrgent = new System.Windows.Forms.CheckBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "What do you need to do?";
            // 
            // txtNewToDo
            // 
            this.txtNewToDo.Location = new System.Drawing.Point(30, 87);
            this.txtNewToDo.Margin = new System.Windows.Forms.Padding(6);
            this.txtNewToDo.Name = "txtNewToDo";
            this.txtNewToDo.Size = new System.Drawing.Size(566, 31);
            this.txtNewToDo.TabIndex = 0;
            // 
            // btnAddToDo
            // 
            this.btnAddToDo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddToDo.Location = new System.Drawing.Point(752, 83);
            this.btnAddToDo.Margin = new System.Windows.Forms.Padding(6);
            this.btnAddToDo.Name = "btnAddToDo";
            this.btnAddToDo.Size = new System.Drawing.Size(150, 44);
            this.btnAddToDo.TabIndex = 2;
            this.btnAddToDo.Text = "Add";
            this.btnAddToDo.UseVisualStyleBackColor = true;
            this.btnAddToDo.Click += new System.EventHandler(this.btnAddToDo_Click);
            // 
            // clsToDo
            // 
            this.clsToDo.FormattingEnabled = true;
            this.clsToDo.Location = new System.Drawing.Point(30, 232);
            this.clsToDo.Margin = new System.Windows.Forms.Padding(6);
            this.clsToDo.Name = "clsToDo";
            this.clsToDo.Size = new System.Drawing.Size(868, 312);
            this.clsToDo.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(30, 569);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(394, 44);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Remove Checked Items";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstDone
            // 
            this.lstDone.FormattingEnabled = true;
            this.lstDone.ItemHeight = 25;
            this.lstDone.Location = new System.Drawing.Point(30, 684);
            this.lstDone.Margin = new System.Windows.Forms.Padding(6);
            this.lstDone.Name = "lstDone";
            this.lstDone.Size = new System.Drawing.Size(868, 229);
            this.lstDone.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 654);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Deleted items:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Things to do:";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(752, 931);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 44);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkUrgent
            // 
            this.chkUrgent.AutoSize = true;
            this.chkUrgent.Location = new System.Drawing.Point(612, 90);
            this.chkUrgent.Margin = new System.Windows.Forms.Padding(6);
            this.chkUrgent.Name = "chkUrgent";
            this.chkUrgent.Size = new System.Drawing.Size(120, 29);
            this.chkUrgent.TabIndex = 1;
            this.chkUrgent.Text = "Urgent?";
            this.chkUrgent.UseVisualStyleBackColor = true;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(151, 137);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(445, 33);
            this.cbxCategory.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category:";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddToDo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(936, 1001);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.chkUrgent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstDone);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.clsToDo);
            this.Controls.Add(this.btnAddToDo);
            this.Controls.Add(this.txtNewToDo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewToDo;
        private System.Windows.Forms.Button btnAddToDo;
        private System.Windows.Forms.CheckedListBox clsToDo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkUrgent;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label4;
    }
}

