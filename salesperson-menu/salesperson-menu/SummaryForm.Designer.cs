namespace salesperson_menu
{
    partial class SummaryForm
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
            this.SalesL = new System.Windows.Forms.Label();
            this.ComL = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PayL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Sales:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SalesL
            // 
            this.SalesL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SalesL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesL.Location = new System.Drawing.Point(189, 36);
            this.SalesL.Name = "SalesL";
            this.SalesL.Size = new System.Drawing.Size(188, 23);
            this.SalesL.TabIndex = 1;
            this.SalesL.Text = "label2";
            this.SalesL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComL
            // 
            this.ComL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ComL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ComL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComL.Location = new System.Drawing.Point(189, 74);
            this.ComL.Name = "ComL";
            this.ComL.Size = new System.Drawing.Size(188, 23);
            this.ComL.TabIndex = 3;
            this.ComL.Text = "label3";
            this.ComL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(28, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Commissions:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PayL
            // 
            this.PayL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PayL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PayL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayL.Location = new System.Drawing.Point(189, 112);
            this.PayL.Name = "PayL";
            this.PayL.Size = new System.Drawing.Size(188, 23);
            this.PayL.TabIndex = 5;
            this.PayL.Text = "label5";
            this.PayL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(28, 112);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 7, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Pay:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 171);
            this.Controls.Add(this.PayL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ComL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SalesL);
            this.Controls.Add(this.label1);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SalesL;
        private System.Windows.Forms.Label ComL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PayL;
        private System.Windows.Forms.Label label6;
    }
}