using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackTest : MonoBehaviour
{
    // Start is called before the first frame update
    public OVRSkeleton skeleton;
    public GameObject cube;
    void Start()
    {
        for(int i = 0; i < skeleton.Bones.Count;i++) {
            Debug.Log("asdf");
            GameObject temp =  Instantiate(cube);
            temp.transform.position = skeleton.Bones[i].Transform.position;
            temp.transform.parent = skeleton.Bones[i].Transform;
        }   
    }

    // Update is called once per frame
    void Update()
    {
    }

}
