﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField]
    private StartingBlock blockPreFab;
    public int cloneIncrement;

    public void SpawnBlock()
    {
        //This class file is done so that the block spawns after being placed
        var block = Instantiate(blockPreFab);
        block.name = "StartingBlock " + cloneIncrement;
        // placing the position of the new block at this flat position
        block.transform.position = new Vector3(Random.Range(-4f, 4f), 3f, transform.position.z);
        cloneIncrement++;
        block.transform.localScale = new Vector3(StartingBlock.LastBlock.transform.localScale.x,
                                                StartingBlock.LastBlock.transform.localScale.y,
                                                StartingBlock.LastBlock.transform.localScale.z);
    }
}
