using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOs
{
    [CreateAssetMenu(fileName = "PancakeSO", menuName = "ScriptableObjects/PancakeSO", order = 1)]
    public class PancakeSO : ScriptableObject
    {
        public GameObject PancakePref;
        public int ScoreCost;
    }
}

