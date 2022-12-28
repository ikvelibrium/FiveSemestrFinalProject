using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SOs;

namespace Player
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rb;
        [SerializeField] private BulletSO _bulletSO;
        private void Start()
        {
            _rb.AddForce(_rb.transform.forward * _bulletSO.Speed);
        }
    }
}

