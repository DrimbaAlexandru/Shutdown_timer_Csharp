namespace WindowsFormsApplication3
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
            this.btn_cancel_shutdown = new System.Windows.Forms.Button();
            this.btn_set_shutdown = new System.Windows.Forms.Button();
            this.Time_picker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_shutdown_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel_shutdown
            // 
            this.btn_cancel_shutdown.Location = new System.Drawing.Point(136, 41);
            this.btn_cancel_shutdown.Name = "btn_cancel_shutdown";
            this.btn_cancel_shutdown.Size = new System.Drawing.Size(100, 23);
            this.btn_cancel_shutdown.TabIndex = 0;
            this.btn_cancel_shutdown.Text = "Cancel shutdown";
            this.btn_cancel_shutdown.UseVisualStyleBackColor = true;
            this.btn_cancel_shutdown.Click += new System.EventHandler(this.btn_cancel_shutdown_Click);
            // 
            // btn_set_shutdown
            // 
            this.btn_set_shutdown.Location = new System.Drawing.Point(136, 7);
            this.btn_set_shutdown.Name = "btn_set_shutdown";
            this.btn_set_shutdown.Size = new System.Drawing.Size(100, 23);
            this.btn_set_shutdown.TabIndex = 1;
            this.btn_set_shutdown.Text = "Set shutdown";
            this.btn_set_shutdown.UseVisualStyleBackColor = true;
            this.btn_set_shutdown.Click += new System.EventHandler(this.btn_set_shutdown_Click);
            // 
            // Time_picker
            // 
            this.Time_picker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Time_picker.Location = new System.Drawing.Point(47, 10);
            this.Time_picker.Name = "Time_picker";
            this.Time_picker.ShowUpDown = true;
            this.Time_picker.Size = new System.Drawing.Size(77, 20);
            this.Time_picker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time:";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(57, 46);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(49, 13);
            this.lbl_time.TabIndex = 4;
            this.lbl_time.Text = "12:34:56";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Shutdown time:";
            // 
            // lbl_shutdown_time
            // 
            this.lbl_shutdown_time.AutoSize = true;
            this.lbl_shutdown_time.Location = new System.Drawing.Point(148, 78);
            this.lbl_shutdown_time.Name = "lbl_shutdown_time";
            this.lbl_shutdown_time.Size = new System.Drawing.Size(88, 13);
            this.lbl_shutdown_time.TabIndex = 6;
            this.lbl_shutdown_time.Text = "NOT ASSIGNED";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 120);
            this.Controls.Add(this.lbl_shutdown_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Time_picker);
            this.Controls.Add(this.btn_set_shutdown);
            this.Controls.Add(this.btn_cancel_shutdown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel_shutdown;
        private System.Windows.Forms.Button btn_set_shutdown;
        private System.Windows.Forms.DateTimePicker Time_picker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_shutdown_time;
    }
}

