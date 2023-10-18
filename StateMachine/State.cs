using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMachine
{
    public abstract class State
    {
        public abstract bool isValid();
        public abstract void Enter(object[] data);
        public abstract bool Execute();
        public abstract State Exit(); //returns next state on exit
    }
}