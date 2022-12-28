using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOs
{
    [CreateAssetMenu(fileName = "ReloadSO", menuName = "ScriptableObjects/ReloadSO", order = 1)]
    public class ReloadSO : ScriptableObject
    {
        
        public int Fullammo;
        public int AmmoPerShoot;
        public float ReloadTime;
    }
}

