using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class childscript : MonoBehaviour
{
    [SerializeField]
    RectTransform rectTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 3);
    }



    void Destroy()
    {
        Destroy(gameObject);
        Debug.Log("è¡Ç¶ÇΩéûä‘" + Time.time);
    }
}
