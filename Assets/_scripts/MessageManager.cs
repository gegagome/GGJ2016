/**/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MessageManager:MonoBehaviour{

private List<Listener> listeners = new List<Listener>();

	void OnStart()
	{
		//Register self with Utilities (All this for good null checking)
		Utilities.SetMessenger(this);
	}


	void Update()
	{
		/*if (Input.GetKeyDown("space"))
		{
			foreach (Listener l in listeners)
			{
				Debug.Log(l.ListenFor);
			}
		}*/
		/*
		if (Input.GetKeyDown (KeyCode.L)) {
			Debug.Log ("Listeners Count: " + listeners.Count);
		}*/



	}


	/**
	 * Called by subscribers when they want to listen to a specific event
	 */
	public void RegisterListener(Listener l)
	{
		listeners.Add(l);
	}

	/**
	 * Uses LINQ code to update all subscribed listeners when a event/message of that nature
	 * has been triggered
	 */
	public void SendToListeners (Message m)
	{	
		foreach (var f in listeners.FindAll(l => l.ListenFor == m.MessageName)) {
			if (f.ForwardToObject != null) //I was TOLD I DON'T HAVE TO DO NULL CHECKING HERE!!!!!!!	
			{	
				f.ForwardToObject.BroadcastMessage (f.ForwardToMethod, m, SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}

public class GGJBehaviour : MonoBehaviour {
	//Observer Pattern BaseScript
	//Listeners/Observers will extend this class and subscribe to specific events
	//Messengers/Triggers/Observables will extend this class and send out messages for specific events
	//all objects will have reference to Messenger which functions as broadcaster
	protected MessageManager Messenger;




	public void Start()
	{
		Messenger = GameObject.Find("GameManager").GetComponent<MessageManager>();
		if(!Messenger) Debug.LogError("GameManager.MessageManager could not be found.  Insure there is a GameManager object with a MessageManager script attached.");
		OnStart();
	}


	void OnDestroy()
	{
		//TODO: Remove all listeners registered to Messenger listener list?
		//mylisteners  = new listener list
		OnDestroyOverride();
	}

	protected virtual void OnStart()
	{
	}

	protected virtual void OnDestroyOverride()
	{

	}


}

//LISTENER CLASS
public class Listener {
	public string ListenFor;
	public GameObject ForwardToObject;
	public string ForwardToMethod;

	public Listener(string lf, GameObject fo, string fm)
	{
		ListenFor = lf; //message name that you want to be subscribed to
		ForwardToObject = fo; //suscribed object
		ForwardToMethod = fm; //method to invoke once message received
	}
}

//MESSAGE CLASS
public class Message {
	public GameObject MessageSource 	{ get; set; }
	public string MessageName 		{ get; set; }

	public Message(GameObject s, string n)
	{
		MessageSource = s; //allows direct reference to game object that sent message
		MessageName = n; //lookup by message name so only those listening for a specific message type are alerted
	}
}