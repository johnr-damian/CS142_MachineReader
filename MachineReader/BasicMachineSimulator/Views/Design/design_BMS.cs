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

        private void btnValidateDetails_Click(object sender, EventArgs e)
        {
            bool has_language = true, has_description = true, has_author = true;

            if (String.IsNullOrEmpty(txtLanguage.Text) || String.IsNullOrWhiteSpace(txtLanguage.Text))
                has_language = false;
            if (String.IsNullOrEmpty(txtDescription.Text) || String.IsNullOrWhiteSpace(txtDescription.Text))
                has_description = false;
            if (String.IsNullOrEmpty(txtAuthor.Text) || String.IsNullOrWhiteSpace(txtAuthor.Text))
                has_author = false;

            if ((has_language && has_description) && has_author)
            {
                grpTuple.Enabled = true;
                grpDetails.Enabled = false;
            }
        }

        private void btnDefineTuple_Click(object sender, EventArgs e)
        {

        }

        private void btnDefineRules_Click(object sender, EventArgs e)
        {

        }

        private void btnValidateTuple_Click(object sender, EventArgs e)
        {

        }
    }
}
