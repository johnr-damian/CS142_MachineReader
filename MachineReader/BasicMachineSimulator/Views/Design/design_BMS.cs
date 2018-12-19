using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using BasicMachineSimulator.Views.Title;
using BasicMachineSimulator.App_Code.Components;
using System.Windows.Forms;

namespace BasicMachineSimulator.Views.Design
{
    /// <summary>
    /// Form that allows the user to design their own machine
    /// </summary>
    public partial class design_BMS : BasicMachineSimulator.Templates.Forms.template_Base
    {
        private App_Code.Machine.TuringMachine turingMachine;
        private Queue<template_Component> drawingQueue;

        /// <summary>
        /// Initializes the Design Form along with Menustrip and Statusstrip
        /// </summary>
        public design_BMS()
        {
            InitializeComponent();
            InitializeMenuStrip();
            InitializeStatusStrip();
            drawingQueue = new Queue<template_Component>();
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
                turingMachine = new App_Code.Machine.TuringMachine() { MachineLanguage = txtLanguage.Text, MachineDescription = txtDescription.Text, Author = txtAuthor.Text };
            }                
        }

        private void btnDefineTuple_Click(object sender, EventArgs e)
        {
            if (new TupleForm.form_Tuple(turingMachine.Tuple).ShowDialog() == DialogResult.OK)
                btnDefineRules.Enabled = true;
        }

        private void btnDefineRules_Click(object sender, EventArgs e)
        {
            if (new RuleForm.form_Rule(turingMachine.Tuple).ShowDialog() == DialogResult.OK)
                btnValidateTuple.Enabled = true;
        }

        private void btnValidateTuple_Click(object sender, EventArgs e)
        {
            var currentPoint = new Point(20, pnlCanvas.Height / 2);
            var nextPoint = currentPoint;
            var ruleQueue = turingMachine.Tuple.Rules.Rule.GetEnumerator();//assumes the rule are in order
            var currentState = "";

            //new algorithm: queue by rule
            //old algorithm: queue by parts
            while (ruleQueue.MoveNext())
            {
                if(currentState != ruleQueue.Current.CurrentState) //new state
                {
                    nextPoint = new Point(currentPoint.X + 30, currentPoint.Y + 30);
                    drawingQueue.Enqueue(new StateComponent(false) { ComponentName = ruleQueue.Current.CurrentState, P1 = currentPoint, P2 = nextPoint });
                    currentPoint = nextPoint;
                }
                //same state, we draw transition

            }

            pnlCanvas.Refresh();
        }

        private void pnlCanvas_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            foreach (var comp in drawingQueue)
                comp.DrawShape(graphics);
        }
    }
}
