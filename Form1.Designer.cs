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
            lbxDayOfWeek = new ListBox();
            btnLoadDOW = new Button();
            lbxAppointment = new ListBox();
            btnStringOp = new Button();
            lbxStringOp = new ListBox();
            txtAmount = new TextBox();
            btnTryParse = new Button();
            txtName1 = new TextBox();
            txtName2 = new TextBox();
            txtPercent = new TextBox();
            txtNumber = new TextBox();
            btnPercentage = new Button();
            label1 = new Label();
            label2 = new Label();
            lblPercent = new Label();
            lblpercentMinus = new Label();
            SuspendLayout();
            // 
            // lbxDayOfWeek
            // 
            lbxDayOfWeek.FormattingEnabled = true;
            lbxDayOfWeek.ItemHeight = 15;
            lbxDayOfWeek.Location = new Point(73, 46);
            lbxDayOfWeek.Name = "lbxDayOfWeek";
            lbxDayOfWeek.Size = new Size(100, 139);
            lbxDayOfWeek.TabIndex = 1;
            lbxDayOfWeek.SelectedIndexChanged += lbxDayOfWeek_SelectedIndexChanged;
            // 
            // btnLoadDOW
            // 
            btnLoadDOW.Location = new Point(73, 12);
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
            lbxAppointment.Location = new Point(179, 46);
            lbxAppointment.Name = "lbxAppointment";
            lbxAppointment.Size = new Size(159, 139);
            lbxAppointment.TabIndex = 3;
            // 
            // btnStringOp
            // 
            btnStringOp.Location = new Point(456, 60);
            btnStringOp.Name = "btnStringOp";
            btnStringOp.Size = new Size(133, 25);
            btnStringOp.TabIndex = 4;
            btnStringOp.Text = "String Operations";
            btnStringOp.UseVisualStyleBackColor = true;
            btnStringOp.Click += btnStringOp_Click;
            // 
            // lbxStringOp
            // 
            lbxStringOp.FormattingEnabled = true;
            lbxStringOp.ItemHeight = 15;
            lbxStringOp.Location = new Point(460, 116);
            lbxStringOp.Name = "lbxStringOp";
            lbxStringOp.Size = new Size(328, 259);
            lbxStringOp.TabIndex = 5;
            lbxStringOp.SelectedIndexChanged += lbxStringOp_SelectedIndexChanged;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(73, 238);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 23);
            txtAmount.TabIndex = 6;
            // 
            // btnTryParse
            // 
            btnTryParse.Location = new Point(73, 207);
            btnTryParse.Name = "btnTryParse";
            btnTryParse.Size = new Size(133, 25);
            btnTryParse.TabIndex = 7;
            btnTryParse.Text = "Try Parse";
            btnTryParse.UseVisualStyleBackColor = true;
            btnTryParse.Click += btnTryParse_Click;
            // 
            // txtName1
            // 
            txtName1.Location = new Point(489, 85);
            txtName1.Name = "txtName1";
            txtName1.Size = new Size(107, 23);
            txtName1.TabIndex = 8;
            // 
            // txtName2
            // 
            txtName2.Location = new Point(611, 85);
            txtName2.Name = "txtName2";
            txtName2.Size = new Size(107, 23);
            txtName2.TabIndex = 9;
            // 
            // txtPercent
            // 
            txtPercent.Location = new Point(118, 342);
            txtPercent.Name = "txtPercent";
            txtPercent.Size = new Size(100, 23);
            txtPercent.TabIndex = 10;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(12, 342);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 11;
            // 
            // btnPercentage
            // 
            btnPercentage.Location = new Point(12, 299);
            btnPercentage.Name = "btnPercentage";
            btnPercentage.Size = new Size(151, 23);
            btnPercentage.TabIndex = 12;
            btnPercentage.Text = "Working out percents";
            btnPercentage.UseVisualStyleBackColor = true;
            btnPercentage.Click += btnPercentage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 324);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 13;
            label1.Text = "Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 324);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 14;
            label2.Text = "Percent";
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(16, 376);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(38, 15);
            lblPercent.TabIndex = 15;
            lblPercent.Text = "label3";
            // 
            // lblpercentMinus
            // 
            lblpercentMinus.AutoSize = true;
            lblpercentMinus.Location = new Point(16, 404);
            lblpercentMinus.Name = "lblpercentMinus";
            lblpercentMinus.Size = new Size(38, 15);
            lblpercentMinus.TabIndex = 16;
            lblpercentMinus.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblpercentMinus);
            Controls.Add(lblPercent);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnPercentage);
            Controls.Add(txtNumber);
            Controls.Add(txtPercent);
            Controls.Add(txtName2);
            Controls.Add(txtName1);
            Controls.Add(btnTryParse);
            Controls.Add(txtAmount);
            Controls.Add(lbxStringOp);
            Controls.Add(btnStringOp);
            Controls.Add(lbxAppointment);
            Controls.Add(btnLoadDOW);
            Controls.Add(lbxDayOfWeek);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox lbxDayOfWeek;
        private Button btnLoadDOW;
        private ListBox lbxAppointment;
        private Button btnStringOp;
        private ListBox lbxStringOp;
        private TextBox txtAmount;
        private Button btnTryParse;
        private TextBox txtName1;
        private TextBox txtName2;
        private TextBox txtPercent;
        private TextBox txtNumber;
        private Button btnPercentage;
        private Label label1;
        private Label label2;
        private Label lblPercent;
        private Label lblpercentMinus;
    }
}
