using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObject : MonoBehaviour
{   

    public GameObject[] objs;

    // Start is called before the first frame update

    // Update is called once per frame
    public void Change()
    {
        int ran = Random.Range(0, objs.Length);

        for (int index=0; index < objs.Length; index++) {
            transform.GetChild(index).gameObject.SetActive(ran == index);

        }
    }
}
