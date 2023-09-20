using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemyspawn : MonoBehaviour
{
    [SerializeField] private string sceneName;

    public GameObject[] enemies = new GameObject[5];
    private int enemyIndex = 0;

    public GameObject SpacebarButton;
    public GameObject PoisonUI;


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
        PoisonUI.SetActive(true);
        Invoke(nameof(DisablePoisonUI), 4f);

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

    private void DisablePoisonUI()
    {
        PoisonUI.SetActive(false);
    }
    
}
