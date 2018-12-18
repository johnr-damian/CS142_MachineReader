using System.Runtime.Serialization;

namespace BasicMachineSimulator.App_Code.Machine
{
    /// <summary>
    /// Contains all information about the Turing Machine
    /// </summary>
    [DataContract]
    public class TuringMachine
    {
        /// <summary>
        /// The Language that the Machine accepts
        /// </summary>
        [DataMember]
        public string MachineLanguage { get; set; } = "";
        /// <summary>
        /// The Description of the Machine in English
        /// </summary>
        [DataMember]
        public string MachineDescription { get; set; } = "";
        /// <summary>
        /// Who created or design this Machine
        /// </summary>
        [DataMember]
        public string Author { get; set; } = "";
        /// <summary>
        /// The Tuple of the Machine
        /// </summary>
        [DataMember]
        public MachineTuple Tuple { get; set; } = new MachineTuple();
    }
}
