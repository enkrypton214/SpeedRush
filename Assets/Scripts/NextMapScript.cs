
using UnityEngine;

public class NextMapScript : MonoBehaviour
{
     public GameObject NextMapList;
    private Vector3 myposition;
    private int x;

    void OnTriggerEnter(Collider collider)
    {
        x=Random.Range(0,4);
        myposition = this.transform.position;
        NextMapList.transform.GetChild(x).transform.position = myposition + new Vector3 (0,0,450);
        Debug.Log(this.transform.position);
        Debug.Log(NextMapList.transform.GetChild(x).name);
        

    }

}
