using System;

namespace Exercise
{
    public partial class CreateForm : Tekla.Structures.Dialog.UIControls.CreateDialog
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}