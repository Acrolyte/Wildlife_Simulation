using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawn : MonoBehaviour
{
     public GameObject theTree;
        public int xPos;
        public int zPos;
        public int x1, x2, z1, z2, y;
        public int treeCount;
        public int TotalTrees;
        void Start()
        {
            StartCoroutine(SpawnTrees());
        }
    
        IEnumerator SpawnTrees()
        {
            while (treeCount < TotalTrees)
            {
                xPos = Random.Range(x1,x2);
                zPos = Random.Range(z1, z2);
                Instantiate(theTree, new Vector3(xPos, y, zPos), Quaternion.identity);
                yield return new WaitForSeconds(0.1f);
                treeCount += 1;
            }   
        }
}