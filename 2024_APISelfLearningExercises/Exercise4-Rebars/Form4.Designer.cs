namespace Exercise
{
    partial class Form4
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
            this.FootingSize = new System.Windows.Forms.TextBox();
            this.SizeLabel1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreatePadFootingButton
            // 
            this.CreatePadFootingButton.Location = new System.Drawing.Point(28, 56);
            this.CreatePadFootingButton.Name = "CreatePadFootingButton";
            this.CreatePadFootingButton.Size = new System.Drawing.Size(126, 23);
            this.CreatePadFootingButton.TabIndex = 0;
            this.CreatePadFootingButton.Text = "Footings and Columns";
            this.CreatePadFootingButton.UseVisualStyleBackColor = true;
            this.CreatePadFootingButton.Click += new System.EventHandler(this.CreatePadFootings);
            // 
            // FootingSize
            // 
            this.FootingSize.Location = new System.Drawing.Point(96, 30);
            this.FootingSize.Name = "FootingSize";
            this.FootingSize.Size = new System.Drawing.Size(58, 20);
            this.FootingSize.TabIndex = 1;
            this.FootingSize.Text = "1500";
            this.FootingSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FootingSize.TextChanged += new System.EventHandler(this.FootingSize_TextChanged);
            // 
            // SizeLabel1
            // 
            this.SizeLabel1.AutoSize = true;
            this.SizeLabel1.Location = new System.Drawing.Point(25, 33);
            this.SizeLabel1.Name = "SizeLabel1";
            this.SizeLabel1.Size = new System.Drawing.Size(65, 13);
            this.SizeLabel1.TabIndex = 2;
            this.SizeLabel1.Text = "Footing Size";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Create rebars";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SizeLabel1);
            this.Controls.Add(this.FootingSize);
            this.Controls.Add(this.CreatePadFootingButton);
            this.Name = "Form4";
            this.Text = "API Exercise 4";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatePadFootingButton;
        private System.Windows.Forms.TextBox FootingSize;
        private System.Windows.Forms.Label SizeLabel1;
        private System.Windows.Forms.Button button2;
    }
}

