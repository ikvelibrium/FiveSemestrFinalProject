using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMach
{
    public abstract class MainGameState 
    {
        protected StateMachine _admin;
        protected MainGameState(StateMachine admin)
        {
            _admin = admin;
        }
        public virtual void Enter()
        {

        }
        public virtual void Update()
        {

        }
        public virtual void Exit()
        {

        }
    }
}

