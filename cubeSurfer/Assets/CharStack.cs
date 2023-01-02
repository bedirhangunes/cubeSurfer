using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharStack : MonoBehaviour
{
    public List<GameObject> blockList = new List<GameObject>();
    private GameObject lastBlockObj;
    void Start()
    {
        UpdateLastBlockObj();  
    }

   public void IncreasedBlockStack(GameObject _gameObject)//summer cube
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z);
        _gameObject.transform.position = new Vector3(lastBlockObj.transform.position.x, lastBlockObj.transform.position.y - 2f, lastBlockObj.transform.position.z);
        _gameObject.transform.SetParent(transform);
        blockList.Add(_gameObject);//add list
        UpdateLastBlockObj();
    }
    public void DecreaseBlock(GameObject _gameObject)
    {
        _gameObject.transform.parent = null;
        blockList.Remove(_gameObject);
        UpdateLastBlockObj();
    }


    private void UpdateLastBlockObj()
    {
        lastBlockObj = blockList[blockList.Count - 1];//last object
    }
}
