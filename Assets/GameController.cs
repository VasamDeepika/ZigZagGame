using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public PlayerMovement player;
    public Camera camfollow;
    public GameObject[] blocks;
    public float blockArrowPointer = -10;
    public float safeMargin = 20;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        while (player != null && blockArrowPointer < player.transform.position.x + safeMargin)
        {
            int value = Random.Range(0, blocks.Length);
            if (blockArrowPointer < 10)
            {
                value = 0;
            }
            GameObject blocksPrefab = Instantiate(blocks[value]);
            BlockSize bs = blocksPrefab.GetComponent<BlockSize>();
            blocksPrefab.transform.position = new Vector3(blockArrowPointer + bs.blockSize / 2, 0, 0);
            blockArrowPointer += bs.blockSize;
        }

        if (player != null)
        {
            camfollow.transform.position = new Vector3(player.transform.position.x, camfollow.transform.position.y, camfollow.transform.position.z);
        }


    }

}