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
            this.FootingSize = new System.Windows.Forms.TextBox();
            this.SizeLabel1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.profileCatalog1 = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.ColumnsProfileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reinforcementCatalog1 = new Tekla.Structures.Dialog.UIControls.ReinforcementCatalog();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.GradeTextBox = new System.Windows.Forms.TextBox();
            this.BendingRadiusTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatePadFootingButton
            // 
            this.structuresExtender.SetAttributeName(this.CreatePadFootingButton, null);
            this.structuresExtender.SetAttributeTypeName(this.CreatePadFootingButton, null);
            this.structuresExtender.SetBindPropertyName(this.CreatePadFootingButton, null);
            this.CreatePadFootingButton.Location = new System.Drawing.Point(353, 153);
            this.CreatePadFootingButton.Name = "CreatePadFootingButton";
            this.CreatePadFootingButton.Size = new System.Drawing.Size(126, 23);
            this.CreatePadFootingButton.TabIndex = 0;
            this.CreatePadFootingButton.Text = "Footings and Columns";
            this.CreatePadFootingButton.UseVisualStyleBackColor = true;
            this.CreatePadFootingButton.Click += new System.EventHandler(this.CreatePadFootings);
            // 
            // FootingSize
            // 
            this.structuresExtender.SetAttributeName(this.FootingSize, "FootingSize");
            this.structuresExtender.SetAttributeTypeName(this.FootingSize, "Double");
            this.structuresExtender.SetBindPropertyName(this.FootingSize, null);
            this.FootingSize.Location = new System.Drawing.Point(421, 127);
            this.FootingSize.Name = "FootingSize";
            this.FootingSize.Size = new System.Drawing.Size(58, 20);
            this.FootingSize.TabIndex = 1;
            this.FootingSize.TextChanged += new System.EventHandler(this.FootingSize_TextChanged);
            // 
            // SizeLabel1
            // 
            this.structuresExtender.SetAttributeName(this.SizeLabel1, null);
            this.structuresExtender.SetAttributeTypeName(this.SizeLabel1, null);
            this.SizeLabel1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.SizeLabel1, null);
            this.SizeLabel1.Location = new System.Drawing.Point(350, 130);
            this.SizeLabel1.Name = "SizeLabel1";
            this.SizeLabel1.Size = new System.Drawing.Size(65, 13);
            this.SizeLabel1.TabIndex = 2;
            this.SizeLabel1.Text = "Footing Size";
            // 
            // button2
            // 
            this.structuresExtender.SetAttributeName(this.button2, null);
            this.structuresExtender.SetAttributeTypeName(this.button2, null);
            this.structuresExtender.SetBindPropertyName(this.button2, null);
            this.button2.Location = new System.Drawing.Point(353, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Create rebars";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // profileCatalog1
            // 
            this.structuresExtender.SetAttributeName(this.profileCatalog1, null);
            this.structuresExtender.SetAttributeTypeName(this.profileCatalog1, null);
            this.profileCatalog1.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.profileCatalog1, null);
            this.profileCatalog1.Location = new System.Drawing.Point(203, 32);
            this.profileCatalog1.Name = "profileCatalog1";
            this.profileCatalog1.SelectedProfile = "";
            this.profileCatalog1.Size = new System.Drawing.Size(99, 20);
            this.profileCatalog1.TabIndex = 4;
            this.profileCatalog1.SelectClicked += new System.EventHandler(this.profileCatalog1_SelectClicked);
            this.profileCatalog1.SelectionDone += new System.EventHandler(this.profileCatalog1_SelectionDone);
            // 
            // ColumnsProfileTextBox
            // 
            this.structuresExtender.SetAttributeName(this.ColumnsProfileTextBox, "Profile");
            this.structuresExtender.SetAttributeTypeName(this.ColumnsProfileTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.ColumnsProfileTextBox, null);
            this.ColumnsProfileTextBox.Location = new System.Drawing.Point(97, 32);
            this.ColumnsProfileTextBox.Name = "ColumnsProfileTextBox";
            this.ColumnsProfileTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColumnsProfileTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.structuresExtender.SetAttributeName(this.label1, null);
            this.structuresExtender.SetAttributeTypeName(this.label1, null);
            this.label1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label1, null);
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Profile";
            // 
            // reinforcementCatalog1
            // 
            this.structuresExtender.SetAttributeName(this.reinforcementCatalog1, null);
            this.structuresExtender.SetAttributeTypeName(this.reinforcementCatalog1, null);
            this.reinforcementCatalog1.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.reinforcementCatalog1, null);
            this.reinforcementCatalog1.Location = new System.Drawing.Point(203, 48);
            this.reinforcementCatalog1.Name = "reinforcementCatalog1";
            this.reinforcementCatalog1.SelectedRebarBendingRadius = 0D;
            this.reinforcementCatalog1.SelectedRebarGrade = "";
            this.reinforcementCatalog1.SelectedRebarSize = "";
            this.reinforcementCatalog1.Size = new System.Drawing.Size(99, 20);
            this.reinforcementCatalog1.TabIndex = 7;
            this.reinforcementCatalog1.SelectClicked += new System.EventHandler(this.reinforcementCatalog1_SelectClicked);
            this.reinforcementCatalog1.SelectionDone += new System.EventHandler(this.reinforcementCatalog1_SelectionDone);
            // 
            // SizeTextBox
            // 
            this.structuresExtender.SetAttributeName(this.SizeTextBox, "Size");
            this.structuresExtender.SetAttributeTypeName(this.SizeTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.SizeTextBox, null);
            this.SizeTextBox.Location = new System.Drawing.Point(97, 22);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(100, 20);
            this.SizeTextBox.TabIndex = 8;
            // 
            // GradeTextBox
            // 
            this.structuresExtender.SetAttributeName(this.GradeTextBox, "Grade");
            this.structuresExtender.SetAttributeTypeName(this.GradeTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.GradeTextBox, null);
            this.GradeTextBox.Location = new System.Drawing.Point(97, 48);
            this.GradeTextBox.Name = "GradeTextBox";
            this.GradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.GradeTextBox.TabIndex = 9;
            // 
            // BendingRadiusTextBox
            // 
            this.structuresExtender.SetAttributeName(this.BendingRadiusTextBox, "BendingRadius");
            this.structuresExtender.SetAttributeTypeName(this.BendingRadiusTextBox, "Distance");
            this.structuresExtender.SetBindPropertyName(this.BendingRadiusTextBox, null);
            this.BendingRadiusTextBox.Location = new System.Drawing.Point(97, 74);
            this.BendingRadiusTextBox.Name = "BendingRadiusTextBox";
            this.BendingRadiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.BendingRadiusTextBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.structuresExtender.SetAttributeName(this.groupBox1, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox1, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox1, null);
            this.groupBox1.Controls.Add(this.ColumnsProfileTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.profileCatalog1);
            this.groupBox1.Location = new System.Drawing.Point(4, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 71);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Columns";
            // 
            // groupBox2
            // 
            this.structuresExtender.SetAttributeName(this.groupBox2, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox2, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox2, null);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BendingRadiusTextBox);
            this.groupBox2.Controls.Add(this.SizeTextBox);
            this.groupBox2.Controls.Add(this.GradeTextBox);
            this.groupBox2.Controls.Add(this.reinforcementCatalog1);
            this.groupBox2.Location = new System.Drawing.Point(4, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 110);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rebars";
            // 
            // label2
            // 
            this.structuresExtender.SetAttributeName(this.label2, null);
            this.structuresExtender.SetAttributeTypeName(this.label2, null);
            this.label2.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label2, null);
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Size";
            // 
            // label3
            // 
            this.structuresExtender.SetAttributeName(this.label3, null);
            this.structuresExtender.SetAttributeTypeName(this.label3, null);
            this.label3.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label3, null);
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Grade";
            // 
            // label4
            // 
            this.structuresExtender.SetAttributeName(this.label4, null);
            this.structuresExtender.SetAttributeTypeName(this.label4, null);
            this.label4.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label4, null);
            this.label4.Location = new System.Drawing.Point(9, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bending Radius";
            // 
            // Form1
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(491, 225);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SizeLabel1);
            this.Controls.Add(this.FootingSize);
            this.Controls.Add(this.CreatePadFootingButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "DotNetExample";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatePadFootingButton;
        private System.Windows.Forms.TextBox FootingSize;
        private System.Windows.Forms.Label SizeLabel1;
        private System.Windows.Forms.Button button2;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog profileCatalog1;
        private System.Windows.Forms.TextBox ColumnsProfileTextBox;
        private System.Windows.Forms.Label label1;
        private Tekla.Structures.Dialog.UIControls.ReinforcementCatalog reinforcementCatalog1;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.TextBox GradeTextBox;
        private System.Windows.Forms.TextBox BendingRadiusTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

