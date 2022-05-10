using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();  //位置を少しだけ上に更新

        if (transform.position.y >=11f)  //もし画面に映らなくなったら
        {
            ResetPosition(); //一番下の位置に移動
        }

    }
    void Scroll()
    {
        //位置を少しだけ上に更新するコード
        Vector3 pos = transform.position;

        float ScrollSpeed = 1;
        pos.y += ScrollSpeed;
        transform.position = pos;

    }
    void ResetPosition()
    {
        //一番下の位置に移動するコード
        Vector3 pos = transform.position;
        pos.y -= 30f;
        transform.position = pos;
    }
}
