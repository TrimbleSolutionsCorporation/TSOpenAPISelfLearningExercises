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
            this.ColumnsProfileTextBox = new System.Windows.Forms.TextBox();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.GradeTextBox = new System.Windows.Forms.TextBox();
            this.BendingRadiusTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reinforcementCatalog1 = new Tekla.Structures.Dialog.UIControls.ReinforcementCatalog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnsMaterialTextBox = new System.Windows.Forms.TextBox();
            this.MaterialButton = new System.Windows.Forms.Button();
            this.profileCatalog1 = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.label5 = new System.Windows.Forms.Label();
            this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.CreateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ViewTitle = new System.Windows.Forms.TextBox();
            this.EditDrawingButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.OpenDrawingButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatePadFootingButton
            // 
            this.structuresExtender.SetAttributeName(this.CreatePadFootingButton, null);
            this.structuresExtender.SetAttributeTypeName(this.CreatePadFootingButton, null);
            this.structuresExtender.SetBindPropertyName(this.CreatePadFootingButton, null);
            this.CreatePadFootingButton.Location = new System.Drawing.Point(389, 172);
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
            this.FootingSize.Location = new System.Drawing.Point(457, 146);
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
            this.SizeLabel1.Location = new System.Drawing.Point(386, 149);
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
            this.button2.Location = new System.Drawing.Point(389, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Create rebars";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ColumnsProfileTextBox
            // 
            this.structuresExtender.SetAttributeName(this.ColumnsProfileTextBox, "Profile");
            this.structuresExtender.SetAttributeTypeName(this.ColumnsProfileTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.ColumnsProfileTextBox, null);
            this.ColumnsProfileTextBox.Location = new System.Drawing.Point(99, 20);
            this.ColumnsProfileTextBox.Name = "ColumnsProfileTextBox";
            this.ColumnsProfileTextBox.Size = new System.Drawing.Size(131, 20);
            this.ColumnsProfileTextBox.TabIndex = 4;
            this.ColumnsProfileTextBox.Text = "HEA400";
            // 
            // SizeTextBox
            // 
            this.structuresExtender.SetAttributeName(this.SizeTextBox, "Size");
            this.structuresExtender.SetAttributeTypeName(this.SizeTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.SizeTextBox, null);
            this.SizeTextBox.Location = new System.Drawing.Point(99, 23);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(131, 20);
            this.SizeTextBox.TabIndex = 6;
            this.SizeTextBox.Text = "12";
            // 
            // GradeTextBox
            // 
            this.structuresExtender.SetAttributeName(this.GradeTextBox, "Grade");
            this.structuresExtender.SetAttributeTypeName(this.GradeTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.GradeTextBox, null);
            this.GradeTextBox.Location = new System.Drawing.Point(99, 49);
            this.GradeTextBox.Name = "GradeTextBox";
            this.GradeTextBox.Size = new System.Drawing.Size(131, 20);
            this.GradeTextBox.TabIndex = 7;
            this.GradeTextBox.Text = "A500HW";
            // 
            // BendingRadiusTextBox
            // 
            this.structuresExtender.SetAttributeName(this.BendingRadiusTextBox, "BendingRadius");
            this.structuresExtender.SetAttributeTypeName(this.BendingRadiusTextBox, "Distance");
            this.structuresExtender.SetBindPropertyName(this.BendingRadiusTextBox, null);
            this.BendingRadiusTextBox.Location = new System.Drawing.Point(99, 75);
            this.BendingRadiusTextBox.Name = "BendingRadiusTextBox";
            this.BendingRadiusTextBox.Size = new System.Drawing.Size(131, 20);
            this.BendingRadiusTextBox.TabIndex = 8;
            this.BendingRadiusTextBox.Text = "40";
            // 
            // label2
            // 
            this.structuresExtender.SetAttributeName(this.label2, null);
            this.structuresExtender.SetAttributeTypeName(this.label2, null);
            this.label2.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label2, null);
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Size:";
            // 
            // label3
            // 
            this.structuresExtender.SetAttributeName(this.label3, null);
            this.structuresExtender.SetAttributeTypeName(this.label3, null);
            this.label3.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label3, null);
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grade:";
            // 
            // label4
            // 
            this.structuresExtender.SetAttributeName(this.label4, null);
            this.structuresExtender.SetAttributeTypeName(this.label4, null);
            this.label4.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label4, null);
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bending radius:";
            // 
            // groupBox1
            // 
            this.structuresExtender.SetAttributeName(this.groupBox1, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox1, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox1, null);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.reinforcementCatalog1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BendingRadiusTextBox);
            this.groupBox1.Controls.Add(this.GradeTextBox);
            this.groupBox1.Controls.Add(this.SizeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 110);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rebars";
            // 
            // groupBox3
            // 
            this.structuresExtender.SetAttributeName(this.groupBox3, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox3, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox3, null);
            this.groupBox3.Location = new System.Drawing.Point(238, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(2, 77);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // reinforcementCatalog1
            // 
            this.structuresExtender.SetAttributeName(this.reinforcementCatalog1, null);
            this.structuresExtender.SetAttributeTypeName(this.reinforcementCatalog1, null);
            this.reinforcementCatalog1.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.reinforcementCatalog1, null);
            this.reinforcementCatalog1.Location = new System.Drawing.Point(247, 48);
            this.reinforcementCatalog1.Name = "reinforcementCatalog1";
            this.reinforcementCatalog1.SelectedRebarBendingRadius = 0D;
            this.reinforcementCatalog1.SelectedRebarGrade = "";
            this.reinforcementCatalog1.SelectedRebarSize = "";
            this.reinforcementCatalog1.Size = new System.Drawing.Size(88, 23);
            this.reinforcementCatalog1.TabIndex = 12;
            this.reinforcementCatalog1.SelectClicked += new System.EventHandler(this.reinforcementCatalog1_SelectClicked);
            this.reinforcementCatalog1.SelectionDone += new System.EventHandler(this.reinforcementCatalog1_SelectionDone);
            // 
            // groupBox2
            // 
            this.structuresExtender.SetAttributeName(this.groupBox2, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox2, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox2, null);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ColumnsMaterialTextBox);
            this.groupBox2.Controls.Add(this.MaterialButton);
            this.groupBox2.Controls.Add(this.profileCatalog1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ColumnsProfileTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 81);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columns";
            // 
            // label1
            // 
            this.structuresExtender.SetAttributeName(this.label1, null);
            this.structuresExtender.SetAttributeTypeName(this.label1, null);
            this.label1.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label1, null);
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Material:";
            // 
            // ColumnsMaterialTextBox
            // 
            this.structuresExtender.SetAttributeName(this.ColumnsMaterialTextBox, "Material");
            this.structuresExtender.SetAttributeTypeName(this.ColumnsMaterialTextBox, "String");
            this.structuresExtender.SetBindPropertyName(this.ColumnsMaterialTextBox, null);
            this.ColumnsMaterialTextBox.Location = new System.Drawing.Point(99, 46);
            this.ColumnsMaterialTextBox.Name = "ColumnsMaterialTextBox";
            this.ColumnsMaterialTextBox.Size = new System.Drawing.Size(131, 20);
            this.ColumnsMaterialTextBox.TabIndex = 8;
            this.ColumnsMaterialTextBox.Text = "S235JR";
            // 
            // MaterialButton
            // 
            this.structuresExtender.SetAttributeName(this.MaterialButton, null);
            this.structuresExtender.SetAttributeTypeName(this.MaterialButton, null);
            this.structuresExtender.SetBindPropertyName(this.MaterialButton, null);
            this.MaterialButton.Location = new System.Drawing.Point(247, 45);
            this.MaterialButton.Name = "MaterialButton";
            this.MaterialButton.Size = new System.Drawing.Size(88, 23);
            this.MaterialButton.TabIndex = 7;
            this.MaterialButton.Text = "Select...";
            this.MaterialButton.UseVisualStyleBackColor = true;
            this.MaterialButton.Click += new System.EventHandler(this.SelectMaterialButton_Click);
            // 
            // profileCatalog1
            // 
            this.structuresExtender.SetAttributeName(this.profileCatalog1, null);
            this.structuresExtender.SetAttributeTypeName(this.profileCatalog1, null);
            this.profileCatalog1.BackColor = System.Drawing.Color.Transparent;
            this.structuresExtender.SetBindPropertyName(this.profileCatalog1, null);
            this.profileCatalog1.Location = new System.Drawing.Point(247, 19);
            this.profileCatalog1.Name = "profileCatalog1";
            this.profileCatalog1.SelectedProfile = "";
            this.profileCatalog1.Size = new System.Drawing.Size(88, 23);
            this.profileCatalog1.TabIndex = 6;
            this.profileCatalog1.SelectClicked += new System.EventHandler(this.profileCatalog1_SelectClicked);
            this.profileCatalog1.SelectionDone += new System.EventHandler(this.profileCatalog1_SelectionDone);
            // 
            // label5
            // 
            this.structuresExtender.SetAttributeName(this.label5, null);
            this.structuresExtender.SetAttributeTypeName(this.label5, null);
            this.label5.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label5, null);
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Profile:";
            // 
            // saveLoad1
            // 
            this.structuresExtender.SetAttributeName(this.saveLoad1, null);
            this.structuresExtender.SetAttributeTypeName(this.saveLoad1, null);
            this.saveLoad1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.structuresExtender.SetBindPropertyName(this.saveLoad1, null);
            this.saveLoad1.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad1.Location = new System.Drawing.Point(0, 0);
            this.saveLoad1.Name = "saveLoad1";
            this.saveLoad1.SaveAsText = "";
            this.saveLoad1.Size = new System.Drawing.Size(534, 43);
            this.saveLoad1.TabIndex = 14;
            // 
            // CreateButton
            // 
            this.structuresExtender.SetAttributeName(this.CreateButton, null);
            this.structuresExtender.SetAttributeTypeName(this.CreateButton, null);
            this.structuresExtender.SetBindPropertyName(this.CreateButton, null);
            this.CreateButton.Location = new System.Drawing.Point(389, 231);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(126, 23);
            this.CreateButton.TabIndex = 16;
            this.CreateButton.Text = "Create...";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // label6
            // 
            this.structuresExtender.SetAttributeName(this.label6, null);
            this.structuresExtender.SetAttributeTypeName(this.label6, null);
            this.label6.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label6, null);
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "View title:";
            // 
            // ViewTitle
            // 
            this.structuresExtender.SetAttributeName(this.ViewTitle, null);
            this.structuresExtender.SetAttributeTypeName(this.ViewTitle, null);
            this.structuresExtender.SetBindPropertyName(this.ViewTitle, null);
            this.ViewTitle.Location = new System.Drawing.Point(99, 19);
            this.ViewTitle.Name = "ViewTitle";
            this.ViewTitle.Size = new System.Drawing.Size(131, 20);
            this.ViewTitle.TabIndex = 17;
            // 
            // EditDrawingButton
            // 
            this.structuresExtender.SetAttributeName(this.EditDrawingButton, null);
            this.structuresExtender.SetAttributeTypeName(this.EditDrawingButton, null);
            this.structuresExtender.SetBindPropertyName(this.EditDrawingButton, null);
            this.EditDrawingButton.Location = new System.Drawing.Point(247, 19);
            this.EditDrawingButton.Name = "EditDrawingButton";
            this.EditDrawingButton.Size = new System.Drawing.Size(88, 23);
            this.EditDrawingButton.TabIndex = 16;
            this.EditDrawingButton.Text = "Edit drawing";
            this.EditDrawingButton.UseVisualStyleBackColor = true;
            this.EditDrawingButton.Click += new System.EventHandler(this.EditDrawingButton_Click);
            // 
            // groupBox4
            // 
            this.structuresExtender.SetAttributeName(this.groupBox4, null);
            this.structuresExtender.SetAttributeTypeName(this.groupBox4, null);
            this.structuresExtender.SetBindPropertyName(this.groupBox4, null);
            this.groupBox4.Controls.Add(this.OpenDrawingButton);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.ViewTitle);
            this.groupBox4.Controls.Add(this.EditDrawingButton);
            this.groupBox4.Location = new System.Drawing.Point(13, 262);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(349, 120);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Drawings";
            // 
            // OpenDrawingButton
            // 
            this.structuresExtender.SetAttributeName(this.OpenDrawingButton, null);
            this.structuresExtender.SetAttributeTypeName(this.OpenDrawingButton, null);
            this.structuresExtender.SetBindPropertyName(this.OpenDrawingButton, null);
            this.OpenDrawingButton.Location = new System.Drawing.Point(246, 91);
            this.OpenDrawingButton.Name = "OpenDrawingButton";
            this.OpenDrawingButton.Size = new System.Drawing.Size(88, 23);
            this.OpenDrawingButton.TabIndex = 25;
            this.OpenDrawingButton.Text = "Open drawing";
            this.OpenDrawingButton.UseVisualStyleBackColor = true;
            this.OpenDrawingButton.Click += new System.EventHandler(this.OpenDrawingButton_Click);
            // 
            // label7
            // 
            this.structuresExtender.SetAttributeName(this.label7, null);
            this.structuresExtender.SetAttributeTypeName(this.label7, null);
            this.label7.AutoSize = true;
            this.structuresExtender.SetBindPropertyName(this.label7, null);
            this.label7.Location = new System.Drawing.Point(6, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Drawing list:";
            // 
            // listView1
            // 
            this.structuresExtender.SetAttributeName(this.listView1, null);
            this.structuresExtender.SetAttributeTypeName(this.listView1, null);
            this.structuresExtender.SetBindPropertyName(this.listView1, null);
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(98, 45);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(131, 69);
            this.listView1.TabIndex = 23;
            this.listView1.TileSize = new System.Drawing.Size(5, 5);
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(534, 389);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.saveLoad1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SizeLabel1);
            this.Controls.Add(this.FootingSize);
            this.Controls.Add(this.CreatePadFootingButton);
            this.Name = "Form1";
            this.Text = "DotNetExample";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatePadFootingButton;
        private System.Windows.Forms.TextBox FootingSize;
        private System.Windows.Forms.Label SizeLabel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ColumnsProfileTextBox;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.TextBox GradeTextBox;
        private System.Windows.Forms.TextBox BendingRadiusTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private Tekla.Structures.Dialog.UIControls.ReinforcementCatalog reinforcementCatalog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button MaterialButton;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog profileCatalog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ColumnsMaterialTextBox;
        private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ViewTitle;
        private System.Windows.Forms.Button EditDrawingButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button OpenDrawingButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
    }
}

