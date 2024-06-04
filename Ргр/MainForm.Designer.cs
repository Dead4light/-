namespace BigIntApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBigInt;
        private System.Windows.Forms.TextBox txtDigit;
        private System.Windows.Forms.Button btnAddDigit;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.TextBox txtNewDigit;
        private System.Windows.Forms.Button btnSetDigit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblBigInt = new System.Windows.Forms.Label();
            this.txtDigit = new System.Windows.Forms.TextBox();
            this.btnAddDigit = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtNewDigit = new System.Windows.Forms.TextBox();
            this.btnSetDigit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBigInt
            // 
            this.lblBigInt.AutoSize = true;
            this.lblBigInt.Location = new System.Drawing.Point(13, 13);
            this.lblBigInt.Name = "lblBigInt";
            this.lblBigInt.Size = new System.Drawing.Size(50, 20);
            this.lblBigInt.TabIndex = 0;
            this.lblBigInt.Text = "BigInt:";
            // 
            // txtDigit
            // 
            this.txtDigit.Location = new System.Drawing.Point(13, 50);
            this.txtDigit.Name = "txtDigit";
            this.txtDigit.Size = new System.Drawing.Size(100, 27);
            this.txtDigit.TabIndex = 1;
            // 
            // btnAddDigit
            // 
            this.btnAddDigit.Location = new System.Drawing.Point(120, 50);
            this.btnAddDigit.Name = "btnAddDigit";
            this.btnAddDigit.Size = new System.Drawing.Size(75, 27);
            this.btnAddDigit.TabIndex = 2;
            this.btnAddDigit.Text = "Add Digit";
            this.btnAddDigit.UseVisualStyleBackColor = true;
            this.btnAddDigit.Click += new System.EventHandler(this.btnAddDigit_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(13, 100);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(50, 27);
            this.txtIndex.TabIndex = 3;
            // 
            // txtNewDigit
            // 
            this.txtNewDigit.Location = new System.Drawing.Point(70, 100);
            this.txtNewDigit.Name = "txtNewDigit";
            this.txtNewDigit.Size = new System.Drawing.Size(50, 27);
            this.txtNewDigit.TabIndex = 4;
            // 
            // btnSetDigit
            // 
            this.btnSetDigit.Location = new System.Drawing.Point(120, 100);
            this.btnSetDigit.Name = "btnSetDigit";
            this.btnSetDigit.Size = new System.Drawing.Size(75, 27);
            this.btnSetDigit.TabIndex = 5;
            this.btnSetDigit.Text = "Set Digit";
            this.btnSetDigit.UseVisualStyleBackColor = true;
            this.btnSetDigit.Click += new System.EventHandler(this.btnSetDigit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnSetDigit);
            this.Controls.Add(this.txtNewDigit);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.btnAddDigit);
            this.Controls.Add(this.txtDigit);
            this.Controls.Add(this.lblBigInt);
            this.Name = "MainForm";
            this.Text = "BigIntApp";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
