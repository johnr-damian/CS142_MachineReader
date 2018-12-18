using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BasicMachineSimulator.App_Code.Machine
{
    /// <summary>
    /// Contains the rules for the Machine
    /// </summary>
    [DataContract]
    public class TransitionTable
    {
        /// <summary>
        /// The list of rules
        /// </summary>
        [DataMember]
        public List<TransitionTableRule> Rule { get; set; } = new List<TransitionTableRule>();
    }
}
