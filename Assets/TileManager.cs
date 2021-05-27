using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject [] Tiles;
    public GameObject currentTile;
    //public GameObject forwardTile;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            SpawnTile();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnTile()
    {
        int index = Random.Range(0, 2);
        currentTile =(GameObject) Instantiate(Tiles[index], currentTile.transform.GetChild(index).position, Quaternion.identity);
    }
}
