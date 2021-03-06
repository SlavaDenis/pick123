﻿/// <summary>
///
///----------- ESPAÑOL -----------
/// 
/// Este script sirve para refrescar los textos de la UI cuando se cambia el lenguage.
/// Con la funcion Awake hace que se ejecute la funcion Refresh_Language para que se cargue el lenguage guardado.
/// 
///----------- ENGLISH -----------
/// 
/// This script seves to refresh the UI texts when the user change the language.
/// The "Awake" function call the "Refresh_Language" function to load the saved language by the user.
/// 
/// </summary>


using UnityEngine;
using UnityEngine.UI;

public class Texts_Changer : MonoBehaviour 
{

	static Word_Database wordsDB;

	void Awake () 
	{

		wordsDB = GameObject.Find ("Words_Database").GetComponent<Word_Database>();
		Refresh_Language ();

	}

	public static void Refresh_Language () 
	{

		//BUTTON PLAY
		GameObject.Find ("MENU").transform.FindChild ("buttonPlay").transform.FindChild ("PlayText").GetComponent<TextMesh>().text = wordsDB.uiTextsLang[PlayerPrefs.GetInt("numberLanguae"), 2];
		GameObject.Find ("MENU").transform.FindChild ("buttonPlay").transform.FindChild ("PlayTextShadow").GetComponent<TextMesh>().text = wordsDB.uiTextsLang[PlayerPrefs.GetInt("numberLanguae"), 2];

        //MENU TEXT
        GameObject.Find("MENU").transform.FindChild("Canvas").transform.FindChild("TopBox").transform.FindChild("Text").GetComponent<Text>().text = wordsDB.uiTextsLang[PlayerPrefs.GetInt("numberLanguae"), 16];

        //CHANGE THE TEXTS OF THE OK AND NO BUTTONS
        GameObject.Find("Game_Controller").GetComponent<Game_Controller>().AreYouSureWindow.transform.FindChild ("TextOk").GetComponent<TextMesh>().text = wordsDB.uiTextsLang[PlayerPrefs.GetInt("numberLanguae"), 6];
		GameObject.Find("Game_Controller").GetComponent<Game_Controller>().AreYouSureWindow.transform.FindChild ("TextNo").GetComponent<TextMesh>().text = wordsDB.uiTextsLang[PlayerPrefs.GetInt("numberLanguae"), 7];

        //CHANGE TEXTS OF CATEGORY SELECTION
        GameObject.Find("CATEGORY_SELECTION").transform.FindChild("Canvas").transform.FindChild("TopBox").transform.FindChild("Text").GetComponent<Text>().text = wordsDB.uiTextsLang[PlayerPrefs.GetInt("numberLanguae"), 10];
        GameObject.Find("CATEGORY_SELECTION").transform.FindChild("Canvas").transform.FindChild("TopBox").transform.FindChild("SolvedWords").transform.FindChild("Text").GetComponent<Text>().text = wordsDB.uiTextsLang[PlayerPrefs.GetInt("numberLanguae"), 11];
        GameObject.Find("CATEGORY_SELECTION").transform.FindChild("Canvas").transform.FindChild("TopBox").transform.FindChild("TotalPorcent").transform.FindChild("Text").GetComponent<Text>().text = wordsDB.uiTextsLang[PlayerPrefs.GetInt("numberLanguae"), 12];

        //CHANGE TEXTS OF LEVEL SELECTION
        GameObject.Find("QUIZ_SELECTION").transform.FindChild("Canvas").transform.FindChild("TopBox").transform.FindChild("SolvedWords").transform.FindChild("Text").GetComponent<Text>().text = wordsDB.uiTextsLang[PlayerPrefs.GetInt("numberLanguae"), 14];
        GameObject.Find("QUIZ_SELECTION").transform.FindChild("Canvas").transform.FindChild("TopBox").transform.FindChild("TotalPorcent").transform.FindChild("Text").GetComponent<Text>().text = wordsDB.uiTextsLang[PlayerPrefs.GetInt("numberLanguae"), 15];
    }



}
