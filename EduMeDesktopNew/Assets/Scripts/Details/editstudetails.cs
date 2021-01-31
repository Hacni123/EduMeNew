using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class editstudetails : MonoBehaviour
{
     public Dropdown myDropdown;
    public Dropdown myDropdown2;

    void Start()
    {
         StartCoroutine(Func1());
    }

    public void runeditclz()
    {
         StartCoroutine(EditClz());
    }

     public void runeditlanguage()
    {
         StartCoroutine(EditLanguage());
    }

 public  IEnumerator EditClz()
    {
        
        DBManager.dropdownvalue=myDropdown.captionText.text.ToString();
        WWWForm form= new WWWForm();
        form.AddField("myDropdown", DBManager.dropdownvalue);
        form.AddField("name", DBManager.username);
        
        WWW www= new WWW("https://edumeuwu.000webhostapp.com/editdetails.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
            Debug.Log("Clz Edited successfully");
        }
        else
        {
            Debug.Log("Clz edition failed. Error #" +www.text);
           
        }
    }

public  IEnumerator EditLanguage()
    {
        
       
        DBManager.dropdownvalue2=myDropdown2.value;
        WWWForm form= new WWWForm();
        form.AddField("myDropdown2", DBManager.dropdownvalue2);
         form.AddField("name", DBManager.username);

        WWW www= new WWW("https://edumeuwu.000webhostapp.com/editdetails2.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
            Debug.Log("Language editd successfully");
        }
        else
        {
            Debug.Log("Language edition failed. Error #" +www.text);
            
        }
    }
    public IEnumerator Func1()
    {
        
        WWW hs_get = new WWW("https://edumeuwu.000webhostapp.com/dropdowndata.php");
        yield return hs_get;
 
        if (hs_get.error != null)
        {
            print("There was an error getting the high score: " + hs_get.error);
        }
        else
        {
            string itemsDataString = hs_get.text;
            string[] wwwItems = itemsDataString.Split (';'); //the values in mysql db is picked in a single string and should have some marker so as to split
            myDropdown.options.Clear ();
            foreach (string str in wwwItems) {
            myDropdown.options.Add (new Dropdown.OptionData (str));
         }
           
        }
    }
}
