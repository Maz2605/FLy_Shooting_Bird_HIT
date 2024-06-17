using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BulletData", menuName ="Bullet Data")]
public class BulletData : ScriptableObject
{
    public List<Sprite> sprites;    
    public List<float> damage;    
}
