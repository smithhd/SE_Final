//Hunter Smith
//moves the camera following the character

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraMove : MonoBehaviour
{
    private Transform target;

    private float xmin;

    private float xmax;

    private float ymin;

    private float ymax;

    [SerializeField]
    private Tilemap tilemap;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;

        Vector3 mintile = tilemap.CellToWorld(tilemap.cellBounds.min);
        Vector3 maxtile = tilemap.CellToWorld(tilemap.cellBounds.max);

        setLimits(mintile, maxtile);
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        
        //transform.position = new Vector3(Mathf.Clamp(target.position.x, xmin, xmax), Mathf.Clamp(target.position.y, ymin, ymax), transform.position.z);
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);

    }

    //prevents the camera from moving off the map edges 
    private void setLimits(Vector3 maxtile, Vector3 mintile)
    {
        Camera cam = Camera.main;

        float height = 2f * cam.orthographicSize;
        float width = height * cam.aspect;

        xmin = mintile.x + width / 2;
        xmax = maxtile.x - width / 2;

        ymin = mintile.y + height / 2;
        ymax = maxtile.x - height / 2;
    }
    
}
