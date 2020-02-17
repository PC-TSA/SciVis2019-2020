using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipScript : MonoBehaviour
{
    public Transform newParent;
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForParentChange(waitTime));
    }

    // Update is called once per frame
    IEnumerator WaitForParentChange(float time)
    {
        yield return new WaitForSeconds(time);
        transform.parent = newParent;
    }
}
