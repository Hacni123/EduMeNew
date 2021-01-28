using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class play2 : MonoBehaviour
{
   public GameObject feed_benar, feed_salah;
   public Text playerDisplay;
	public Text scoreDisplay;
   public GameObject questionpanel2;
   public GameObject mez1;
   public GameObject eng;
   public GameObject sin;
   public GameObject tam;
   public GameObject correctAnswer;

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
				correctAnswer.SetActive (false);
				feed_benar.SetActive (true);
            feed_salah.SetActive (false);    
				if(DBManager.the_level==1)
				{
               DBManager.score1=DBManager.score1+30;
				   scoreDisplay.text="Score :" +DBManager.score1;    
				}
				else if(DBManager.the_level==2)
				{
               DBManager.score=DBManager.score2+50;
				   scoreDisplay.text="Score :" +DBManager.score2;    
				}
               DBManager.addition1+=1;
			} else 
         {
				correctAnswer.SetActive (true);
				feed_salah.SetActive (true);
            feed_benar.SetActive (false);     
				DBManager.addition2+=1;
			
			}
           
			gameObject.SetActive(false);
         transform.parent.GetChild(gameObject.transform.GetSiblingIndex () +1).gameObject.SetActive(true);
           
            
   }
     public void continueButton()
     {
       Destroy(questionpanel2);
       Destroy(mez1);
     } 

     public void okButton()
     {
       Destroy(correctAnswer);
     }   
	
    
}

