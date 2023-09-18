namespace Orphanage_Care_Manager
{
    partial class RequirementAddForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.txtOrphanageID = new System.Windows.Forms.TextBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(464, 398);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(156, 45);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // txtOrphanageID
            // 
            this.txtOrphanageID.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrphanageID.Location = new System.Drawing.Point(293, 264);
            this.txtOrphanageID.Name = "txtOrphanageID";
            this.txtOrphanageID.Size = new System.Drawing.Size(100, 38);
            this.txtOrphanageID.TabIndex = 20;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(293, 204);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(134, 38);
            this.nudQuantity.TabIndex = 19;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(293, 147);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(264, 38);
            this.txtItemName.TabIndex = 18;
            // 
            // txtItemID
            // 
            this.txtItemID.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(293, 82);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(100, 38);
            this.txtItemID.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Orphanage ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 27);
            this.label5.TabIndex = 14;
            this.label5.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "Item ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 27);
            this.label3.TabIndex = 12;
            this.label3.Text = "ADD REQUIREMENTS";
            // 
            // RequirementAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 673);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.txtOrphanageID);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequirementAddForm";
            this.Text = "RequirementAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox txtOrphanageID;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}