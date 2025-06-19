namespace ll
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.textBoxCat = new System.Windows.Forms.TextBox();
            this.comboBoxBreed = new System.Windows.Forms.ComboBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonAppointment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDetails = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cat Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 180);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Breed";
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(143, 111);
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(172, 22);
            this.textBoxOwner.TabIndex = 3;
            // 
            // textBoxCat
            // 
            this.textBoxCat.Location = new System.Drawing.Point(143, 143);
            this.textBoxCat.Name = "textBoxCat";
            this.textBoxCat.Size = new System.Drawing.Size(172, 22);
            this.textBoxCat.TabIndex = 5;
            // 
            // comboBoxBreed
            // 
            this.comboBoxBreed.FormattingEnabled = true;
            this.comboBoxBreed.Items.AddRange(new object[] {
            "Ha",
            "Hu",
            "Hi",
            "Ho",
            "He"});
            this.comboBoxBreed.Location = new System.Drawing.Point(122, 172);
            this.comboBoxBreed.Name = "comboBoxBreed";
            this.comboBoxBreed.Size = new System.Drawing.Size(193, 24);
            this.comboBoxBreed.TabIndex = 6;
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(48, 225);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(143, 34);
            this.buttonNew.TabIndex = 7;
            this.buttonNew.Text = "New Appointment";
            this.buttonNew.UseVisualStyleBackColor = true;
            // 
            // buttonAppointment
            // 
            this.buttonAppointment.Location = new System.Drawing.Point(197, 225);
            this.buttonAppointment.Name = "buttonAppointment";
            this.buttonAppointment.Size = new System.Drawing.Size(144, 34);
            this.buttonAppointment.TabIndex = 8;
            this.buttonAppointment.Text = "Set Appointment";
            this.buttonAppointment.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Choose Available Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelDetails
            // 
            this.labelDetails.AutoSize = true;
            this.labelDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetails.Location = new System.Drawing.Point(48, 275);
            this.labelDetails.Name = "labelDetails";
            this.labelDetails.Size = new System.Drawing.Size(228, 29);
            this.labelDetails.TabIndex = 11;
            this.labelDetails.Text = "Appointment Details";
            this.labelDetails.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(389, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelDetails);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAppointment);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.comboBoxBreed);
            this.Controls.Add(this.textBoxCat);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.TextBox textBoxCat;
        private System.Windows.Forms.ComboBox comboBoxBreed;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonAppointment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}