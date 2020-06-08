using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackTest : MonoBehaviour
{
    // Start is called before the first frame update
    public OVRSkeleton skeleton;
    public GameObject cube;
    public OVRHand hand; 

    private Transform transform;
    public GameObject Fake_hand;
    public GameObject True_hand;
    void Start()
    {
        for(int i = 0; i < skeleton.Bones.Count;i++) {
            Debug.Log("asdf");
            GameObject temp =  Instantiate(cube);
            temp.transform.position = skeleton.Bones[i].Transform.position;
            temp.transform.parent = skeleton.Bones[i].Transform;
        }   
        StartCoroutine(Timer(1));
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void Scan(){
        if(!hand.IsTracked || hand.HandConfidence == OVRHand.TrackingConfidence.Low){
            
            if(transform != null){
                Fake_hand.transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z);
            }

        }
        if(hand.IsTracked || hand.HandConfidence == OVRHand.TrackingConfidence.High){
            transform = True_hand.transform;
        }
    }
    IEnumerator Timer(float second){
        while(true){
            Debug.Log("time");
            yield return new WaitForSeconds(second);
            Scan();
        }
    }
}
