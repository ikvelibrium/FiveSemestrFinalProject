using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVC;

namespace StateMach
{
    public class Lose : MainGameState
    {
        ScoreLoad _scoreLoad;
        public Lose(StateMachine admin) : base(admin)
        {

        }

        public override void Enter()
        {
            Debug.Log("Loose");

            Time.timeScale = 0;
            Score.OnLose?.Invoke();
            Score.OnExpose?.Invoke();
            
            _admin.Expose();
        }
    }
}
