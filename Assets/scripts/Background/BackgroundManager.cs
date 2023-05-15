using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField] GameObject environment;
    public Renderer bgrenderer;
    public float speed;
    float halfHeight;
    float halfWidth;
    Vector3 targetpos;
    Vector3 environmenttargetpos;
    public bool cameramotion = false;
    public static BackgroundManager Instance;
    public float xcamera;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<PlayerManager>().Targetreachedevent += settargetpos;
        targetpos = Camera.main.transform.position;
        halfHeight = Camera.main.orthographicSize;
        halfWidth = Camera.main.aspect * halfHeight;
    }

    // Update is called once per frame
    void Update()
    {
       /* if(LineRendererManager.Instance.isgamestarted)
        {

        }*/
        //problem herer
        if (transform.position != targetpos)
        {
           
            transform.position = Vector3.MoveTowards(transform.position, targetpos, Time.deltaTime * 20f);
            environment.transform.position = Vector3.MoveTowards(environment.transform.position, environmenttargetpos, Time.deltaTime * 20f);
        }


    }
    public void settargetpos()
    {
        xcamera = BlockManager.Instance.diff;
        targetpos = new Vector3(transform.position.x + xcamera, transform.position.y, transform.position.z);
        environmenttargetpos = new Vector3(environment.transform.position.x + halfWidth, environment.transform.position.y, environment.transform.position.z);
        /*   xcamera =BlockManager.Instance.diff;*/
        /*  targetpos = new Vector3(transform.position.x + halfWidth, transform.position.y, transform.position.z);*/
    
    }

  
    /*public void startcamerasetting()
{
   Camera.main.transform.position = new Vector3(4f, 0f, -10f);
   Camera.main.orthographicSize = 4f;
}*/
    /* public void gameplaycamerasetting()
     {
         Camera.main.transform.position = new Vector3(6f, 0f, -10f);
         Camera.main.orthographicSize = 5f;
         LineRendererManager.Instance.isgamestarted = true;
         targetpos = Camera.main.transform.position;

     }*/

}