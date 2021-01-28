using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : PlayerController
{
   // Start is called before the first frame update
     public override void Start()
     {
        base.Start();
        if(DBManager.the_level==1)
				{
                transform.position = new Vector3(DBManager.x,DBManager.y,DBManager.z); 
                 SavePosition();  
				}
		else if(DBManager.the_level==2)
				{
               transform.position = new Vector3(DBManager.x2,DBManager.y2,DBManager.z2);
               SavePosition2(); 
				}
        else if(DBManager.the_level==3)
				{
               transform.position = new Vector3(DBManager.x3,DBManager.y3,DBManager.z3);
               SavePosition3(); 
				}        
       else if(DBManager.the_level==2)
				{
               transform.position = new Vector3(DBManager.x4,DBManager.y4,DBManager.z4);
               SavePosition4(); 
				}
       
     }
      public override void Awake()
     {
        if(DBManager.username==null)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        base.Awake();
         
     }
     public override void Update()
     {
        base.Update();
       if (Input.GetKeyDown(KeyCode.Space))
        {
              base.Jump();
        }
     }

      public void CallSaveData()
    {
        StartCoroutine(base.SavePlayerData());
        StartCoroutine(base.SavePosition());

    }
    public void CallSaveData2()
    {
        StartCoroutine(base.SavePlayerData2());
        StartCoroutine(base.SavePosition2());

    }
    public void CallSaveData3()
    {
        StartCoroutine(base.SavePlayerData3());
        StartCoroutine(base.SavePosition3());

    }
    public void CallSaveData4()
    {
        StartCoroutine(base.SavePlayerData4());
        StartCoroutine(base.SavePosition4());

    }
    
}
