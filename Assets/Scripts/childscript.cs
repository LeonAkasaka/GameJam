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
        Invoke("Destroy", 5);
    }



    void Destroy()
    {
        Destroy(gameObject);
    }
}
