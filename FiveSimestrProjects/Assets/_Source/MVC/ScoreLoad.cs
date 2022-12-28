using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


namespace MVC
{
    public class ScoreLoad : MonoBehaviour
    {
        [SerializeField] private TMP_Text _scoreText;
        [SerializeField] private TMP_Text _winScore;
        [SerializeField] private GameObject _winScreen;
        [SerializeField] private GameObject _looseScreen;

        [SerializeField] private Slider ammoLvl;
        [SerializeField] private Button _restartButton1;
        [SerializeField] private Button _restartButton2;
       
        public void Bind(int ammo)
        {
            ammoLvl.maxValue = ammo;
            ammoLvl.value = ammo;
            _restartButton1.onClick.AddListener(Restart);
            _restartButton2.onClick.AddListener(Restart);
        }
        public void Restart()
        {
            SceneManager.LoadScene(0);
        }
        public void UpdateReloadView(float ammo)
        {
            ammoLvl.value = ammo;
        }
        public void UpdateText(int score)
        {
            _scoreText.text = "Score: " + score;
            _winScore.text = "WinScore: " + score;
        }
        public void TurnOnWinScreen()
        {
            Debug.Log("WinScreenScore");
            _winScreen.gameObject.SetActive(true);
        }
        public void TurnOnLoseScreen()
        {
            Debug.Log("looseScreenScore");
            _looseScreen.gameObject.SetActive(true);
        }
    }
}

