using System.Runtime.Serialization;

namespace MachineReader
{
    [DataContract]
    public class Machine
    {
        private string machineName;
        private MachineTuple machineTuple;
        private string machineLanguage;

        #region Properties
        [DataMember]
        public string MachineName { get { return machineName; } private set { machineName = value; } }

        [DataMember]
        public MachineTuple MachineTuple { get { return machineTuple; } private set { machineTuple = value; } }

        [DataMember]
        public string MachineLanguage { get { return machineLanguage; } private set { machineLanguage = value; } } 
        #endregion

        private Machine() { }
        public Machine(string machine_name, MachineTuple machine_tuple, string machine_language)
        {
            machineName = machine_name;
            machineTuple = machine_tuple;
            machineLanguage = machine_language;
        }
    }
}
