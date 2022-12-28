using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using StateMach;

namespace MVC
{


    public class Score 
    {
        private int _score = 0;
        private ScoreLoad _scoreLoad;


        public static Action<int> OnScoreChange;
        public static Action OnWin;
        public static Action OnLose;
        public static Action OnExpose;

        public Score (ScoreLoad scoreLoad)
        {
            _scoreLoad = scoreLoad;
            Bind();
        }
        private void Bind()
        {
            OnScoreChange += ChangeScore;
            OnWin += _scoreLoad.TurnOnWinScreen;
            OnLose += _scoreLoad.TurnOnLoseScreen;
            OnExpose += Expose;
        }

        private void Expose()
        {
            OnScoreChange -= ChangeScore;
            OnWin -= _scoreLoad.TurnOnWinScreen;
            OnLose -= _scoreLoad.TurnOnLoseScreen;
            OnExpose -= Expose;
        }
        private void ChangeScore(int points)
        {
            _score += points;
            _scoreLoad.UpdateText(_score);
            if(_score <= 0)
            {
                Debug.Log("Lose in score");
                StateMachine.OnChangeState?.Invoke(typeof(Lose));
            }
        }
    }
}