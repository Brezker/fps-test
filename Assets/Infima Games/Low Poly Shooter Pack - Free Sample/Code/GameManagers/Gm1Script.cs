using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gm1Script : MonoBehaviour
{
    public int enemiesRemaining;

    void Update()
    {
        EnemyCounter();
    }

    public void EnemyCounter()
    {
        enemiesRemaining = GameObject.FindGameObjectsWithTag("Enemy").Length;
        print("Enemies: "+enemiesRemaining);
        
        if (enemiesRemaining == 0)
        {
            SceneManager.LoadScene("Nivel2");
        }
    }

    public void EnemyDefeated()
    {
        enemiesRemaining--;
    }
}
