using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class getallstudentdetailsindex : MonoBehaviour
{
    public Text username;
    public Text age;
    public Text score;
    public Text username1;
    public Text age1;
    public Text score1;
    public Text username2;
    public Text age2;
    public Text score2;
    
   
    public void Start()
    {
       StartCoroutine(StudentDetails()); 
    }


    public  IEnumerator StudentDetails()
    {
        WWWForm form= new WWWForm();
        form.AddField("name", DBManager.username);
        form.AddField("classname", DBManager.classname);
        WWW www= new WWW("http://localhost/gameone/getdatabyteacher.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
              
               username.text=www.text.Split('\t')[1];
               age.text=www.text.Split('\t')[2];
               score.text=www.text.Split('\t')[3];
        }    
        else
        {
            Debug.Log("User login failed. Error #" + www.text);

        }

    }

   
   

   

}
