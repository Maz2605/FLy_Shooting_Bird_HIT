using GameTool;
using UnityEngine;

public class Wall : BasePooling
{
    private float wallSpeed = 4f;
    private int min = 1;
    private int max = 4;
    private float bound;
    private int blockNumber = 4;
    private void OnEnable()
    {
        bound = Camera.main.orthographicSize;
        CreateBlock();
    }
    private void CreateBlock()
    {
        float[] height = new float[blockNumber];
        height[0] = Random.Range(min, max);
        height[1] = bound - height[0];
        height[2] = Random.Range(min, max);
        height[3] = bound - height[2];

        float[] posY = new float[blockNumber];
        posY[0] = bound - height[0] / 2;
        posY[1] = height[1] / 2;
        posY[2] = -height[2] / 2;
        posY[3] = -bound + height[3] / 2;   

        for(int i =  0; i < blockNumber; i++) 
        {
            var block = (Block) PoolingManager.Instance.GetObject(NamePrefabPool.Block, transform, new Vector2(transform.position.x, posY[i]));   
            block.sr.size = new Vector2(block.sr.size.x, height[i]);
        }
    }
    private void Update()
    {
        transform.position = new Vector3(transform.position.x-wallSpeed*Time.deltaTime, transform.position.y,transform.position.z);
    }
}
