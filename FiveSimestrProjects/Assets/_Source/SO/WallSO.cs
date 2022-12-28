using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOs
{
    [CreateAssetMenu(fileName = "WallSO", menuName = "ScriptableObjects/WallSO", order = 1)]
    public class WallSO : ScriptableObject
    {
        public int minusScore;
        public float WallSpeed;
        public LayerMask Bullet;

    }
}

