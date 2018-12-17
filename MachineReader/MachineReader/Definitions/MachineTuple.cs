using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MachineReader
{
    [DataContract]
    public class MachineTuple
    {
        private string[] Q;
        private string[] E;
        private string[] T;
        private List<MachineRule> Z;
        private string[] q0;
        private string[] qA;
        private string[] qH;
        private string[] qR;

        #region Properties
        [DataMember]
        public string[] States { get { return Q; } private set { Q = value; } }

        [DataMember]
        public string[] Alphabets { get { return E; } private set { E = value; } }

        [DataMember]
        public string[] Tape { get { return T; } private set { T = value; } }

        [DataMember]
        public List<MachineRule> Rules { get { return Z; } private set { Z = value; } }

        [DataMember]
        public string[] StartState { get { return q0; } private set { q0 = value; } }

        [DataMember]
        public string[] AcceptState { get { return qA; } private set { qA = value; } }

        [DataMember]
        public string[] HaltState { get { return qH; } private set { qH = value; } }

        [DataMember]
        public string[] RejectState { get { return qR; } private set { qR = value; } } 
        #endregion

        private MachineTuple() { }
        public MachineTuple(string[] set_states, string[] alphabets, string[] tape, List<MachineRule> machine_rules, string[] start_state, string[] accept_state, string[] halt_state, string[] reject_state)
        {
            this.Q = set_states;
            this.E = alphabets;
            this.T = tape;
            this.Z = machine_rules;            
            this.q0 = start_state;
            this.qA = accept_state;
            this.qH = halt_state;
            this.qR = reject_state;
        }
    }
}
