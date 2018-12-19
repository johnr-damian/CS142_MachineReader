using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMachineSimulator.Views.RuleForm
{
    public partial class form_Rule : Form
    {
        private App_Code.Machine.MachineTuple machineTuple;

        public form_Rule(App_Code.Machine.MachineTuple tuple)
        {
            InitializeComponent();
            machineTuple = tuple;
            //try
            txtCurrentState.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtCurrentState.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCurrentState.AutoCompleteCustomSource.AddRange(machineTuple.States.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            machineTuple.Rules.Rule.Add(new App_Code.Machine.TransitionTableRule() { CurrentState = txtCurrentState.Text, OnRead = txtOnRead.Text, ThenWrite = txtThenWrite.Text, TapeDirection = cmbTapeDirection.Text, NextState = txtNextState.Text });
        }
    }
}
