using BasicMachineSimulator.Views.Title;
using System.Windows.Forms;

namespace BasicMachineSimulator.Templates.Forms
{
    /// <summary>
    /// Root Template for Main Forms
    /// </summary>
    public partial class template_Base : Form
    {
        /// <summary>
        /// Initalizes the Template Form
        /// </summary>
        public template_Base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Templated Dialogbox confirmation before closing the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void template_Base_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Any unsaved changes will be discarded. Continue?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
            else
                Owner.Show();
        }
    }
}
