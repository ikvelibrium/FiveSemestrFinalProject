using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SOs;
using StateMach;
using MVC;

namespace Towers
{
    public class Tower : MonoBehaviour
    {
        [SerializeField] private LayerMask _bulletLayer;
        private List<GameObject> _pancakeGameObjs;
        private List<PancakeSO> _pancakes;
        private Vector3 _vector;
        private int _bulletLayerNumb;

        public void TowerInitialize(List<PancakeSO> pancakes, List<GameObject> pancakeGameObjs, StateMachine stateMachine)
        {
            _pancakes = pancakes;
            _pancakeGameObjs = pancakeGameObjs;
            _vector = new Vector3(0, pancakeGameObjs[0].transform.localScale.y, 0);
            _bulletLayerNumb = (int)Mathf.Log(_bulletLayer.value, 2);

        }
        private void TowerGetShot()
        {
            Destroy(_pancakeGameObjs[0]);
            _pancakeGameObjs.RemoveAt(0);
            _pancakes.RemoveAt(0);
            transform.position -= _vector;
        }

        private void IsWin()
        {
            if (_pancakeGameObjs.Count <=0)
            {
                Debug.Log("Is win");
                StateMachine.OnChangeState?.Invoke(typeof(Win));
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.layer == _bulletLayerNumb)
            {
                Destroy(other.gameObject);
                Score.OnScoreChange?.Invoke(_pancakes[0].ScoreCost);
                TowerGetShot();
                IsWin();
            }
        }

    }
}

