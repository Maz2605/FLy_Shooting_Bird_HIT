using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName ="BlockData", menuName =("Block Data"))]
public class BlockData : ScriptableObject
{
    public List<BlockInfor> blockInfors;
}
[Serializable]
public class BlockInfor
{
    public BlockType blockType;
    public float maxHP;
    public List<Sprite> status;
}
public enum BlockType
{
    Wood = 0,
    Stone = 1, 
    Metal = 2,
}