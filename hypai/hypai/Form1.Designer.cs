namespace hypai
{
    partial class frmhyp
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
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnInitialiseConversion = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnConcatinate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtConsole.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtConsole.Location = new System.Drawing.Point(12, 21);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(881, 214);
            this.txtConsole.TabIndex = 0;
            // 
            // btnInitialiseConversion
            // 
            this.btnInitialiseConversion.Location = new System.Drawing.Point(12, 241);
            this.btnInitialiseConversion.Name = "btnInitialiseConversion";
            this.btnInitialiseConversion.Size = new System.Drawing.Size(161, 46);
            this.btnInitialiseConversion.TabIndex = 1;
            this.btnInitialiseConversion.Text = "Initialize Conversion";
            this.btnInitialiseConversion.UseVisualStyleBackColor = true;
            this.btnInitialiseConversion.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // btnConcatinate
            // 
            this.btnConcatinate.Location = new System.Drawing.Point(205, 241);
            this.btnConcatinate.Name = "btnConcatinate";
            this.btnConcatinate.Size = new System.Drawing.Size(162, 46);
            this.btnConcatinate.TabIndex = 2;
            this.btnConcatinate.Text = "Concatinate Wav Files";
            this.btnConcatinate.UseVisualStyleBackColor = true;
            this.btnConcatinate.Click += new System.EventHandler(this.btnConcatinate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(409, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmhyp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConcatinate);
            this.Controls.Add(this.btnInitialiseConversion);
            this.Controls.Add(this.txtConsole);
            this.Name = "frmhyp";
            this.Text = "but";
            this.Load += new System.EventHandler(this.frmhyp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnInitialiseConversion;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnConcatinate;
        private System.Windows.Forms.Button button1;
    }
}

