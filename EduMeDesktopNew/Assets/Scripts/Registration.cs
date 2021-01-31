using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Registration : MonoBehaviour
{
    public InputField nameField;
    public InputField age;
    public Dropdown myDropdown;
    public Dropdown myDropdown2;
    public Button submitButton;
    protected string name = "";
	protected string age1 = "";
    public Text Description = null;
	private static Text _Descrip = null;
    const string PrefName = "optionvalue";


    public void Start()
    {
        StartCoroutine(Func1());
    }
 
    
    public void OnClickLogin()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public  IEnumerator Register()
    {
        
        DBManager.dropdownvalue=myDropdown.captionText.text.ToString();
        DBManager.dropdownvalue2=myDropdown2.value;
        WWWForm form= new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("age", age.text);
        form.AddField("myDropdown", DBManager.dropdownvalue);
        form.AddField("myDropdown2", DBManager.dropdownvalue2);
        
        WWW www= new WWW("https://edumeuwu.000webhostapp.com/RegisterUser.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
            Debug.Log("User created successfully");
            UpdateDescription("User created successfully");
             UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("User creation failed. Error #" +www.text);
            UpdateDescription(" "+www.text);
        }
    }
   public void RegisterUser()
	{

		if (nameField.text != string.Empty && age.text != string.Empty)
		{
			StartCoroutine(Register());	
		}
		else
		{
			if (nameField.text == string.Empty)
			{
				UpdateDescription("User Name Field is empty");
			}
			
			if (age.text == string.Empty)
			{
				UpdateDescription("Age Field is empty");
			}
            if (nameField.text == string.Empty  && age.text == string.Empty)
			{
				UpdateDescription("Complete all the fields above.");
			}
		}
	}

    void UpdateDescription(string descText)
	{
        _Descrip = Description;
		_Descrip.text = descText;
	}

    public void Toggle_Changed(bool newValue)
    {
         UnityEngine.SceneManagement.SceneManager.LoadScene(6);
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
