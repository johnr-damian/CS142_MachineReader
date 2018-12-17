using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMachineSimulator.Views.Title
{
    /// <summary>
    /// Title Page
    /// </summary>
    public partial class title_BMS : Form
    {
        public title_BMS()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Hides the current form and shows the simulate form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Simulate_Click(object sender, EventArgs e)
        {
            var simulate_mode = new Simulate.simulate_BMS() { Owner = this };
            simulate_mode.Show();
            Hide();
        }

        /// <summary>
        /// Hides the current form and shows the design form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Design_Click(object sender, EventArgs e)
        {
            var design_mode = new Design.design_BMS() { Owner = this };
            design_mode.Show();
            Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
