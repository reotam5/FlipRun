using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.Tilemaps;

//this need Variables file

public class DisappearFloor : MonoBehaviour
{
    public Tilemap tilemap;
    public Variables var;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionStay2D(Collision2D col)
    {
        //(-9,-5) is the left bottom corner
        if (var.forward)//use ceil for x because of the direction going
        {
            if (var.down)
            {
                UnityEngine.Vector3Int curloc = new UnityEngine.Vector3Int(Mathf.CeilToInt(gameObject.transform.position.x - 1), Mathf.CeilToInt(gameObject.transform.position.y - 1), Mathf.CeilToInt(gameObject.transform.position.z));
                for (int i = -10; i < curloc.y; i++)
                {
                    StartCoroutine("dissfloor", new Vector3Int(curloc.x, i, 0));
                    //tilemap.SetTile(new Vector3Int(curloc.x, i, 0), null);
                }
            }
            else
            {
                UnityEngine.Vector3Int curloc = new UnityEngine.Vector3Int(Mathf.CeilToInt(gameObject.transform.position.x - 1), Mathf.CeilToInt(gameObject.transform.position.y - 1), Mathf.CeilToInt(gameObject.transform.position.z));
                for (int i = curloc.y; i < 10; i++)
                {
                    StartCoroutine("dissfloor", new Vector3Int(curloc.x, i, 0));
                    //tilemap.SetTile(new Vector3Int(curloc.x, i, 0), null);
                }
            }
        }
        else//use floor because of the direction going
        {
            if (var.down)
            {
                UnityEngine.Vector3Int curloc = new UnityEngine.Vector3Int(Mathf.CeilToInt(gameObject.transform.position.x - 1), Mathf.CeilToInt(gameObject.transform.position.y - 1), Mathf.CeilToInt(gameObject.transform.position.z));
                for (int i = -10; i < curloc.y; i++)
                {
                    StartCoroutine("dissfloor", new Vector3Int(curloc.x, i, 0));
                    //tilemap.SetTile(new Vector3Int(curloc.x, i, 0), null);
                }
            }
            else
            {
                UnityEngine.Vector3Int curloc = new UnityEngine.Vector3Int(Mathf.CeilToInt(gameObject.transform.position.x - 1), Mathf.CeilToInt(gameObject.transform.position.y - 1), Mathf.CeilToInt(gameObject.transform.position.z));
                for (int i = curloc.y; i < 10; i++)
                {
                    StartCoroutine("dissfloor", new Vector3Int(curloc.x, i, 0));
                    //tilemap.SetTile(new Vector3Int(curloc.x, i, 0), null);
                }
            }

        }

    }

    IEnumerator dissfloor(Vector3Int vec3)
    {
        yield return new WaitForSeconds(0.5f);

        tilemap.SetTile(vec3, null);
    }
}
