namespace Projeto_PetShop2022
{
    partial class frnCadservicos
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnsaveser = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.cmbservices = new System.Windows.Forms.ComboBox();
            this.cmbpet = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.msktxtdate = new System.Windows.Forms.MaskedTextBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtticket = new System.Windows.Forms.TextBox();
            this.lblticket = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltime = new System.Windows.Forms.Label();
            this.mskTime = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnsaveser
            // 
            this.btnsaveser.BackColor = System.Drawing.Color.Transparent;
            this.btnsaveser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaveser.Location = new System.Drawing.Point(496, 441);
            this.btnsaveser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsaveser.Name = "btnsaveser";
            this.btnsaveser.Size = new System.Drawing.Size(65, 37);
            this.btnsaveser.TabIndex = 1;
            this.btnsaveser.Text = "Save";
            this.btnsaveser.UseVisualStyleBackColor = false;
            this.btnsaveser.Click += new System.EventHandler(this.btnsaveser_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Location = new System.Drawing.Point(585, 441);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(65, 37);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Clear";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // cmbservices
            // 
            this.cmbservices.FormattingEnabled = true;
            this.cmbservices.Items.AddRange(new object[] {
            "Dog Walking",
            "Pet Daycare",
            "Pet Spa",
            "Pet Hotel",
            "Pet Training",
            "Pet Grooming"});
            this.cmbservices.Location = new System.Drawing.Point(156, 121);
            this.cmbservices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbservices.Name = "cmbservices";
            this.cmbservices.Size = new System.Drawing.Size(166, 29);
            this.cmbservices.TabIndex = 3;
            // 
            // cmbpet
            // 
            this.cmbpet.FormattingEnabled = true;
            this.cmbpet.Items.AddRange(new object[] {
            "Dog",
            "Cat"});
            this.cmbpet.Location = new System.Drawing.Point(156, 188);
            this.cmbpet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbpet.Name = "cmbpet";
            this.cmbpet.Size = new System.Drawing.Size(87, 29);
            this.cmbpet.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(62, 196);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Dog/Cat";
            // 
            // msktxtdate
            // 
            this.msktxtdate.Location = new System.Drawing.Point(156, 254);
            this.msktxtdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.msktxtdate.Mask = "00/00/0000";
            this.msktxtdate.Name = "msktxtdate";
            this.msktxtdate.Size = new System.Drawing.Size(87, 26);
            this.msktxtdate.TabIndex = 19;
            this.msktxtdate.ValidatingType = typeof(System.DateTime);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Location = new System.Drawing.Point(62, 259);
            this.lbldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(37, 21);
            this.lbldate.TabIndex = 20;
            this.lbldate.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Services";
            // 
            // txtticket
            // 
            this.txtticket.Location = new System.Drawing.Point(156, 366);
            this.txtticket.Name = "txtticket";
            this.txtticket.Size = new System.Drawing.Size(76, 26);
            this.txtticket.TabIndex = 22;
            // 
            // lblticket
            // 
            this.lblticket.AutoSize = true;
            this.lblticket.BackColor = System.Drawing.Color.Transparent;
            this.lblticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblticket.ForeColor = System.Drawing.Color.White;
            this.lblticket.Location = new System.Drawing.Point(62, 371);
            this.lblticket.Name = "lblticket";
            this.lblticket.Size = new System.Drawing.Size(85, 21);
            this.lblticket.TabIndex = 23;
            this.lblticket.Text = "Reference Nº";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Projeto_PetShop2022.Properties.Resources.go_to_icon_21;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(254, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 24);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Location = new System.Drawing.Point(62, 313);
            this.lbltime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(38, 21);
            this.lbltime.TabIndex = 25;
            this.lbltime.Text = "Time";
            // 
            // mskTime
            // 
            this.mskTime.Location = new System.Drawing.Point(156, 308);
            this.mskTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskTime.Mask = "00:00";
            this.mskTime.Name = "mskTime";
            this.mskTime.Size = new System.Drawing.Size(56, 26);
            this.mskTime.TabIndex = 26;
            this.mskTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskTime.ValidatingType = typeof(System.DateTime);
            // 
            // frnCadservicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Projeto_PetShop2022.Properties.Resources.bluesky1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(786, 749);
            this.Controls.Add(this.mskTime);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblticket);
            this.Controls.Add(this.txtticket);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.msktxtdate);
            this.Controls.Add(this.btnsaveser);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.cmbservices);
            this.Controls.Add(this.cmbpet);
            this.Controls.Add(this.label9);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frnCadservicos";
            this.Text = "frnCadservicos";
            this.Load += new System.EventHandler(this.frnCadservicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsaveser;
        private System.Windows.Forms.ComboBox cmbservices;
        private System.Windows.Forms.ComboBox cmbpet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.MaskedTextBox msktxtdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblticket;
        private System.Windows.Forms.TextBox txtticket;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox mskTime;
        private System.Windows.Forms.Label lbltime;
    }
}