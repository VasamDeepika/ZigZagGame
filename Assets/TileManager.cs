using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public GameObject [] Tiles;
    public GameObject currentTile;
    public PlayerMovement player;
    public Camera camfollow;
    public float blockArrowPointer = -10;
    public float safeMargin = 10;
    //public GameObject forwardTile;
    // Start is called before the first frame update
    void Start()
    {
        /*for (int i = 0; i < 20; i++)
        {
            SpawnTile();
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        while (player != null && blockArrowPointer < player.transform.position.x + safeMargin)
        {
            int value = Random.Range(0, Tiles.Length);
            if (blockArrowPointer < 10)
            {
                value = 0;
            }
            GameObject blocksPrefab = Instantiate(Tiles[value]);
            BlockSize bs = blocksPrefab.GetComponent<BlockSize>();
            SpawnTile();
            blockArrowPointer += bs.blockSize;
        }
        if (player != null)
        {
            camfollow.transform.position = new Vector3(player.transform.position.x, camfollow.transform.position.y, camfollow.transform.position.z);
        }
    }
    void SpawnTile()
    {
        int index = Random.Range(0, 2);
        currentTile =(GameObject) Instantiate(Tiles[index], currentTile.transform.GetChild(index).position, Quaternion.identity);
    }
}
