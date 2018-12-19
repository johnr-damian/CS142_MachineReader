using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMachineSimulator.Views.TupleForm
{
    public partial class form_Tuple : Form
    {
        private App_Code.Machine.MachineTuple machineTuple;

        public form_Tuple(App_Code.Machine.MachineTuple tuple)
        {
            InitializeComponent();
            machineTuple = tuple;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var states = txtStates.Text.Split(',');
            var alphabets = txtAlphabets.Text.Split(',');
            var acceptStates = txtAcceptStates.Text.Split(',');

            foreach (var state in states)
                machineTuple.States.Add(state);
            foreach (var alphabet in alphabets)
                machineTuple.Alphabets.Add(alphabet);
            foreach (var acceptstate in acceptStates)
                machineTuple.AcceptState.Add(acceptstate);
            machineTuple.StartState = txtStartState.Text;
        }
    }
}
