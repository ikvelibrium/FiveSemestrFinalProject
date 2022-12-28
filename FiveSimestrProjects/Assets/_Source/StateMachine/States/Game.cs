using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StateMach
{
    public class Game : MainGameState
    {
        public Game(StateMachine admin) : base(admin)
        {

        }
        public override void Enter()
        {
            Time.timeScale = 1;

        }
        public override void Exit()
        {
           Time.timeScale = 0;
        }
    }
}

