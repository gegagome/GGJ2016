using System;
using UnityEngine;

namespace UnityStandardAssets.Characters.ThirdPerson
{
    [RequireComponent(typeof (ThirdPersonCharacter))]
    public class ThirdPersonUserControl : MonoBehaviour
    {
        private ThirdPersonCharacter m_Character; // A reference to the ThirdPersonCharacter on the object
        private Transform m_Cam;                  // A reference to the main camera in the scenes transform
        private Vector3 m_CamForward;             // The current forward direction of the camera
        private Vector3 m_Move;
        private bool m_Jump;                      // the world-relative desired move direction, calculated from the camForward and user input.
		public DPadButtons dPadScript1;
        
        private void Start()
        {
            // get the transform of the main camera
            if (Camera.main != null)
            {
                m_Cam = Camera.main.transform;
            }
            else
            {
                Debug.LogWarning(
                    "Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.");
                // we use self-relative controls in this case, which probably isn't what the user wants, but hey, we warned them!
            }

            // get the third person character ( this should never be null due to require component )
            m_Character = GetComponent<ThirdPersonCharacter>();
        }


		private void Update()
		{
			if (!m_Jump)
			{
				m_Jump = Input.GetButtonDown("Jump");
			}
			if (dPadScript1.UpPressed ()) {
				m_Character.MoveUp ();
			}
			else if (dPadScript1.DownPressed())
			{
				m_Character.MoveDown();
			}
		}


		// Fixed update is called in sync with physics
		private void FixedUpdate()
		{
			// read inputs
			//float h = Input.GetAxis("Horizontal");
			//float v = Input.GetAxis("Vertical");
			bool crouch = Input.GetKey(KeyCode.C);

            // calculate move direction to pass to character
            /* if (m_Cam != null)
             {
                 // calculate camera relative direction to move:
                 m_CamForward = Vector3.Scale(m_Cam.right, new Vector3(1, 0, 0)).normalized;
                 m_Move = h*m_Cam.right;
                 Debug.Log("ideaaaaaaaaally never gets hit");
             }*/
            //Debug.Log(m_Move);
            
            {
                // we use world-relative directions in the case of no main camera
                //Debug.Log("Vec3.right " + Vector3.right);
                float h = 1;
                //m_Move = h*Vector3.right;
            }
#if !MOBILE_INPUT
            //Debug.Log("MOVE: " + m_Move);
			// walk speed multiplier
	        if (Input.GetKey(KeyCode.LeftShift)) m_Move *= 0.5f;
#endif
            // pass all parameters to the character control script
            m_Character.Move(m_Move, crouch, m_Jump);
            m_Jump = false;
        }
    }
}
