using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private TMP_Text Puntaje;

    private int puntos;
    private float tiempo;
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Update()
    {
        Puntuacion();
    }
    public void ShowGameOverScreen()
    {
        GameOverScreen.SetActive(true);
    }

    public void ReiniciarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    private void Puntuacion()
    {
        int scorePerSeconds = 10;

        tiempo += Time.deltaTime;
        puntos = (int)(tiempo * scorePerSeconds);
        Puntaje.text = string.Format("{0:000000}", puntos);
    }
}
   
 