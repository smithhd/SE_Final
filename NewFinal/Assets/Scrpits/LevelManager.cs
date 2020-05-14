/*
 *  Hunter Smith
 *  
 *
 *
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private Texture2D[] mapData;

    [SerializeField]
    private mapElement[] mapElements;

    [SerializeField]
    private Sprite defaultTile;

    private Vector3 WorldStartPos
    {
        get
        {
            return Camera.main.ScreenToWorldPoint(new Vector3(0, 0));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[Serializable]
public class mapElement
{
    [SerializeField]
    private string tileTag;

    [SerializeField]
    private Color color;

    private GameObject elementPrefab;

    [SerializeField]
    public GameObject myElementPrefab
    {
        get
        {
            return elementPrefab;
        }
    }

    public Color myColor
    {
        get
        {
            return color;
        }
    }

    public string myTiletag
    {
        get
        {
            return tileTag;
        }
    }
}
*/

