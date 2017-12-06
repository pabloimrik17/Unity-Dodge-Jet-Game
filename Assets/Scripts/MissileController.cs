using System.Collections;
using UnityEngine;

public class MissileController : MonoBehaviour {

    public GameObject hazard;
 
    private float spawnWait = 1f;
 
    void Start() {
        StartCoroutine(SpawnWaves());
    }
 
    IEnumerator SpawnWaves() {
        while (true) {
            var xMinMax = Random.Range(-15f, 20f);
            Vector3 spawnPosition = new Vector3(xMinMax, 10f, 25f);
            Quaternion spawnRotation = Quaternion.Euler(new Vector3(90f,0f,0f));
            Instantiate(hazard, spawnPosition, spawnRotation);
            yield return new WaitForSeconds(spawnWait);
            spawnWait -= 0.01f;
            if (spawnWait < 0.05f) spawnWait = 0.05f;
        }
    }
}
