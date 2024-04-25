using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TouchPoint : MonoBehaviour
{

    public int id;
    [SerializeField] private List<Sprite> listWt;

    private bool isSelected = false;

    private void OnEnable()
    {
        var it = listWt[Random.Range(0, listWt.Count)];
        GetComponent<SpriteRenderer>().sprite = it;
        id = listWt.IndexOf(it);

    }

    public void SetCollected()
    {
        if(isSelected) return;
        isSelected = true;
        transform.localScale = Vector3.one*0.6f;
        GetComponent<BoxCollider2D>().enabled = false;
    }
    public void SetUnCollected()
    {
        isSelected = false;
        transform.localScale = Vector3.one*0.5f;
        GetComponent<BoxCollider2D>().enabled = true;
    }
}