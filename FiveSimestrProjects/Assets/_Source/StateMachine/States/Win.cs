using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVC;

namespace StateMach
{
    public class Win : MainGameState
    {
        public Win(StateMachine admin) : base(admin)
        {

        }
        public override void Enter()
        {
            Debug.Log("win");
            Score.OnWin?.Invoke();
            Score.OnExpose.Invoke();
            Time.timeScale = 0;
            _admin.Expose();
        }
    }

}
