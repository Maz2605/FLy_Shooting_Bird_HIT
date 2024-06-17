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
    public float maxHP;
    public void SetData()
    {
        maxHP = GameData.Instance.blockData.blockInfors[(int)blockType].maxHP;
        curHP = maxHP;
        sr.sprite = GameData.Instance.blockData.blockInfors[(int)blockType].status[2];
    }
    public void TakeDamege(float damege)
    {
        curHP -= damege;
        if(curHP < 0)
        {
            Disable();
            ++GameData.Instance.score;
        }
        SetSprite();
    }
    public void SetSprite()
    {
        if(curHP / maxHP > 1f/ 3)
        {
            sr.sprite = GameData.Instance.blockData.blockInfors[(int)blockType].status[2];
        }
        else if(curHP/maxHP > 2f/3) 
        { 
            sr.sprite = GameData.Instance.blockData.blockInfors[(int)blockType].status[1];
        }
        else if(curHP / maxHP > 0) 
        { 
            sr.sprite = GameData.Instance.blockData.blockInfors[(int)blockType].status[0];
        }
    }
}
