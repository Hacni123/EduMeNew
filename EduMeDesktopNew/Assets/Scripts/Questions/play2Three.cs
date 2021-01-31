using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class play2Three : MonoBehaviour
{
   public GameObject feed_benar, feed_salah;
   public Text playerDisplay;
	public Text scoreDisplay;
   public GameObject questionpanel2Three;
   public GameObject mez8;
   public GameObject eng;
   public GameObject sin;
   public GameObject tam;
   public GameObject correctAnswer;
   public GameObject hintOption;

 public void Start()
   {
         if(DBManager.dropdownvalue2==0)
         {
           tam.SetActive(false);
           sin.SetActive(false);
           eng.SetActive(true);
         }
         else if(DBManager.dropdownvalue2==1)
         {
           tam.SetActive(false);
           sin.SetActive(true);
           eng.SetActive(false);
         }
         else if(DBManager.dropdownvalue2==2)
         {
           tam.SetActive(true);
           sin.SetActive(false);
           eng.SetActive(false);
         }
   }
   
   public void jawaban(bool jawab)
   {
         feed_benar.SetActive (false);
			feed_salah.SetActive (false);
         feed_salah.SetActive (false);
         if (jawab) 
         {
				feed_salah.SetActive (false);
				feed_benar.SetActive (true);
            correctAnswer.SetActive (false);    
				if(DBManager.the_level==1)
				{
               DBManager.score1=DBManager.score1+30;
				   scoreDisplay.text="Score :" +DBManager.score1;    
				}
				else if(DBManager.the_level==2)
				{
               DBManager.score2=DBManager.score2+50;
				   scoreDisplay.text="Score :" +DBManager.score2;    
				}
            DBManager.division1+=1; 
			} else 
         {
            correctAnswer.SetActive (true);
				feed_benar.SetActive (false);
				feed_salah.SetActive (true);   
            DBManager.division2+=1;   
			}
			gameObject.SetActive(false);
         transform.parent.GetChild(gameObject.transform.GetSiblingIndex () +1).gameObject.SetActive(true);        
   }
     public void continueButton()
     {
       Destroy(questionpanel2Three);
       Destroy(mez8);
     } 

     public void okButton()
     {
       Destroy(correctAnswer);
     } 

	public void hintOpen()
     {
      hintOption.SetActive (true);
     } 

      public void hintClose()
     {
       hintOption.SetActive (false);
     } 
   
}

