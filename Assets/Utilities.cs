using UnityEngine;
using System.Collections;
using System.IO;
using System;

public static class Utilities
{

	public static MessageManager Messenger;

	public static int Row1 = 11;
	public static int Row2 = 12;
	public static int Row3 = 13;
	public static int AllRows = 14;


	/*
	 * Checks passed in Game object to see if any of it's tags are of the requested value
	 */ 
	public static bool hasMatchingTag(GGJTag tagToCheckFor, GameObject objectToCheck)
	{
		MultiTagScript mult =  objectToCheck.GetComponent<MultiTagScript>();
		if (mult != null) { return mult.objectHasTag(tagToCheckFor);}
		return false;
	}

	public static void SetMessenger(MessageManager theMessenger)
	{
		Messenger = theMessenger;
	}

	public static void RegisterListener(Listener listenerToRegister)
	{
		if (Messenger == null) {
			//this should not be null unless the scene is changing and messenger has already been destroyed
			Messenger = GameObject.Find("World").GetComponent<MessageManager>();
		}
		if (Messenger != null) //null checking in case messenger has been destroyed due to change in scene
		{
			Messenger.RegisterListener(listenerToRegister);
		}
	}



	public static void SendToListeners(Message messageToSend)
	{
		if (Messenger == null) { 
			//this should not be null unless the scene is changing and messenger has already been destroyed
			GameObject messObj  = GameObject.Find("World");
			if (messObj != null)
			{
				Messenger = messObj.GetComponent<MessageManager>();
			}
		}
		if (Messenger != null) //null checking in case messenger has been destroyed due to change in scene
		{
			Messenger.SendToListeners(messageToSend);
		}
	}

	public static void LoadLevel(string SceneNameToChangeTo) {
		if (SceneNameToChangeTo.Equals("")) return; //thus get the broadcast but don't load the scene, yes i know this is bad
		Application.LoadLevel (SceneNameToChangeTo);

	}

	public static void LoadLevel(int SceneNumToChangeTo) {
		Application.LoadLevel (SceneNumToChangeTo);

	}
}

