using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemyspawn : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public GameObject[] enemies;
    private int enemyIndex = 0;

    public GameObject SpacebarButton;


    private void Start()
    {
        enemies[enemyIndex].SetActive(true);
    }

    public void ActivateSpacebarButton()
    {
        SpacebarButton.SetActive(true);
    }

    public void DeactivateSpacebarButton()
    {
        SpacebarButton.SetActive(false);
    }

    public void OnEnemyDeath()
    {
        enemies[enemyIndex].SetActive(false);
        enemyIndex++;

        if (enemyIndex >= enemies.Length)
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            enemies[enemyIndex].SetActive(true);
            DeactivateSpacebarButton();
        }
    }
    
}
