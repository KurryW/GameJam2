using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Enemyspawn enemyspawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            enemyspawn.ActivateSpacebarButton();
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                enemyspawn.OnEnemyDeath();
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            enemyspawn.DeactivateSpacebarButton();
        }

    }
}
