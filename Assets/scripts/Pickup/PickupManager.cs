using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupManager : MonoBehaviour
{
    [SerializeField] GameObject cherry;
    GameObject cherrygameobject;
    float y;
    Vector3 xmin;
    Vector3 xmax;
    float randnumber;
    /*float xmaxworldpos;*/
   /* randomizeblock myrandomizeblock;*/
    // Start is called before the first frame update
    void Start()
    {
        PlayerManager.Instance.Targetreachedevent += throwcherry;
        cherrygameobject = Instantiate(cherry,Vector3.zero,Quaternion.identity);
        cherrygameobject.SetActive(false);
      /*  xmaxworldpos = Camera.main.ViewportToWorldPoint(new Vector3(1,0)).x;*/
      /*  myrandomizeblock = FindObjectOfType<randomizeblock>();*/

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    [System.Obsolete]
    public void throwcherry()
    {


        xmin = BlockManager.Instance.xmid;
        xmax = BlockManager.Instance.xmax;
       
        randnumber = Random.Range(1,4);
       /* if ((randnumber==1 || randnumber==2 || randnumber == 3) && cherrygameobject.active==false)
        {*/

            Vector3 secondpos = BlockManager.Instance.secondpos;
            Vector3 thirdpos = BlockManager.Instance.thirdpos;
        float difference = thirdpos.x - secondpos.x;
            Debug.Log("the difference "+difference);
            if (thirdpos.x - secondpos.x > 2f)
            {
                cherrygameobject.SetActive(true);
                 y = -2.5f;   
                cherrygameobject.transform.position = new Vector3(Random.Range(secondpos.x + 1f, thirdpos.x - 1f), y, 0f);
            }
        }
    }


