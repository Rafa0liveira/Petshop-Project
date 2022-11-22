namespace Projeto_PetShop2022
{
    partial class frmCadcliente
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpetname = new System.Windows.Forms.TextBox();
            this.cmboxanimal = new System.Windows.Forms.ComboBox();
            this.txtbreed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsavecad = new System.Windows.Forms.Button();
            this.btnclearCad = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(434, 26);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(137, 120);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(434, 26);
            this.txtaddr.TabIndex = 1;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(137, 162);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(259, 26);
            this.txtphone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "CUSTOMER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // txtpetname
            // 
            this.txtpetname.Location = new System.Drawing.Point(137, 302);
            this.txtpetname.Name = "txtpetname";
            this.txtpetname.Size = new System.Drawing.Size(185, 26);
            this.txtpetname.TabIndex = 7;
            // 
            // cmboxanimal
            // 
            this.cmboxanimal.FormattingEnabled = true;
            this.cmboxanimal.Items.AddRange(new object[] {
            "Dog",
            "Cat"});
            this.cmboxanimal.Location = new System.Drawing.Point(137, 385);
            this.cmboxanimal.Name = "cmboxanimal";
            this.cmboxanimal.Size = new System.Drawing.Size(88, 28);
            this.cmboxanimal.TabIndex = 8;
            this.cmboxanimal.SelectedIndexChanged += new System.EventHandler(this.cmboxanimal_SelectedIndexChanged);
            // 
            // txtbreed
            // 
            this.txtbreed.Location = new System.Drawing.Point(137, 345);
            this.txtbreed.Name = "txtbreed";
            this.txtbreed.Size = new System.Drawing.Size(115, 26);
            this.txtbreed.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(310, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "PET";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(137, 208);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(434, 26);
            this.txtemail.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(40, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Email";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnsavecad
            // 
            this.btnsavecad.BackColor = System.Drawing.Color.Transparent;
            this.btnsavecad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsavecad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavecad.ForeColor = System.Drawing.Color.White;
            this.btnsavecad.Location = new System.Drawing.Point(441, 454);
            this.btnsavecad.Name = "btnsavecad";
            this.btnsavecad.Size = new System.Drawing.Size(88, 49);
            this.btnsavecad.TabIndex = 15;
            this.btnsavecad.Text = "Save";
            this.btnsavecad.UseVisualStyleBackColor = false;
            this.btnsavecad.Click += new System.EventHandler(this.btnsavecad_Click);
            // 
            // btnclearCad
            // 
            this.btnclearCad.BackColor = System.Drawing.Color.Transparent;
            this.btnclearCad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclearCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclearCad.ForeColor = System.Drawing.Color.White;
            this.btnclearCad.Location = new System.Drawing.Point(547, 454);
            this.btnclearCad.Name = "btnclearCad";
            this.btnclearCad.Size = new System.Drawing.Size(94, 49);
            this.btnclearCad.TabIndex = 16;
            this.btnclearCad.Text = "Reset";
            this.btnclearCad.UseVisualStyleBackColor = false;
            this.btnclearCad.Click += new System.EventHandler(this.btnclearCad_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(30, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Dog/Cat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Breed";
            // 
            // frmCadcliente
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::Projeto_PetShop2022.Properties.Resources.bluesky;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 573);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnclearCad);
            this.Controls.Add(this.btnsavecad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbreed);
            this.Controls.Add(this.cmboxanimal);
            this.Controls.Add(this.txtpetname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtaddr);
            this.Controls.Add(this.txtName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadcliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadcliente";
            this.Load += new System.EventHandler(this.frmCadcliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtaddr;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpetname;
        private System.Windows.Forms.ComboBox cmboxanimal;
        private System.Windows.Forms.TextBox txtbreed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsavecad;
        private System.Windows.Forms.Button btnclearCad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
    }
}