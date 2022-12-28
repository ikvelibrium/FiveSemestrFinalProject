using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace StateMach
{
    public class StateMachine
    {
        private Dictionary<Type, MainGameState> _states;
        private MainGameState _nowState;

        public Dictionary<Type, MainGameState> States { get => _states; }

        public static Action<Type> OnChangeState;
        public StateMachine()
        {
            _states = new Dictionary<Type, MainGameState>();
            Bind();
        }
        public void Update()
        {
            _nowState.Update();
        }

        private void Bind()
        {
            OnChangeState += ChangeState;
        }
        public void Expose()
        {
            OnChangeState -= ChangeState;
        }
        
        public void ChangeState(Type type)
        {
            
            Debug.Log(type);
            _nowState.Exit();
            StartState(type);

        }

        public void StartState(Type type)
        {
            _nowState = _states[type];
            _nowState.Enter();
            Debug.Log(type);
        }
    }

}
