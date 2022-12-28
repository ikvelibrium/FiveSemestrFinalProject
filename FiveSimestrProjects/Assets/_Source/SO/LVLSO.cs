using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SOs
{
    [CreateAssetMenu(fileName = "LVLSO", menuName = "ScriptableObjects/LVLSO", order = 1)]
    public class LVLSO : ScriptableObject
    {
        public List<TowerInfo> Pancakes;
        public GameObject WallPref;
    }
}

