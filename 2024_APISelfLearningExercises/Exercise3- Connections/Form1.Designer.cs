namespace Exercise
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
            this.CreatePadFootingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePadFootingButton
            // 
            this.CreatePadFootingButton.Location = new System.Drawing.Point(41, 27);
            this.CreatePadFootingButton.Name = "CreatePadFootingButton";
            this.CreatePadFootingButton.Size = new System.Drawing.Size(121, 23);
            this.CreatePadFootingButton.TabIndex = 0;
            this.CreatePadFootingButton.Text = "Footings and Columns";
            this.CreatePadFootingButton.UseVisualStyleBackColor = true;
            this.CreatePadFootingButton.Click += new System.EventHandler(this.CreatePadFootings);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 123);
            this.Controls.Add(this.CreatePadFootingButton);
            this.Name = "Form1";
            this.Text = "DotNetExample";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreatePadFootingButton;
    }
}

