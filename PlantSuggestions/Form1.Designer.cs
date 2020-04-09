namespace PlantSuggestions
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
            this.chkSthFacing = new System.Windows.Forms.CheckBox();
            this.trkTemp = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblSuggestion = new System.Windows.Forms.Label();
            this.linkHousePlantInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.trkTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSthFacing
            // 
            this.chkSthFacing.AutoSize = true;
            this.chkSthFacing.Location = new System.Drawing.Point(73, 35);
            this.chkSthFacing.Name = "chkSthFacing";
            this.chkSthFacing.Size = new System.Drawing.Size(399, 30);
            this.chkSthFacing.TabIndex = 0;
            this.chkSthFacing.Text = "Do you have a south-facing window?";
            this.chkSthFacing.UseVisualStyleBackColor = true;
            this.chkSthFacing.CheckedChanged += new System.EventHandler(this.HouseConditionsChanged);
            // 
            // trkTemp
            // 
            this.trkTemp.Location = new System.Drawing.Point(73, 102);
            this.trkTemp.Maximum = 90;
            this.trkTemp.Minimum = 50;
            this.trkTemp.Name = "trkTemp";
            this.trkTemp.Size = new System.Drawing.Size(202, 90);
            this.trkTemp.TabIndex = 1;
            this.trkTemp.Value = 50;
            this.trkTemp.Scroll += new System.EventHandler(this.trkTemp_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "How warm is your home?";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(281, 112);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(64, 26);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "50 °F";
            // 
            // lblSuggestion
            // 
            this.lblSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuggestion.Location = new System.Drawing.Point(107, 150);
            this.lblSuggestion.Name = "lblSuggestion";
            this.lblSuggestion.Size = new System.Drawing.Size(125, 18);
            this.lblSuggestion.TabIndex = 5;
            this.lblSuggestion.Text = "Plant suggestion here";
            this.lblSuggestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkHousePlantInfo
            // 
            this.linkHousePlantInfo.AutoSize = true;
            this.linkHousePlantInfo.Location = new System.Drawing.Point(259, 195);
            this.linkHousePlantInfo.Name = "linkHousePlantInfo";
            this.linkHousePlantInfo.Size = new System.Drawing.Size(202, 26);
            this.linkHousePlantInfo.TabIndex = 6;
            this.linkHousePlantInfo.TabStop = true;
            this.linkHousePlantInfo.Text = "houseplant411.com";
            this.linkHousePlantInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkHousePlantInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHousePlantInfo_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 217);
            this.Controls.Add(this.linkHousePlantInfo);
            this.Controls.Add(this.lblSuggestion);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trkTemp);
            this.Controls.Add(this.chkSthFacing);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "Form1";
            this.Text = "Houseplant Suggestions";
            ((System.ComponentModel.ISupportInitialize)(this.trkTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSthFacing;
        private System.Windows.Forms.TrackBar trkTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblSuggestion;
        private System.Windows.Forms.LinkLabel linkHousePlantInfo;
    }
}

