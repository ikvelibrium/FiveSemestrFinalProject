using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SOs;
using MVC;

namespace Towers
{
    public class Wall : MonoBehaviour
    {
        [SerializeField] private Transform _rotateCenter;
        [SerializeField] private WallSO _wallSO;
        private int bullenLayerNum;

        private void Start()
        {
            bullenLayerNum = (int)Mathf.Log(_wallSO.Bullet.value, 2);
        }
        private void Update()
        {
            transform.RotateAround(_rotateCenter.position, Vector3.up, _wallSO.WallSpeed * Time.deltaTime);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.layer == bullenLayerNum)
            {
                Destroy(other.gameObject);
                Score.OnScoreChange?.Invoke(_wallSO.minusScore);
                Destroy(gameObject);
            }
        }

    }
}

