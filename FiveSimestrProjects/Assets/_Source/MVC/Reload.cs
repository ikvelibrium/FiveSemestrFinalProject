using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using SOs;
using Player;

namespace MVC
{
    public class Reload 
    {

        private ScoreLoad _scoreLoad;
        private ReloadSO _reloadSO;
        private ShootInput _shootInput;
        private int _amountOfAmo;

        public static Action OnReloadChange;
        public static Action OnExpose;

        public Reload(ScoreLoad scoreLoad, ReloadSO reloadSO, ShootInput shootInput )
        {
            _scoreLoad = scoreLoad;
            _scoreLoad.Bind(reloadSO.Fullammo);
            _scoreLoad = scoreLoad;
            _reloadSO = reloadSO;
            _shootInput = shootInput;
            Bind();
        }
        private void Bind()
        {
            OnReloadChange += AmmoShoot;
            OnExpose += Expose;
        }
        private void Expose()
        {
            OnReloadChange -= AmmoShoot;
            OnExpose -= Expose;
        }
        
        private void AmmoShoot()
        {
            
            _amountOfAmo -= _reloadSO.AmmoPerShoot;
            _scoreLoad.UpdateReloadView(_amountOfAmo);
            Debug.Log(_amountOfAmo);
            if (_amountOfAmo <= 0)
            {

                _amountOfAmo = _reloadSO.Fullammo;
                _shootInput.SetReloadTime(_reloadSO.ReloadTime);
                
            }
        }
        
    }
}