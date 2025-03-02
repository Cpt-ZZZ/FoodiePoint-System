namespace IOOP_Assignment_Chef_Interface
{
    partial class v
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panelcfMenu = new System.Windows.Forms.Panel();
            this.btnIngredients = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panelcfMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(200, 254);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(136, 56);
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // panelcfMenu
            // 
            this.panelcfMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelcfMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelcfMenu.Controls.Add(this.btnProfile);
            this.panelcfMenu.Controls.Add(this.btnOrders);
            this.panelcfMenu.Controls.Add(this.btnIngredients);
            this.panelcfMenu.Controls.Add(this.btnLogOut);
            this.panelcfMenu.Location = new System.Drawing.Point(225, 159);
            this.panelcfMenu.Name = "panelcfMenu";
            this.panelcfMenu.Size = new System.Drawing.Size(541, 343);
            this.panelcfMenu.TabIndex = 9;
            // 
            // btnIngredients
            // 
            this.btnIngredients.Location = new System.Drawing.Point(200, 98);
            this.btnIngredients.Name = "btnIngredients";
            this.btnIngredients.Size = new System.Drawing.Size(136, 56);
            this.btnIngredients.TabIndex = 9;
            this.btnIngredients.Text = "Manage Ingredients";
            this.btnIngredients.UseVisualStyleBackColor = true;
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(200, 18);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(136, 56);
            this.btnOrders.TabIndex = 10;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(200, 175);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(136, 56);
            this.btnProfile.TabIndex = 11;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // v
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::IOOP_Assignment_Chef_Interface.Properties.Resources.Menu1;
            this.ClientSize = new System.Drawing.Size(1093, 819);
            this.Controls.Add(this.panelcfMenu);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "v";
            this.Text = "Chef\'s Interface";
            this.Load += new System.EventHandler(this.v_Load);
            this.panelcfMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panelcfMenu;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnIngredients;
    }
}

