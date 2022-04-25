using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class OnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    Vector3 cachedScale;
    // Start is called before the first frame update
    void Start()
    {
        cachedScale = transform.localScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = cachedScale;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
