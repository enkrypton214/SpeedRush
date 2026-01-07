
using UnityEngine;

public class NextMapScript : MonoBehaviour
{
     public GameObject NextMapList;
    private Vector3 myposition;
    private int x;
    private int y=0;
    

    void OnTriggerEnter(Collider collider)
    {
        y=x;
        while (x==y){
        x=Random.Range(0,3);}
        myposition = this.transform.position;
        NextMapList.transform.GetChild(x).transform.position = myposition + new Vector3 (0,0,450);
        Debug.Log(x);
        

    }

}
