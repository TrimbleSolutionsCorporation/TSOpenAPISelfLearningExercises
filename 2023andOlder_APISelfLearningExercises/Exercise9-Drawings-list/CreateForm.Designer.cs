namespace Exercise
{
    partial class CreateForm
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
            if(disposing && (components != null))
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createLabel
            // 
            this.structuresExtender.SetAttributeName(this.createLabel, null);
            this.structuresExtender.SetAttributeTypeName(this.createLabel, null);
            this.structuresExtender.SetBindPropertyName(this.createLabel, null);
            // 
            // allPartsRadioButton
            // 
            this.structuresExtender.SetAttributeName(this.allPartsRadioButton, null);
            this.structuresExtender.SetAttributeTypeName(this.allPartsRadioButton, null);
            this.structuresExtender.SetBindPropertyName(this.allPartsRadioButton, null);
            // 
            // selectedPartsRadioButton
            // 
            this.structuresExtender.SetAttributeName(this.selectedPartsRadioButton, null);
            this.structuresExtender.SetAttributeTypeName(this.selectedPartsRadioButton, null);
            this.structuresExtender.SetBindPropertyName(this.selectedPartsRadioButton, null);
            // 
            // settingsLabel
            // 
            this.structuresExtender.SetAttributeName(this.settingsLabel, null);
            this.structuresExtender.SetAttributeTypeName(this.settingsLabel, null);
            this.structuresExtender.SetBindPropertyName(this.settingsLabel, null);
            // 
            // suboptionsButton
            // 
            this.structuresExtender.SetAttributeName(this.suboptionsButton, null);
            this.structuresExtender.SetAttributeTypeName(this.suboptionsButton, null);
            this.structuresExtender.SetBindPropertyName(this.suboptionsButton, null);
            // 
            // instructionsLabel
            // 
            this.structuresExtender.SetAttributeName(this.instructionsLabel, null);
            this.structuresExtender.SetAttributeTypeName(this.instructionsLabel, null);
            this.structuresExtender.SetBindPropertyName(this.instructionsLabel, null);
            // 
            // cancelButton
            // 
            this.structuresExtender.SetAttributeName(this.cancelButton, null);
            this.structuresExtender.SetAttributeTypeName(this.cancelButton, null);
            this.structuresExtender.SetBindPropertyName(this.cancelButton, null);
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // createButton
            // 
            this.structuresExtender.SetAttributeName(this.createButton, null);
            this.structuresExtender.SetAttributeTypeName(this.createButton, null);
            this.structuresExtender.SetBindPropertyName(this.createButton, null);
            // 
            // button1
            // 
            this.structuresExtender.SetAttributeName(this.button1, null);
            this.structuresExtender.SetAttributeTypeName(this.button1, null);
            this.structuresExtender.SetBindPropertyName(this.button1, null);
            this.button1.Location = new System.Drawing.Point(128, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CreateForm
            // 
            this.structuresExtender.SetAttributeName(this, null);
            this.structuresExtender.SetAttributeTypeName(this, null);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.structuresExtender.SetBindPropertyName(this, null);
            this.ClientSize = new System.Drawing.Size(391, 321);
            this.Controls.Add(this.button1);
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.createButton, 0);
            this.Controls.SetChildIndex(this.cancelButton, 0);
            this.Controls.SetChildIndex(this.createLabel, 0);
            this.Controls.SetChildIndex(this.allPartsRadioButton, 0);
            this.Controls.SetChildIndex(this.selectedPartsRadioButton, 0);
            this.Controls.SetChildIndex(this.settingsLabel, 0);
            this.Controls.SetChildIndex(this.suboptionsButton, 0);
            this.Controls.SetChildIndex(this.instructionsLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}