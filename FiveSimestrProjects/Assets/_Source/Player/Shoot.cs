using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVC;

namespace Player
{
    public class Shoot
    {
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private GameObject _bulletPref;
        
        public Shoot(Transform shootPoint, GameObject bulletPref)
        {
            _shootPoint = shootPoint;
            _bulletPref = bulletPref;
        }

        public void Shooting()
        {
            GameObject.Instantiate(_bulletPref, _shootPoint.position, Quaternion.identity);
            Reload.OnReloadChange?.Invoke();
        }
    }
}