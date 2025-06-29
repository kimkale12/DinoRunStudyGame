using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public int count;
    public float speedRate;

    void Start()
    {
        count = transform.childCount;
    }

    void Update()
    {
        if (!GameManager.isLive)
            return; // 게임이 종료되면 동작하지 않음

        float totalSpeed = GameManager.globalSpeed * speedRate * Time.deltaTime * -1f;
        transform.Translate(totalSpeed, 0, 0); 
    }
}
