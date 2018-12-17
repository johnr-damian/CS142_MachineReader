using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace MachineReader
{
    public partial class frmMain : Form
    {
        private SystemHandler mainSystem;

        private List<CommonStateComponent> commonStates = new List<CommonStateComponent>();

        private List<TransitionComponent> arrowRights = new List<TransitionComponent>();
        private List<LoopComponent> arrowLoops = new List<LoopComponent>();
        private List<LongTransitionComponent> longArrowRights = new List<LongTransitionComponent>();

        private List<TapeComponent> commonTape = new List<TapeComponent>();
        private HeadComponent header = new HeadComponent("-", new Point(0,0), new Point(0,0), Color.Transparent);

        Graphics graphics;

        public frmMain()
        {
            InitializeComponent();
            lbl_result.Text = "";
            mainSystem = SystemHandler.InitializeSystem();

            //DEBUG
            //mainSystem.ExportMachine(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "machineC.xml"));
            //mainSystem.ExportString(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "inputA.xml"));
        }

        #region Input Handling
        private void ImportMachine(object sender, EventArgs e)
        {
            //Indicate there is a progress
            tsStatus.Text = "Importing a file...";
            tspbMain.Value = 10;

            //Open the File Dialog
            if(ofdMain.ShowDialog() == DialogResult.OK)
            {
                //Put the filename in the textbox and disable it
                txtInputMachine.Text = ofdMain.FileName;
                txtInputMachine.Enabled = false;

                //Update the progress
                tsStatus.Text = "Reading the Machine...";
                tspbMain.Value = 20;

                //Save the machine to the system
                if(mainSystem.ImportMachineFile(ofdMain.FileName) == true)
                {
                    //Start the timer of progress bar
                    tsStatus.Text = "Deserializing the machine...";
                    tm_Progress.Start();

                    //Enable the disabled functions
                    txtInputString.Enabled = true; //Allow to input manually a string
                    stsmChangeMachine.Enabled = true; //Allow to change machine
                    stsmExportMachine.Enabled = true;

                    //Disable the enabled functions
                    btnImportMachine.Enabled = stsmImportMachine.Enabled = false;

                    //Create the machine
                    ConstructMachine();
                }
                else
                {
                    tsStatus.Text = "Failed in Deserializing the Machine...";
                    tspbMain.Value = 0;
                }
            }
            else
            {
                tsStatus.Text = "Program Ready...";
                tspbMain.Value = 0;
            }
        }

        private void EnterInput(object sender, EventArgs e)
        {
            //Check if input have break
            if (!txtInputString.Text.EndsWith("~"))
                txtInputString.Text += "~";

            //Angelo
            int remaingSlot = 20 - txtInputString.Text.ToString().Length;
            for (int i = 0; remaingSlot > i; i++)
            {
                txtInputString.Text += " ";
            }



            //Start the timer to construct the tape
            tm_Progress.Start();

            //Disable the enabled functions
            txtInputString.Enabled = false;
            btnEnterString.Enabled = false;

            //Enable the disabled functions
            stsmChangeString.Enabled = btnChangeString.Enabled = true;
            btnReadMachine.Enabled = true;

            //Create the tape
            ConstructTape();
        }

        private void ValidateInput(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(txtInputString.Text) || String.IsNullOrWhiteSpace(txtInputString.Text)))
                btnEnterString.Enabled = true;
            else
                btnEnterString.Enabled = false;
        }
        #endregion

        #region Output Handling
        private void ExportMachine(object sender, EventArgs e)
        {
            //Indicate there is a progress
            tsStatus.Text = "Exporting a file...";
            tspbMain.Value = 10;

            sfdMain.FileName = mainSystem.MainMachine.MachineName;

            //Open the Save File Dialog
            if(sfdMain.ShowDialog() == DialogResult.OK)
            {
                //Indicate the current progress
                tsStatus.Text = "Preparing the file...";
                tspbMain.Value = 20;

                if(mainSystem.ExportMachineFile(sfdMain.FileName) == true)
                {
                    tsStatus.Text = "Saving the file...";
                    tm_Progress.Start();
                }
                else
                {
                    tsStatus.Text = "An error occured in saving the file...";
                    tspbMain.Value = 0;
                }
            }
            else
            {
                tsStatus.Text = "Program Ready";
                tspbMain.Value = 0;
            }
        }
        #endregion

        #region Manipulation
        private void ChangeMachine(object sender, EventArgs e)
        {
            //Call ChangeString() to revert back to stringless
            ChangeString(sender, e);

            //Clear other data
            txtInputMachine.Text = null;
            commonStates.Clear();
            arrowRights.Clear();
            arrowLoops.Clear();
            longArrowRights.Clear();

            //Disable the enabled functions
            txtInputString.Enabled = false;
            stsmChangeMachine.Enabled = false;
            stsmExportMachine.Enabled = false;

            //Enable the disabled functions
            stsmImportMachine.Enabled = btnImportMachine.Enabled = true;
            txtInputMachine.Enabled = true;

            //Update the simulator
            spcSimulate.Panel1.Refresh();
        }

        private void ChangeString(object sender, EventArgs e)
        {
            //Disable the enabled functions
            stsmChangeString.Enabled = btnChangeString.Enabled = false;
            btnReadMachine.Enabled = false;

            //Enable the disabled functions
            txtInputString.Enabled = true;

            //Remove previous data
            header = new HeadComponent("-", new Point(0, 0), new Point(0, 0), Color.Transparent);
            txtInputString.Text = null;
            commonTape.Clear();

            //Update the simulator
            spcSimulate.Panel2.Refresh();
        }
        #endregion

        #region View, Time & Exit
        private void ViewMachine(object sender, EventArgs e)
        {
            MessageBox.Show(SystemHandler.GetRawData(txtInputMachine.Text), "Raw Machine", MessageBoxButtons.OK);
        }

        private void UpdateProgress(object sender, EventArgs e)
        {
            if (tspbMain.Value == 100)
            {
                tsStatus.Text = "Success";
                tspbMain.Value = 0;
                tm_Progress.Stop();
            }
            else
                tspbMain.Value += 10;
        }

        private void ExitApplication(object s, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    SystemHandler.PrintLog();
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        #endregion

        #region Construction of Parts
        private void ConstructMachine()
        {
            #region Read Details
            lblNoStates.Text = Convert.ToString(mainSystem.MainMachine.MachineTuple.States.Length);
            lblAcceptState.Text = String.Join(",", (mainSystem.MainMachine.MachineTuple.AcceptState ?? new string[] { "-" }));
            lblHaltState.Text = String.Join(",", (mainSystem.MainMachine.MachineTuple.HaltState ?? new string[] { "-" }));
            lblRejectState.Text = String.Join(",", (mainSystem.MainMachine.MachineTuple.RejectState ?? new string[] { "-" }));
            #endregion

            #region Define Parts
            //Initialize the starting point
            Point P = new Point(20, 70);

            //Create the node
            foreach(string s in mainSystem.MainMachine.MachineTuple.States)
            {
                commonStates.Add(new CommonStateComponent(s, P, new Point(P.X + 30, P.Y + 30), Color.Black));
                P.X += 70;
            }

            //Placeholder for the first parent
            Point parent1 = new Point();
            //Create the transition by reading the rules
            foreach (MachineRule rule in mainSystem.MainMachine.MachineTuple.Rules)
            {
                //If the current rule is not a loop
                if (rule.StateName != rule.StateNextState)
                {
                    foreach (CommonStateComponent c in commonStates)
                    {
                        //Get the first parent
                        if (rule.StateName == c.BaseName)
                        {
                            parent1 = c.P2;
                            foreach(CommonStateComponent subc in commonStates)
                            {
                                //Get the second parent
                                if (rule.StateNextState == subc.BaseName)
                                {
                                    //If the next state is 1 step away
                                    if ((subc.P1.X - parent1.X) == 40)
                                    {
                                        arrowRights.Add(new TransitionComponent(String.Format("{0}, {1}, {2}", rule.StateRead, rule.StateWrite, rule.StateDirection), parent1, subc.P1, Color.Black));
                                    }
                                    else
                                    {
                                        longArrowRights.Add(new LongTransitionComponent(String.Format("{0}, {1}, {2}", rule.StateRead, rule.StateWrite, rule.StateDirection), parent1, subc.P1, Color.Black, 180f, 180f));
                                    }
                                }
                            }
                        }
                    }
                }
                //If the current rule is a loop
                else
                {
                    foreach (CommonStateComponent c in commonStates)
                    {
                        if (rule.StateName == c.BaseName)
                        {
                            arrowLoops.Add(new LoopComponent(String.Format("{0}, {1}, {2}", rule.StateRead, rule.StateWrite, rule.StateDirection), c.P1, c.P2, Color.Violet)); 
                        }
                    }
                    
                }
            }

            //Draw the parts
            spcSimulate.Panel1.Refresh();
            #endregion
        }

        private void ConstructTape()
        {
            //Initialize the starting point
            Point P = new Point(20, 30);

            //Create the read/write head
            header = new HeadComponent("R/W", new Point(P.X + 5, P.Y + 40), new Point(P.X + 10, P.Y + 70), Color.Red);

            //Create the memory field
            foreach (char c in txtInputString.Text)
            {
                commonTape.Add(new TapeComponent(c.ToString(), P, new Point(P.X + 20, P.Y + 30), Color.Black));
                P.X += 20;
            }

            //Draw the parts
            spcSimulate.Panel2.Refresh();
        }
        #endregion

        #region Drawing
        private void Machine_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            foreach (LoopComponent l in arrowLoops)
            {
                l.DrawShape(graphics);
            }
            foreach (LongTransitionComponent l in longArrowRights)
            {
                l.DrawShape(graphics);
            }
            foreach (TransitionComponent a in arrowRights)
            {
                a.DrawShape(graphics);
            }
            foreach (CommonStateComponent c in commonStates)
            {
                c.DrawShape(graphics);
                Thread.Sleep(10);
            }
        }

        private void Tape_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            foreach(TapeComponent c in commonTape)
            {
                c.DrawShape(graphics);
                Thread.Sleep(10);
            }
            header.DrawShape(graphics);
        }
        #endregion

        private void btnReadMachine_Click(object sender, EventArgs e)
        {
            //Initialize the current_state, current_tape, current_rule
            int current_state = 0, current_tape = 0, current_rule = 0;
            txtLogConsole.Text += Environment.NewLine + "Reading the Machine...";

            //Indicate the current state
            commonStates[current_state].BaseColor = Color.Red;
            commonTape[current_tape].BaseColor = Color.Red;
            //int head = commonTape.Count-;
            //commonTape[head].P1.X = commonTape[current_tape].P1.X + 5;

            txtResultConsole.Text += Environment.NewLine + String.Format("In State: {0};; In Character: {1}", commonStates[current_state].BaseName, commonTape[current_tape].BaseName);
            txtResultConsole.Text += Environment.NewLine + String.Format("\tUsing Rule: {0}", current_rule);
            txtLogConsole.Text += Environment.NewLine + String.Format("Machine has accepted the first character of input");

            //Read the rule while the current state is not an accepting state
            //THIS ASSUMES THAT THE ACCEPTING STATE IS NOT A COMMON STATE

            int count = mainSystem.MainMachine.MachineTuple.Rules.Count;
            bool reject = false;

            while (!(mainSystem.MainMachine.MachineTuple.AcceptState.Contains(commonStates[current_state].BaseName)) && current_rule != -1)
            {
                spcSimulate.Panel1.Refresh();
                spcSimulate.Panel2.Refresh();
                //Check the current state if it's the same state accepting the rule
                //If it's the same state to the rule being applied
                if (commonStates[current_state].BaseName == mainSystem.MainMachine.MachineTuple.Rules[current_rule].StateName)
                {
                    //Read the current character from the tape and check it in the current rule
                    //If it read the same character
                    if (commonTape[current_tape].BaseName == mainSystem.MainMachine.MachineTuple.Rules[current_rule].StateRead)
                    {
                        
                        //Write to the tape
                        commonTape[current_tape].BaseName = mainSystem.MainMachine.MachineTuple.Rules[current_rule].StateWrite;
                        commonTape[current_tape].BaseColor = Color.Black;

                        //Check the next head direction
                        switch (mainSystem.MainMachine.MachineTuple.Rules[current_rule].StateDirection)
                        {
                            case "L":
                                if (current_tape == 0) //Underflow
                                    goto default;
                                current_tape--;
                                header.Point1 -= 20;
                                count = mainSystem.MainMachine.MachineTuple.Rules.Count;
                                break;
                            case "R":
                                if (current_tape == commonTape.Count - 1) //Overflow
                                    goto default;
                                current_tape++;
                                header.Point1 += 20;
                                count = mainSystem.MainMachine.MachineTuple.Rules.Count;
                                break;
                            default:
                                MessageBox.Show("An error in the head direction", "Machine Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                current_rule = -1;
                                break;
                        }

                        //Update the current tape
                        commonTape[current_tape].BaseColor = Color.Red;
                    }
                    //If it's not the same character, check the next rule
                    else
                    {
                        count--;
                        if (count <= 0)
                        {
                            //MessageBox.Show("Rejected");
                            reject = true;
                            break;
                        }
                        current_rule = (current_rule < mainSystem.MainMachine.MachineTuple.Rules.Count - 1) ? current_rule + 1 : 0;
                        
                        continue;
                    }
                }
                //If it's not the same, check the next rule
                //Check first if the traversing exceeded, if it exceeded then there's a missing node
                else
                {
                    current_rule = (current_rule < mainSystem.MainMachine.MachineTuple.Rules.Count - 1) ? current_rule + 1 : 0;
                    count--;
                    //if(current_rule > mainSystem.MainMachine.MachineTuple.Rules.Count)
                    //{
                    //    MessageBox.Show("Rejected");
                    //    break;
                    //}
                    continue;
                }

                //Check for the next state
                //If the next state is the same state, then it means it is a loop
                //If it is a loop, the rule should not change
                if (!(commonStates[current_state].BaseName == mainSystem.MainMachine.MachineTuple.Rules[current_rule].StateNextState))
                {
                    //current_rule = 0;
                    //If it is not a loop, check the next state
                    for (int counter = 0; counter < commonStates.Count; counter++)
                    {
                        if (commonStates[counter].BaseName == mainSystem.MainMachine.MachineTuple.Rules[current_rule].StateNextState)
                        {
                            commonStates[current_state].BaseColor = Color.Black;
                            current_state = counter;
                            commonStates[current_state].BaseColor = Color.Red;
                            break;
                        }
                    }
                    //End of updating current state
                }
                //End of checking next state
                txtResultConsole.Text += Environment.NewLine + String.Format("In State: {0};; In Character: {1}", commonStates[current_state].BaseName, commonTape[current_tape].BaseName);
                txtResultConsole.Text += Environment.NewLine + String.Format("\tUsing Rule: {0}", current_rule);
            }

            //End of Rule reading
            ///
            if (!reject)
            {
                if (mainSystem.MainMachine.MachineTuple.AcceptState.Contains(commonStates[current_state].BaseName))
                {
                    //txtResultConsole.Text += Environment.NewLine + Environment.NewLine + "Machine is in accept state, therefore the machine has accepted the language";
                    lbl_result.Text = "Accepted";
                    MessageBox.Show(Environment.NewLine + Environment.NewLine + "Machine is in accept state, therefore the machine has accepted the language");
                }
                else if (mainSystem.MainMachine.MachineTuple.HaltState.Contains(commonStates[current_state].BaseName))
                {
                    txtResultConsole.Text += Environment.NewLine + Environment.NewLine + "Machine is in halt state, therefore the machine has accepted the language but in midway";
                }
                else if (mainSystem.MainMachine.MachineTuple.RejectState.Contains(commonStates[current_state].BaseName))
                {
                    txtResultConsole.Text += Environment.NewLine + Environment.NewLine + "Machine is in reject state, therefore the machine has rejected the language";
                }
                else if (!mainSystem.MainMachine.MachineTuple.Rules[current_rule].StateRead.Equals(commonTape[current_tape].BaseName))
                {
                    txtResultConsole.Text += Environment.NewLine + Environment.NewLine + "Machine is in reject state, therefore the machine has rejected the language";
                }
                else
                {
                    txtResultConsole.Text += Environment.NewLine + Environment.NewLine + "Machine has encountered a problem, therefore the machine or the language have error";
                }
            } else
            {
                //txtResultConsole.Text += Environment.NewLine + Environment.NewLine + "Machine has rejected the string!";
                MessageBox.Show(Environment.NewLine + Environment.NewLine + "Machine has rejected the string!");
                lbl_result.Text = "rejeted";
            }


            spcSimulate.Panel1.Refresh();
            spcSimulate.Panel2.Refresh();
        }
    }
}
