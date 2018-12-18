using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BasicMachineSimulator.App_Code.Machine
{
    /// <summary>
    /// Contains the specifics of a rule
    /// </summary>
    [DataContract]
    public class TransitionTableRule
    {
        /// <summary>
        /// The State where the rule being applied
        /// </summary>
        [DataMember]
        public string CurrentState { get; set; } = "";

        /// <summary>
        /// What does the State reads
        /// </summary>
        [DataMember]
        public string OnRead { get; set; } = "";

        /// <summary>
        /// On Reading the alphabet, Write What?
        /// </summary>
        [DataMember]
        public string ThenWrite { get; set; } = "";

        /// <summary>
        /// The direction of the header of the tape after writing
        /// </summary>
        [DataMember]
        public string TapeDirection { get; set; } = "";

        /// <summary>
        /// The next state after reading the alphabet
        /// </summary>
        [DataMember]
        public string NextState { get; set; } = "";
    }
}
