namespace IOOP_Assignment_Chef_Interface
{
    partial class frmProfile
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
            this.grpProfile = new System.Windows.Forms.GroupBox();
            this.lblcfHours = new System.Windows.Forms.Label();
            this.btnUpdateProf = new System.Windows.Forms.Button();
            this.lblcfPosition = new System.Windows.Forms.Label();
            this.lblcfName = new System.Windows.Forms.Label();
            this.btnViewProf = new System.Windows.Forms.Button();
            this.txtcfName = new System.Windows.Forms.TextBox();
            this.txtcfHours = new System.Windows.Forms.TextBox();
            this.txtcfPosition = new System.Windows.Forms.TextBox();
            this.grpProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProfile
            // 
            this.grpProfile.Controls.Add(this.txtcfPosition);
            this.grpProfile.Controls.Add(this.txtcfHours);
            this.grpProfile.Controls.Add(this.txtcfName);
            this.grpProfile.Controls.Add(this.btnViewProf);
            this.grpProfile.Controls.Add(this.lblcfHours);
            this.grpProfile.Controls.Add(this.btnUpdateProf);
            this.grpProfile.Controls.Add(this.lblcfPosition);
            this.grpProfile.Controls.Add(this.lblcfName);
            this.grpProfile.Location = new System.Drawing.Point(152, 55);
            this.grpProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpProfile.Name = "grpProfile";
            this.grpProfile.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpProfile.Size = new System.Drawing.Size(360, 435);
            this.grpProfile.TabIndex = 8;
            this.grpProfile.TabStop = false;
            this.grpProfile.Text = "Profile";
            // 
            // lblcfHours
            // 
            this.lblcfHours.AutoSize = true;
            this.lblcfHours.Location = new System.Drawing.Point(6, 220);
            this.lblcfHours.Name = "lblcfHours";
            this.lblcfHours.Size = new System.Drawing.Size(106, 24);
            this.lblcfHours.TabIndex = 7;
            this.lblcfHours.Text = "Working Hours:";
            // 
            // btnUpdateProf
            // 
            this.btnUpdateProf.Location = new System.Drawing.Point(182, 379);
            this.btnUpdateProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateProf.Name = "btnUpdateProf";
            this.btnUpdateProf.Size = new System.Drawing.Size(116, 48);
            this.btnUpdateProf.TabIndex = 5;
            this.btnUpdateProf.Text = "Update Profile";
            this.btnUpdateProf.UseVisualStyleBackColor = true;
            // 
            // lblcfPosition
            // 
            this.lblcfPosition.AutoSize = true;
            this.lblcfPosition.Location = new System.Drawing.Point(6, 148);
            this.lblcfPosition.Name = "lblcfPosition";
            this.lblcfPosition.Size = new System.Drawing.Size(65, 24);
            this.lblcfPosition.TabIndex = 6;
            this.lblcfPosition.Text = "Position:";
            // 
            // lblcfName
            // 
            this.lblcfName.AutoSize = true;
            this.lblcfName.Location = new System.Drawing.Point(6, 80);
            this.lblcfName.Name = "lblcfName";
            this.lblcfName.Size = new System.Drawing.Size(51, 24);
            this.lblcfName.TabIndex = 5;
            this.lblcfName.Text = "Name:";
            // 
            // btnViewProf
            // 
            this.btnViewProf.Location = new System.Drawing.Point(41, 379);
            this.btnViewProf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnViewProf.Name = "btnViewProf";
            this.btnViewProf.Size = new System.Drawing.Size(116, 48);
            this.btnViewProf.TabIndex = 8;
            this.btnViewProf.Text = "View Profile";
            this.btnViewProf.UseVisualStyleBackColor = true;
            // 
            // txtcfName
            // 
            this.txtcfName.Location = new System.Drawing.Point(118, 80);
            this.txtcfName.Name = "txtcfName";
            this.txtcfName.Size = new System.Drawing.Size(218, 32);
            this.txtcfName.TabIndex = 9;
            // 
            // txtcfHours
            // 
            this.txtcfHours.Location = new System.Drawing.Point(118, 220);
            this.txtcfHours.Name = "txtcfHours";
            this.txtcfHours.Size = new System.Drawing.Size(218, 32);
            this.txtcfHours.TabIndex = 10;
            // 
            // txtcfPosition
            // 
            this.txtcfPosition.Location = new System.Drawing.Point(118, 148);
            this.txtcfPosition.Name = "txtcfPosition";
            this.txtcfPosition.Size = new System.Drawing.Size(218, 32);
            this.txtcfPosition.TabIndex = 11;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.grpProfile);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProfile";
            this.Text = "frmProfile";
            this.grpProfile.ResumeLayout(false);
            this.grpProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.Label lblcfHours;
        private System.Windows.Forms.Button btnUpdateProf;
        private System.Windows.Forms.Label lblcfPosition;
        private System.Windows.Forms.Label lblcfName;
        private System.Windows.Forms.TextBox txtcfName;
        private System.Windows.Forms.Button btnViewProf;
        private System.Windows.Forms.TextBox txtcfPosition;
        private System.Windows.Forms.TextBox txtcfHours;
    }
}