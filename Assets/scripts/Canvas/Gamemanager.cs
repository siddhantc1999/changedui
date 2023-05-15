using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    public Canvasidentity[] Canvases;
    public static Gamemanager Instance;
    public Canvas gameoverscreen;
    public Canvasidentity Currentscreen;
    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
      /*  PlayerManager.Instance.Targetreachedevent += Gameover;*/
        Canvases = FindObjectsOfType<Canvasidentity>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Canvasmanager(ScreenType screentype)
    {

     
        foreach (Canvasidentity screens in Canvases)
        {
          
            Currentscreen.Thiscanvas.enabled = false;  // getting called teice
            if (screens.screentype==screentype)
            {
             
                screens.Thiscanvas.gameObject.GetComponent<Canvas>().enabled = true;
                Currentscreen = screens;
                break;
            }
        }
        
    }
    //if the player losses make the gameover screen appear
    public void Gameover()
    {
        Canvasmanager(ScreenType.GameOver);
    }
}
public enum ScreenType
{
    Home,
    GamePlay,
    GameOver
}
