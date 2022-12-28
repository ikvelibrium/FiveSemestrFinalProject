using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MVC;
using StateMach;
using Player;
using SOs;
using StatRandom;
using Towers;

namespace Core
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private Tower _tower;
        [SerializeField] private List<LVLSO> _levelsSOs;

        [SerializeField] private Transform _shootPoint;
        [SerializeField] private ShootInput _shootInput;
        [SerializeField] private ReloadSO _reloadSO;
        [SerializeField] private BulletSO _bulletSO;

        [SerializeField] private ScoreLoad _scoreLoad;

        private TowerSpawn _towerSpawn;
        private StateMachine _stateMachine;
        private void Awake()
        {
            _stateMachine = new StateMachine();
            new StateInitializer(_stateMachine);
            _towerSpawn = new TowerSpawn(_levelsSOs, _tower);
            new Reload(_scoreLoad, _reloadSO, _shootInput);
            new Score(_scoreLoad);
            _shootInput.Initialize(new Shoot(_shootPoint, _bulletSO.bulletPref));
            _towerSpawn.SpawnTower(_stateMachine);

            _stateMachine.StartState(typeof(Game));

        }
    }
}