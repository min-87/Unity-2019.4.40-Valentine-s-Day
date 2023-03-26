using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float timer;
    [SerializeField] private GameObject heartPrefab;
    [SerializeField] private GameObject badHeartPrefab;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn(){
        while(true){
            if(Random.Range(0, 100) > 25){
                GameObject temp = Instantiate(heartPrefab, transform.position, Quaternion.identity);
                Destroy(temp, 5f);
            }else{
                GameObject temp = Instantiate(badHeartPrefab, transform.position, Quaternion.identity);
                Destroy(temp, 5f);
            }
            yield return new WaitForSeconds(timer);
        }
    }
}
