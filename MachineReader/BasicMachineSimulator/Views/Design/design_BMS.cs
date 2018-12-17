using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using BasicMachineSimulator.Views.Title;
using System.Windows.Forms;

namespace BasicMachineSimulator.Views.Design
{
    /// <summary>
    /// Form that allows the user to design their own machine
    /// </summary>
    public partial class design_BMS : BasicMachineSimulator.Templates.Forms.template_Base
    {
        /// <summary>
        /// Initializes the Design Form along with Menustrip and Statusstrip
        /// </summary>
        public design_BMS()
        {
            InitializeComponent();
            InitializeMenuStrip();
            InitializeStatusStrip();
        }

        #region subFile_ItemsMethod
        private void filesub_New_Click(object sender, EventArgs e)
        {

        }

        private void filesub_Open_Click(object sender, EventArgs e)
        {

        }

        private void filesub_Save_Click(object sender, EventArgs e)
        {

        }

        private void filesub_SaveAs_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region subEdit_ItemsMethod
        private void editsub_ClearAll_Click(object sender, EventArgs e)
        {

        }

        private void editsub_ClearStates_Click(object sender, EventArgs e)
        {

        }

        private void editsub_ClearTransitions_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
