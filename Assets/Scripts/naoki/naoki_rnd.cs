using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class naoki_rnd : MonoBehaviour
{

    [SerializeField]
    private Button _scoreButton = null;

    bool FB = false;

    int key = 0;

    int rnd = 0;



    void Start()
    {
        rnd = Random.Range(10,100);

        Debug.Log(rnd);

        var e = new Button.ButtonClickedEvent();
        e.AddListener(() =>
        {
            if(FB == false)
            {
                key++;
                if (key >= rnd)
                {
                    FB = true;
                }
            }

         });
        _scoreButton.onClick = e;

        //Debug.Log(Random.Range(10, 100));
    }

    void Update()
    {
        if(FB == true)
        {

        }
    }
}