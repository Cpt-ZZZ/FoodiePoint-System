namespace IOOP_Assignment_Chef_Interface
{
    partial class frmIngredients
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
            this.btnCheck_Stock = new System.Windows.Forms.Button();
            this.listIngredients = new System.Windows.Forms.ListBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.panelIngredients = new System.Windows.Forms.Panel();
            this.btnRemove_Stock = new System.Windows.Forms.Button();
            this.btnAdd_Stock = new System.Windows.Forms.Button();
            this.panelIngredients.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheck_Stock
            // 
            this.btnCheck_Stock.Location = new System.Drawing.Point(17, 301);
            this.btnCheck_Stock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheck_Stock.Name = "btnCheck_Stock";
            this.btnCheck_Stock.Size = new System.Drawing.Size(116, 48);
            this.btnCheck_Stock.TabIndex = 9;
            this.btnCheck_Stock.Text = "Check Stock";
            this.btnCheck_Stock.UseVisualStyleBackColor = true;
            // 
            // listIngredients
            // 
            this.listIngredients.FormattingEnabled = true;
            this.listIngredients.ItemHeight = 24;
            this.listIngredients.Location = new System.Drawing.Point(17, 54);
            this.listIngredients.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.Size = new System.Drawing.Size(225, 220);
            this.listIngredients.TabIndex = 8;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(13, 12);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(114, 24);
            this.lblIngredients.TabIndex = 7;
            this.lblIngredients.Text = "Ingredients List:";
            // 
            // panelIngredients
            // 
            this.panelIngredients.Controls.Add(this.btnAdd_Stock);
            this.panelIngredients.Controls.Add(this.btnRemove_Stock);
            this.panelIngredients.Controls.Add(this.listIngredients);
            this.panelIngredients.Controls.Add(this.btnCheck_Stock);
            this.panelIngredients.Controls.Add(this.lblIngredients);
            this.panelIngredients.Location = new System.Drawing.Point(38, 12);
            this.panelIngredients.Name = "panelIngredients";
            this.panelIngredients.Size = new System.Drawing.Size(371, 515);
            this.panelIngredients.TabIndex = 10;
            // 
            // btnRemove_Stock
            // 
            this.btnRemove_Stock.Location = new System.Drawing.Point(17, 369);
            this.btnRemove_Stock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove_Stock.Name = "btnRemove_Stock";
            this.btnRemove_Stock.Size = new System.Drawing.Size(116, 48);
            this.btnRemove_Stock.TabIndex = 11;
            this.btnRemove_Stock.Text = "Remove Stock";
            this.btnRemove_Stock.UseVisualStyleBackColor = true;
            // 
            // btnAdd_Stock
            // 
            this.btnAdd_Stock.Location = new System.Drawing.Point(162, 301);
            this.btnAdd_Stock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd_Stock.Name = "btnAdd_Stock";
            this.btnAdd_Stock.Size = new System.Drawing.Size(116, 48);
            this.btnAdd_Stock.TabIndex = 12;
            this.btnAdd_Stock.Text = "Add Stock";
            this.btnAdd_Stock.UseVisualStyleBackColor = true;
            // 
            // frmIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.panelIngredients);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIngredients";
            this.Text = "frmIngredients";
            this.panelIngredients.ResumeLayout(false);
            this.panelIngredients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheck_Stock;
        private System.Windows.Forms.ListBox listIngredients;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Panel panelIngredients;
        private System.Windows.Forms.Button btnAdd_Stock;
        private System.Windows.Forms.Button btnRemove_Stock;
    }
}