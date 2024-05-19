using GameTool;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : BasePooling
{
    public SpriteRenderer sr;
    public BoxCollider2D coll;
    public BlockType blockType;
    public float curHP;
    public void SetData()
    {
        curHP = GameData.Instance.blockData.blockInfors[(int)blockType].maxHP;
        sr.sprite = GameData.Instance.blockData.blockInfors[(int)blockType].status[2];
    }
}
