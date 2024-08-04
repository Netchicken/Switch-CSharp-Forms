namespace Switch_CSharp_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRunSwitch = new Button();
            lbxDayOfWeek = new ListBox();
            btnLoadDOW = new Button();
            lbxAppointment = new ListBox();
            SuspendLayout();
            // 
            // btnRunSwitch
            // 
            btnRunSwitch.Location = new Point(73, 12);
            btnRunSwitch.Name = "btnRunSwitch";
            btnRunSwitch.Size = new Size(75, 23);
            btnRunSwitch.TabIndex = 0;
            btnRunSwitch.Text = "Run Switch";
            btnRunSwitch.UseVisualStyleBackColor = true;
            btnRunSwitch.Click += btnRunSwitch_Click;
            // 
            // lbxDayOfWeek
            // 
            lbxDayOfWeek.FormattingEnabled = true;
            lbxDayOfWeek.ItemHeight = 15;
            lbxDayOfWeek.Location = new Point(73, 76);
            lbxDayOfWeek.Name = "lbxDayOfWeek";
            lbxDayOfWeek.Size = new Size(100, 109);
            lbxDayOfWeek.TabIndex = 1;
            lbxDayOfWeek.SelectedIndexChanged += lbxDayOfWeek_SelectedIndexChanged;
            // 
            // btnLoadDOW
            // 
            btnLoadDOW.Location = new Point(73, 50);
            btnLoadDOW.Name = "btnLoadDOW";
            btnLoadDOW.Size = new Size(115, 23);
            btnLoadDOW.TabIndex = 2;
            btnLoadDOW.Text = "Load Days of Week";
            btnLoadDOW.UseVisualStyleBackColor = true;
            btnLoadDOW.Click += btnLoadDOW_Click;
            // 
            // lbxAppointment
            // 
            lbxAppointment.FormattingEnabled = true;
            lbxAppointment.ItemHeight = 15;
            lbxAppointment.Location = new Point(222, 76);
            lbxAppointment.Name = "lbxAppointment";
            lbxAppointment.Size = new Size(159, 109);
            lbxAppointment.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbxAppointment);
            Controls.Add(btnLoadDOW);
            Controls.Add(lbxDayOfWeek);
            Controls.Add(btnRunSwitch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRunSwitch;
        private ListBox lbxDayOfWeek;
        private Button btnLoadDOW;
        private ListBox lbxAppointment;
    }
}
