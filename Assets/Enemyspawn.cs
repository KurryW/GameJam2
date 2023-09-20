using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Enemyspawn : MonoBehaviour
{

    //public GameObject[] SpawnLocations;
    //public GameObject[] objectToSpawn;
    
    [SerializeField] private string sceneName;

    public GameObject SpacebarButton;
    public GameObject SpawnEnemy1;
    public GameObject SpawnEnemy2;
    public GameObject SpawnEnemy3;
    public GameObject SpawnEnemy4;


    // Start is called before the first frame update
    void Start()
    {
        //objectToSpawn = new GameObject[SpawnLocations.Length];
        
    }

    private void OnTriggerEnter(Collider other)
    {
        SpacebarButton.SetActive(true);
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        SpacebarButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(SpawnEnemy1 == false)
        {
            SpawnEnemy2.SetActive(true);
        }
        
        if (SpawnEnemy2 == false)
        {
            SpawnEnemy3.SetActive(true);
        }
        
        if (SpawnEnemy3 == false)
        {
            SpawnEnemy4.SetActive(true);
        }

        if (SpawnEnemy4 == false)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
