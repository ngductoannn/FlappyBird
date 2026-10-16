using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
using UnityEngine.Rendering;

public class GameController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Obstacle1;
    public GameObject Obstacle2;
    public float timeSpawn;
    private float tmp;
    void Start()
    {
        tmp = timeSpawn;
    }

    void Update()
    {
        timeSpawn-=Time.deltaTime;
        if(timeSpawn <= 0)
        {
            Instantiate(Obstacle1, new Vector3(9.85f, Random.Range(-4f,-3f), 0), Quaternion.identity);
            Instantiate(Obstacle2, new Vector3(9.85f, Random.Range(4f,6f), 0), Quaternion.identity);
            timeSpawn = tmp;
        }
    }
}
