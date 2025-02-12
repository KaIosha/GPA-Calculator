namespace Calculate_GPA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mt_NumbeOfHours = new System.Windows.Forms.MaskedTextBox();
            this.btnSave_NumberofHours = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mt_subjectOfHours = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave_TheDetails = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mt___letterGrade = new System.Windows.Forms.ComboBox();
            this.bnRestart = new System.Windows.Forms.Button();
            this.LbGPA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1029, 131);
            this.label1.TabIndex = 100;
            this.label1.Text = "GPA Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1145, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(9, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // mt_NumbeOfHours
            // 
            this.mt_NumbeOfHours.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_NumbeOfHours.ForeColor = System.Drawing.Color.Blue;
            this.mt_NumbeOfHours.Location = new System.Drawing.Point(402, 141);
            this.mt_NumbeOfHours.Name = "mt_NumbeOfHours";
            this.mt_NumbeOfHours.Size = new System.Drawing.Size(284, 32);
            this.mt_NumbeOfHours.TabIndex = 20;
            this.mt_NumbeOfHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSave_NumberofHours
            // 
            this.btnSave_NumberofHours.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_NumberofHours.ForeColor = System.Drawing.Color.Green;
            this.btnSave_NumberofHours.Location = new System.Drawing.Point(752, 128);
            this.btnSave_NumberofHours.Name = "btnSave_NumberofHours";
            this.btnSave_NumberofHours.Size = new System.Drawing.Size(116, 55);
            this.btnSave_NumberofHours.TabIndex = 0;
            this.btnSave_NumberofHours.Text = "Save";
            this.btnSave_NumberofHours.UseVisualStyleBackColor = true;
            this.btnSave_NumberofHours.Click += new System.EventHandler(this.btnSave_NumberofHours_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 67);
            this.label2.TabIndex = 18;
            this.label2.Text = "Number of Hours";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mt_subjectOfHours
            // 
            this.mt_subjectOfHours.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt_subjectOfHours.ForeColor = System.Drawing.Color.Blue;
            this.mt_subjectOfHours.Location = new System.Drawing.Point(162, 304);
            this.mt_subjectOfHours.Name = "mt_subjectOfHours";
            this.mt_subjectOfHours.Size = new System.Drawing.Size(284, 32);
            this.mt_subjectOfHours.TabIndex = 31;
            this.mt_subjectOfHours.Tag = "0";
            this.mt_subjectOfHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(559, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 40);
            this.label4.TabIndex = 29;
            this.label4.Text = "Course Grade";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave_TheDetails
            // 
            this.btnSave_TheDetails.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave_TheDetails.ForeColor = System.Drawing.Color.Green;
            this.btnSave_TheDetails.Location = new System.Drawing.Point(444, 383);
            this.btnSave_TheDetails.Name = "btnSave_TheDetails";
            this.btnSave_TheDetails.Size = new System.Drawing.Size(85, 75);
            this.btnSave_TheDetails.TabIndex = 0;
            this.btnSave_TheDetails.Text = "Save";
            this.btnSave_TheDetails.UseVisualStyleBackColor = true;
            this.btnSave_TheDetails.Click += new System.EventHandler(this.btnSave_TheDetails_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 40);
            this.label3.TabIndex = 27;
            this.label3.Text = "Course Hours";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mt___letterGrade
            // 
            this.mt___letterGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mt___letterGrade.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mt___letterGrade.FormattingEnabled = true;
            this.mt___letterGrade.Items.AddRange(new object[] {
            "A",
            "A-",
            "Abs",
            "B",
            "B-",
            "B+",
            "C",
            "C-",
            "C+",
            "D",
            "D+",
            "F"});
            this.mt___letterGrade.Location = new System.Drawing.Point(541, 304);
            this.mt___letterGrade.Name = "mt___letterGrade";
            this.mt___letterGrade.Size = new System.Drawing.Size(288, 32);
            this.mt___letterGrade.TabIndex = 33;
            this.mt___letterGrade.Tag = "0";
            // 
            // bnRestart
            // 
            this.bnRestart.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnRestart.ForeColor = System.Drawing.Color.Red;
            this.bnRestart.Location = new System.Drawing.Point(882, 128);
            this.bnRestart.Name = "bnRestart";
            this.bnRestart.Size = new System.Drawing.Size(126, 57);
            this.bnRestart.TabIndex = 35;
            this.bnRestart.Text = "Restart";
            this.bnRestart.UseVisualStyleBackColor = true;
            this.bnRestart.Click += new System.EventHandler(this.bnRestart_Click);
            // 
            // LbGPA
            // 
            this.LbGPA.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbGPA.ForeColor = System.Drawing.Color.Chartreuse;
            this.LbGPA.Location = new System.Drawing.Point(259, 287);
            this.LbGPA.Name = "LbGPA";
            this.LbGPA.Size = new System.Drawing.Size(560, 118);
            this.LbGPA.TabIndex = 0;
            this.LbGPA.Text = " ";
            this.LbGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LbGPA.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 535);
            this.Controls.Add(this.LbGPA);
            this.Controls.Add(this.bnRestart);
            this.Controls.Add(this.mt___letterGrade);
            this.Controls.Add(this.mt_subjectOfHours);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave_TheDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mt_NumbeOfHours);
            this.Controls.Add(this.btnSave_NumberofHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "GPA Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox mt_NumbeOfHours;
        private System.Windows.Forms.Button btnSave_NumberofHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mt_subjectOfHours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave_TheDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox mt___letterGrade;
        private System.Windows.Forms.Button bnRestart;
        private System.Windows.Forms.Label LbGPA;
    }
}

