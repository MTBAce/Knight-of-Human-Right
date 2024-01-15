using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bakgrundscript : MonoBehaviour
{
    public GameObject[] levels;
    private Camera maincam;
    private Vector2 screenBounds;
    public float choke;

    private void Start()
    {
        maincam = gameObject.GetComponent<Camera>();
        screenBounds = maincam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, maincam.transform.position.z));
        foreach (GameObject obj in levels)
        {
            loadChildObject(obj);
        }

    }

    void loadChildObject(GameObject obj)
    {
        float objectWidth = obj.GetComponent<SpriteRenderer>().bounds.size.x - choke;
        int childneeded = (int)Mathf.Ceil(screenBounds.x * 2 / objectWidth);
        GameObject clone = Instantiate(obj) as GameObject;
        for (int i = 0; i <= childneeded; i++)
        {
            GameObject c = Instantiate(clone) as GameObject;
            c.transform.SetParent(obj.transform);
            c.transform.position = new Vector3(objectWidth * i, obj.transform.position.y, obj.transform.position.z);
            c.name = obj.name + i;
        }
        Destroy(clone);
        Destroy(obj.GetComponent<SpriteRenderer>());
    }
    void repositionchildobject(GameObject obj)
    {
        Transform[] children = obj.GetComponentsInChildren<Transform>();
        if (children.Length > 1)
        {
            GameObject firstchild = children[1].gameObject;
            GameObject lastchild = children[children.Length - 1].gameObject;
            float halfobjectWidth = lastchild.GetComponent<SpriteRenderer>().bounds.extents.x - choke;
            if (transform.position.x + screenBounds.x > lastchild.transform.position.x + halfobjectWidth)
            {
                firstchild.transform.SetAsLastSibling();
                firstchild.transform.position = new Vector3(lastchild.transform.position.x + halfobjectWidth * 2, lastchild.transform.position.y, lastchild.transform.position.z);

            }
            else if (transform.position.x - screenBounds.x < firstchild.transform.position.x - halfobjectWidth)
            {
                lastchild.transform.SetAsFirstSibling();
                lastchild.transform.position = new Vector3(firstchild.transform.position.x - halfobjectWidth * 2, firstchild.transform.position.y, firstchild.transform.position.z - halfobjectWidth * 2);
            }
        }
    }
    void LateUpdate()
    {
        foreach (GameObject obj in levels)
        {
            repositionchildobject(obj);
        }
    }
}