using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;

namespace MachineReader
{
    public class SystemHandler
    {
        private static SystemHandler mainSystem;
        private static List<string> errorLog = new List<string>();
        private static int countLog = 0;

        private Machine mainMachine;

        string program;
        int lastChar;
        string readSymbol;
        string nextState;
        string nextSymbol;
        string direction;
        string state;
        string prevState;

        public Machine MainMachine { get { return mainMachine; } }
        public List<string> ErrorLog { get { return errorLog; } }

        private SystemHandler() { }

        #region Static Methods
        //Get the system
        public static SystemHandler InitializeSystem()
        {
            if (mainSystem == null)
                mainSystem = new SystemHandler();
            return mainSystem;
        }

        //FOR DEBUGGING
        private static void SystemLog(string error)
        {
            try
            {
                errorLog.Add(error);
            }
            catch (Exception ex)
            {
                if (countLog == 5)
                    return;
                SystemLog(String.Format("Function: SystemLog();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            return;
        }

        //FOR DEBUGGING
        public static void PrintLog()
        {
            if (errorLog.Capacity == 0 || errorLog == null)
                return;
            else
            {
                using (var writer = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Errorlog.txt")))
                {
                    foreach (string s in errorLog)
                        writer.WriteLine(s);
                }
            }
        }

        public static string GetRawData(string filename)
        {
            string line = "", outputLine = "";
            try
            {
                using (var reader = new StreamReader(filename))
                {
                    while ((line = reader.ReadLine()) != null)
                        outputLine += line + Environment.NewLine ?? Environment.NewLine;
                    return outputLine;
                }
            }
            catch (IOException ex)
            {
                SystemLog(String.Format("Function: GetRawData();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            catch (Exception ex)
            {
                SystemLog(String.Format("Function: GetRawData();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            return null;
        }
        #endregion

        #region Import Functions
        public bool ImportMachineFile(string filename)
        {
            try
            {
                return (Path.GetExtension(filename) == ".xml") ? ImportXMLFileMachine(filename) : ImportTextFileMachine(filename);
            }
            catch (IOException ex)
            {
                SystemLog(String.Format("Function: ImportMachineFile();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            catch (Exception ex)
            {
                SystemLog(String.Format("Function: ImportMachineFile();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            return false;
        }

        #region Angelo

        private bool ImportTextFileMachine(string filename)
        {
            try
            {
                using (var stream = new StreamReader(filename))
                {

                    string line = null;
                    StringBuilder builder = new StringBuilder();

                    while ((line = stream.ReadLine()) != null)
                    {
                        builder.Append(line).Append("\n");
                    }
                    program = builder.ToString();
                    lastChar = program.IndexOf("\n");
                    initiateRules();
                    return true;
                }
            }
            catch (IOException ex)
            {
                SystemLog(String.Format("Function: ImportTextFileMachine();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            catch (Exception ex)
            {
                SystemLog(String.Format("Function: ImportTextFileMachine();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            return false;
        }

        void initiateRules()
        {
            bool start = false;
            string finalState = "F";
            MachineRule mr;
            List<string> set_state = new List<string>();
            List<string> alphabets;
            List<string> tape = new List<string>();
            List<MachineRule> machine_rules = new List<MachineRule>();
            List<string> start_state = new List<string>();
            List<string> accept_state = new List<string>();
            List<string> halt_state = new List<string>();
            List<string> reject_state = new List<string>();

            accept_state.Add(finalState);
            halt_state.Add(finalState);

            List<string> alphabetsReadWrite = new List<string>();
            tape.Add("~");

            for (int i = 1; program.Length > i; i++)
            {
                switch (i % lastChar)
                {
                    case 1:
                        state = program[i].ToString();
                        if (!start)
                        {
                            start = true;
                            //start_state[i - 1] = state;
                            start_state.Add(state);
                            set_state.Add(state);
                            prevState = state;
                        }
                        if (prevState != state)
                        {
                            //set_state[l] = prevState;
                            //l++;
                            set_state.Add(state);
                            reject_state.Add(state);
                            //if (state == "F")
                            //{
                            //    //reject_state[k] = state;
                            //    //k++;
                            //    reject_state.Add(state);
                            //}
                        }
                        //if (!(program.Length > i++))
                        //{
                        //    accept_state[j] = state;
                        //    halt_state[j] = state;
                        //    j++;
                        //}
                        //else

                        break;
                    case 3:
                        readSymbol = program[i].ToString();
                        alphabetsReadWrite.Add(readSymbol);
                        //m++;

                        break;
                    case 5:
                        nextState = program[i].ToString();
                        break;
                    case 7:
                        nextSymbol = program[i].ToString();
                        //alphabetsReadWrite[m] = readSymbol;
                        //m++;
                        alphabetsReadWrite.Add(readSymbol);
                        break;
                    case 9:
                        if (Convert.ToChar(program[i].ToString()) == '<')
                            direction = "L";
                        else
                            direction = "R";
                        mr = new MachineRule(state, readSymbol, nextSymbol, direction, nextState);
                        machine_rules.Add(mr);
                        prevState = state;
                        break;
                }
            }
            set_state.Add(finalState);
            alphabets = alphabetsReadWrite;
            alphabets.Distinct().ToArray();
            MachineTuple machineTuple = new MachineTuple(
                set_state.ToArray(),
                alphabets.ToArray(),
                tape.ToArray(),
                machine_rules,
                start_state.ToArray(),
                accept_state.ToArray(),
                halt_state.ToArray(),
                reject_state.ToArray());
            mainMachine = new Machine("Machine", machineTuple, "Language");
        }
        #endregion

        private bool ImportXMLFileMachine(string filename)
        {
            try
            {
                using (var stream = new FileStream(filename, FileMode.Open))
                {
                    using (var reader = XmlDictionaryReader.CreateTextReader(stream, new XmlDictionaryReaderQuotas()))
                    {
                        DataContractSerializer serializer = new DataContractSerializer(typeof(Machine));
                        mainMachine = (Machine)serializer.ReadObject(reader, true);
                        return true;
                    }
                }
            }
            catch (SerializationException ex)
            {
                SystemLog(String.Format("Function: ImportXMLFileMachine();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            catch (IOException ex)
            {
                SystemLog(String.Format("Function: ImportXMLFileMachine();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            catch (Exception ex)
            {
                SystemLog(String.Format("Function: ImportXMLFileMachine();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            return false;
        }
        #endregion

        #region Export Functions
        public bool ExportMachineFile(string filename)
        {
            try
            {
                return (Path.GetExtension(filename) == ".xml") ? ExportXMLFileMachine(filename) : ExportTextFileMachine(filename);
            }
            catch (IOException ex)
            {
                SystemLog(String.Format("Function: ImportMachineFile();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            catch (Exception ex)
            {
                SystemLog(String.Format("Function: ImportMachineFile();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            return false;
        }

        private bool ExportTextFileMachine(string filename)
        {
            try
            {
                using (var writer = new StreamWriter(filename))
                {
                    bool firstline = true;
                    string convert;
                    foreach (MachineRule rule in mainMachine.MachineTuple.Rules)
                    {
                        if (firstline)
                            writer.Write("-");
                        convert = (rule.StateDirection == "R") ? ">" : "<";
                        writer.WriteLine(String.Format($@"{rule.StateName},{rule.StateRead} {rule.StateNextState},{rule.StateWrite},{convert}"));
                        firstline = false;
                    }
                    return true;
                }
            }
            catch (IOException ex)
            {
                SystemLog(String.Format("Function: ExportTextFileMachine();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            catch (Exception ex)
            {
                SystemLog(String.Format("Function: ExportTextFileMachine();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            return false;
        }

        private bool ExportXMLFileMachine(string filename)
        {
            try
            {
                using (var stream = new FileStream(filename, FileMode.OpenOrCreate))
                {
                    using (var writer = XmlDictionaryWriter.CreateTextWriter(stream, Encoding.UTF8, true))
                    {
                        DataContractSerializer serializer = new DataContractSerializer(typeof(Machine));
                        serializer.WriteObject(stream, mainMachine);
                        return true;
                    }
                }
            }
            catch (SerializationException ex)
            {
                SystemLog(String.Format("Function: ExportXMLFileMachine();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            catch (IOException ex)
            {
                SystemLog(String.Format("Function: ExportXMLFileMachine();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            catch (Exception ex)
            {
                SystemLog(String.Format("Function: ExportXMLFileMachine();; Source: {0};; Message: {1}", ex.Source, ex.Message));
            }
            return false;
        }
        #endregion
    }
}
