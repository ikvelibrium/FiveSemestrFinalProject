using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SOs;
using StatRandom;
using StateMach;
namespace Towers
{
    public class TowerSpawn 
    {
        private LVLSO _lvlSO;
        private Tower _tower;
        public TowerSpawn(List<LVLSO> lvlSO, Tower tower)
        {
            int rnd = Random.Range(0, lvlSO.Count);
            _lvlSO = lvlSO[rnd];
            _tower = tower;
        }

        private List<GameObject> PancakesSpawn(List<PancakeSO> pancakesSO)
        {
            List<GameObject> pancakeGameObjs = new List<GameObject>();
            Vector3 positio = _tower.transform.position;
            float yAdd = pancakesSO[0].PancakePref.transform.localScale.y / 2 ;
            for (int i = 0; i < pancakesSO.Count; i++)
            {
                positio.y += yAdd;
                pancakeGameObjs.Add(GameObject.Instantiate(pancakesSO[i].PancakePref, _tower.transform));
                pancakeGameObjs[i].transform.position = positio;
                positio.y += yAdd;
            }
            return pancakeGameObjs;
        }
        private List<PancakeSO> FillPancakeSOList()
        {
            List<PancakeSO> pancakesSO = new List<PancakeSO>();

            for (int i = 0; i < _lvlSO.Pancakes.Count; i++)
            {
                for (int j = 0; j < _lvlSO.Pancakes[i].amountOfFloars; j++)
                {
                    pancakesSO.Add(_lvlSO.Pancakes[i].PancakeSO);
                }
            }

            RandomSpawn.RSpawn(ref pancakesSO);
            return pancakesSO;
        }
        public void SpawnTower(StateMachine stateMachine)
        {
            List<PancakeSO> pancakesSO = FillPancakeSOList();
            List<GameObject> pancakeGameObjs = PancakesSpawn(pancakesSO);
            _tower.TowerInitialize(pancakesSO, pancakeGameObjs, stateMachine);
            GameObject.Instantiate(_lvlSO.WallPref, _tower.transform.position, Quaternion.identity);
        }
        

    }
}

