namespace ParallelExample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSync = new Button();
            btnAsync = new Button();
            btnParallel = new Button();
            txtResult = new TextBox();
            SuspendLayout();
            // 
            // btnSync
            // 
            btnSync.BackColor = SystemColors.MenuHighlight;
            btnSync.ForeColor = SystemColors.ControlLightLight;
            btnSync.Location = new Point(33, 334);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(151, 55);
            btnSync.TabIndex = 0;
            btnSync.Text = "Sync";
            btnSync.UseVisualStyleBackColor = false;
            btnSync.Click += BtnSyncClicked;
            // 
            // btnAsync
            // 
            btnAsync.BackColor = SystemColors.MenuHighlight;
            btnAsync.ForeColor = SystemColors.ControlLightLight;
            btnAsync.Location = new Point(213, 334);
            btnAsync.Name = "btnAsync";
            btnAsync.Size = new Size(151, 55);
            btnAsync.TabIndex = 0;
            btnAsync.Text = "Async";
            btnAsync.UseVisualStyleBackColor = false;
            btnAsync.Click += BtnAsyncClicked;
            // 
            // btnParallel
            // 
            btnParallel.BackColor = SystemColors.MenuHighlight;
            btnParallel.ForeColor = SystemColors.ControlLightLight;
            btnParallel.Location = new Point(389, 334);
            btnParallel.Name = "btnParallel";
            btnParallel.Size = new Size(151, 55);
            btnParallel.TabIndex = 0;
            btnParallel.Text = "Parallel";
            btnParallel.UseVisualStyleBackColor = false;
            btnParallel.Click += BtnParallellClicked;
            // 
            // txtResult
            // 
            txtResult.AllowDrop = true;
            txtResult.Location = new Point(12, 12);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(575, 316);
            txtResult.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 415);
            Controls.Add(txtResult);
            Controls.Add(btnParallel);
            Controls.Add(btnAsync);
            Controls.Add(btnSync);
            Name = "Form1";
            Text = "Parallel Example";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSync;
        private Button btnAsync;
        private Button btnParallel;
        private TextBox txtResult;
    }
}
