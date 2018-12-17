using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MachineReader
{
    [DataContract]
    public class MachineRule
    {
        private string stateName;
        private string stateRead;
        private string stateWrite;
        private string stateDirection;
        private string stateNextState;

        #region Properties
        [DataMember]
        public string StateName { get { return stateName; } private set { stateName = value; } }

        [DataMember]
        public string StateRead { get { return stateRead; } private set { stateRead = value; } }

        [DataMember]
        public string StateWrite { get { return stateWrite; } private set { stateWrite = value; } }

        [DataMember]
        public string StateDirection { get { return stateDirection; } private set { stateDirection = value; } }

        [DataMember]
        public string StateNextState { get { return stateNextState; } private set { stateNextState = value; } }
        #endregion

        private MachineRule() { }
        public MachineRule(string state_name, string state_read, string state_write, string state_direction, string state_nextState)
        {
            this.stateName = state_name;
            this.stateRead = state_read;
            this.stateWrite = state_write;
            this.stateDirection = state_direction;
            this.stateNextState = state_nextState;
        }
    }
}
