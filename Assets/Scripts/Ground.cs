using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 5f;
    private  Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        var currentTextureOffset = _renderer.material.GetTextureOffset("_MainTex");
        float distanceToScrollLeft = Time.deltaTime * scrollSpeed;
        float newXoffset = currentTextureOffset.x + distanceToScrollLeft;

        Vector2 newOffset = new Vector2(newXoffset, currentTextureOffset.y);
        _renderer.material.SetTextureOffset("_MainTex", newOffset);
    }
}
