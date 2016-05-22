using UnityEngine;
using System.Collections;

public class CarScript : MonoBehaviour {
   private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
	public bool gripButtonDown = false;
	 public bool gripButtonUp = false;
	 public bool gripButtonPressed = false;
	public GameObject car;

   private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
   public bool triggerButtonDown = false;
	  public bool triggerButtonUp = false;
	  public bool triggerButtonPressed = false;

   private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
    private SteamVR_TrackedObject trackedObj;

	// Use this for initialization
	void Start () {
       trackedObj = GetComponent<SteamVR_TrackedObject>();
		car = GameObject.FindGameObjectWithTag ("Player");
	}

	// Update is called once per frame
	void Update () {
	    if (controller == null) {
           Debug.Log("Controller not initialized");
          return;
     }
      gripButtonDown = controller.GetPressDown(gripButton);
     gripButtonUp = controller.GetPressUp(gripButton);
     gripButtonPressed = controller.GetPress(gripButton);

       triggerButtonDown = controller.GetPressDown(triggerButton);
       triggerButtonUp = controller.GetPressUp(triggerButton);
      triggerButtonPressed = controller.GetPress(triggerButton);

	      if (gripButtonDown) {
			car.transform.Translate (-Vector3.forward * 30f * Time.deltaTime);
	      }
       if (gripButtonUp) {
          Debug.Log("Grip Button was just unpressed");
       }
      if (triggerButtonDown) {
			car.transform.Translate (Vector3.forward * 30f * Time.deltaTime);
       }
	       if (triggerButtonUp) {
	    }
	}
	}