namespace BulkSMS
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txtBoxTO = new System.Windows.Forms.TextBox();
            this.txtBoxMESSAGE = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSEND = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxTO
            // 
            this.txtBoxTO.Location = new System.Drawing.Point(165, 45);
            this.txtBoxTO.Name = "txtBoxTO";
            this.txtBoxTO.Size = new System.Drawing.Size(373, 22);
            this.txtBoxTO.TabIndex = 0;
            // 
            // txtBoxMESSAGE
            // 
            this.txtBoxMESSAGE.Location = new System.Drawing.Point(165, 82);
            this.txtBoxMESSAGE.Multiline = true;
            this.txtBoxMESSAGE.Name = "txtBoxMESSAGE";
            this.txtBoxMESSAGE.Size = new System.Drawing.Size(373, 180);
            this.txtBoxMESSAGE.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSEND
            // 
            this.btnSEND.Location = new System.Drawing.Point(426, 268);
            this.btnSEND.Name = "btnSEND";
            this.btnSEND.Size = new System.Drawing.Size(112, 47);
            this.btnSEND.TabIndex = 3;
            this.btnSEND.Text = "SEND";
            this.btnSEND.UseVisualStyleBackColor = true;
            this.btnSEND.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "TO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "MESSAGE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSEND);
            this.Controls.Add(this.txtBoxMESSAGE);
            this.Controls.Add(this.txtBoxTO);
            this.Name = "Form1";
            this.Text = "Bulk SMS AmericoLIB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTO;
        private System.Windows.Forms.TextBox txtBoxMESSAGE;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnSEND;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

