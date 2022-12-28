using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMach
{
    public class StateInitializer 
    {
        public StateInitializer(StateMachine stateMachine)
        {
            stateMachine.States.Add(typeof(Game), new Game(stateMachine));
            stateMachine.States.Add(typeof(Lose), new Lose(stateMachine));
            stateMachine.States.Add(typeof(Win), new Win(stateMachine));
            
        }
    }
}

