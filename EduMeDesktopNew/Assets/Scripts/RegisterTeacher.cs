using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RegisterTeacher : MonoBehaviour
{
    public InputField nameField;
    public InputField passwordField;
    public InputField classnameField;
    public Dropdown myDropdown2;
    public Button submitButton;
    
    protected string name = "";
	protected string username = "";
    protected string classname = "";
    public Text Description = null;
	private static Text _Descrip = null;

    public void OnClickLogin()
    {
        
            UnityEngine.SceneManagement.SceneManager.LoadScene(7);
    }

    public  IEnumerator Register()
    {
        DBManager.dropdownvalue2=myDropdown2.value;
        WWWForm form= new WWWForm();
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);
        form.AddField("classname", classnameField.text);
        form.AddField("myDropdown2", DBManager.dropdownvalue2);
        WWW www= new WWW("https://edumeuwu.000webhostapp.com/registerteacher.php",form);
        yield return www;
        if(www.text[0]=='0')
        {
            Debug.Log("User created successfully");
            UpdateDescription("User created successfully");
             UnityEngine.SceneManagement.SceneManager.LoadScene(7);
        }
        else
        {
            Debug.Log("User creation failed. Error #" +www.text);
            UpdateDescription(" Name already exists");
        }
    }
   public void RegisterUser()
	{

		if (nameField.text != string.Empty && passwordField.text != string.Empty && classnameField.text != string.Empty)
		{
			
				StartCoroutine(Register());	
		}
		else
		{
			if (nameField.text == string.Empty)
			{
				UpdateDescription("User Name Field is empty");
			}
			if (passwordField.text == string.Empty)
			{
			    UpdateDescription("Password Field is empty");
			}
            if (classnameField.text == string.Empty)
			{
			    UpdateDescription("Classname Field is empty");
			}
            if (nameField.text == string.Empty && passwordField.text == string.Empty && classnameField.text == string.Empty)
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

     public void Toggle_Changed1(bool newValue)
    {
         UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
