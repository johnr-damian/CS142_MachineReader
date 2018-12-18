using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BasicMachineSimulator.App_Code.Machine
{
    /// <summary>
    /// The Definition of the Machine
    /// </summary>
    [DataContract]
    public class MachineTuple
    {
        /// <summary>
        /// The set of States
        /// </summary>
        [DataMember]
        public List<string> States { get; set; } = new List<string>();

        /// <summary>
        /// The set of Alphabets
        /// </summary>
        [DataMember]
        public List<string> Alphabets { get; set; } = new List<string>();

        /// <summary>
        /// The Transition Table of the Machine
        /// </summary>
        [DataMember]
        public TransitionTable Rules { get; set; } = new TransitionTable();

        /// <summary>
        /// The initial state of the machine
        /// </summary>
        [DataMember]
        public string StartState { get; set; } = "";

        /// <summary>
        /// The final state of the machine
        /// </summary>
        [DataMember]
        public List<string> AcceptState { get; set; } = new List<string>();
    }
}
