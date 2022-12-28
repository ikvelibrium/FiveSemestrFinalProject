using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SOs;

namespace StatRandom
{
    public static class RandomSpawn 
    {
        public static void RSpawn(ref List<PancakeSO> pancakes)
        {
            for (int i = 0; i < pancakes.Count; i++)
            {
                int rnd = Random.Range(0, pancakes.Count);
                PancakeSO pancake = pancakes[i];
                pancakes[i] = pancakes[rnd];
                pancakes[rnd] = pancake;
            }
        }
    }
}

