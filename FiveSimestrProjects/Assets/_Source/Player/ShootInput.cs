using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Player
{
    public class ShootInput : MonoBehaviour
    {
        private Shoot _shoot;
        private float _reloadTime;
 

        public void Initialize(Shoot shoot)
        {
            _shoot = shoot;
        }
       
        public void Update()
        {
            
            if (Input.GetKeyDown(KeyCode.Space) && _reloadTime < 0)
            {
                _shoot.Shooting();
               
            }
           
            _reloadTime -= Time.deltaTime;
            
          
        }
        public void SetReloadTime(float kd)
        {
              
            _reloadTime = kd;
        }
    }
}

