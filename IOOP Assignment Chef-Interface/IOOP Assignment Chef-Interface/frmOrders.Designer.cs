namespace IOOP_Assignment_Chef_Interface
{
    partial class frmOrders
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
            this.panelChef = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.txtOrders = new System.Windows.Forms.TextBox();
            this.listOrder = new System.Windows.Forms.ListBox();
            this.lblView = new System.Windows.Forms.Label();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.grpStatus = new System.Windows.Forms.GroupBox();
            this.radReady = new System.Windows.Forms.RadioButton();
            this.radCancel = new System.Windows.Forms.RadioButton();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.panelChef.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.grpStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChef
            // 
            this.panelChef.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelChef.Controls.Add(this.btnView);
            this.panelChef.Controls.Add(this.txtOrders);
            this.panelChef.Controls.Add(this.listOrder);
            this.panelChef.Controls.Add(this.lblView);
            this.panelChef.Location = new System.Drawing.Point(30, 46);
            this.panelChef.Name = "panelChef";
            this.panelChef.Size = new System.Drawing.Size(380, 339);
            this.panelChef.TabIndex = 1;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(18, 278);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(116, 32);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            // 
            // txtOrders
            // 
            this.txtOrders.Location = new System.Drawing.Point(18, 240);
            this.txtOrders.Name = "txtOrders";
            this.txtOrders.Size = new System.Drawing.Size(116, 32);
            this.txtOrders.TabIndex = 3;
            this.txtOrders.TextChanged += new System.EventHandler(this.txtOrders_TextChanged);
            // 
            // listOrder
            // 
            this.listOrder.FormattingEnabled = true;
            this.listOrder.ItemHeight = 24;
            this.listOrder.Items.AddRange(new object[] {
            "No.01",
            "No.02",
            "No.03"});
            this.listOrder.Location = new System.Drawing.Point(18, 59);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(207, 148);
            this.listOrder.TabIndex = 2;
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Location = new System.Drawing.Point(14, 15);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(96, 24);
            this.lblView.TabIndex = 1;
            this.lblView.Text = "View Orders: ";
            // 
            // grpOrder
            // 
            this.grpOrder.BackColor = System.Drawing.Color.Silver;
            this.grpOrder.Controls.Add(this.grpStatus);
            this.grpOrder.Controls.Add(this.btnUpdateOrder);
            this.grpOrder.Controls.Add(this.lblStatus);
            this.grpOrder.Controls.Add(this.lblTable);
            this.grpOrder.Controls.Add(this.lblDetails);
            this.grpOrder.Controls.Add(this.lblNo);
            this.grpOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpOrder.Location = new System.Drawing.Point(529, 46);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(360, 427);
            this.grpOrder.TabIndex = 2;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order Details:";
            // 
            // grpStatus
            // 
            this.grpStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpStatus.Controls.Add(this.radReady);
            this.grpStatus.Controls.Add(this.radCancel);
            this.grpStatus.Location = new System.Drawing.Point(30, 321);
            this.grpStatus.Name = "grpStatus";
            this.grpStatus.Size = new System.Drawing.Size(295, 53);
            this.grpStatus.TabIndex = 2;
            this.grpStatus.TabStop = false;
            this.grpStatus.Text = "Status";
            // 
            // radReady
            // 
            this.radReady.AutoSize = true;
            this.radReady.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radReady.Location = new System.Drawing.Point(41, 22);
            this.radReady.Name = "radReady";
            this.radReady.Size = new System.Drawing.Size(66, 25);
            this.radReady.TabIndex = 5;
            this.radReady.TabStop = true;
            this.radReady.Text = "Ready";
            this.radReady.UseVisualStyleBackColor = true;
            // 
            // radCancel
            // 
            this.radCancel.AutoSize = true;
            this.radCancel.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCancel.Location = new System.Drawing.Point(157, 22);
            this.radCancel.Name = "radCancel";
            this.radCancel.Size = new System.Drawing.Size(69, 25);
            this.radCancel.TabIndex = 6;
            this.radCancel.TabStop = true;
            this.radCancel.Text = "Cancel";
            this.radCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(30, 389);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(116, 32);
            this.btnUpdateOrder.TabIndex = 4;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 93);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(55, 24);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status:";
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(6, 59);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(48, 24);
            this.lblTable.TabIndex = 2;
            this.lblTable.Text = "Table:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(6, 129);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(59, 24);
            this.lblDetails.TabIndex = 1;
            this.lblDetails.Text = "Details:";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(6, 28);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(71, 24);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "Order No:";
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 675);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.panelChef);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOrders";
            this.Text = "frmOrders";
            this.panelChef.ResumeLayout(false);
            this.panelChef.PerformLayout();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.grpStatus.ResumeLayout(false);
            this.grpStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChef;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txtOrders;
        private System.Windows.Forms.ListBox listOrder;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.GroupBox grpStatus;
        private System.Windows.Forms.RadioButton radReady;
        private System.Windows.Forms.RadioButton radCancel;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblNo;
    }
}