using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOs
{
    [CreateAssetMenu(fileName = "BulletSO", menuName = "ScriptableObjects/BulletSO", order = 1)]
    public class BulletSO : ScriptableObject
    {
        [SerializeField] public float Speed;
        public GameObject bulletPref;
    }
}

