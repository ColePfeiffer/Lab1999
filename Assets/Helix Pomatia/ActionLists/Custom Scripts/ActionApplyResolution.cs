/*
 *
 *	Adventure Creator
 *	by Chris Burton, 2013-2016
 *	
 *	"ActionTemplate.cs"
 * 
 *	This is a blank action template.
 * 
 */

using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace AC
{

	[System.Serializable]
	public class ActionApplyResolution : Action
	{
		
		// Declare variables here
		
		
		public ActionApplyResolution ()
		{
			this.isDisplayed = true;
			category = ActionCategory.Custom;
			title = "Engine: Apply Resolution";
			description = "This is a blank Action template.";
		}
		
		
		override public float Run ()
		{
			int resolutionSetting = GlobalVariables.GetIntegerValue (1);
			
			if (resolutionSetting ==0){
				//Set to 1280x720
				Screen.SetResolution (1280, 720, true);
			}
		
			if (resolutionSetting ==0){
				//Set to  996x560 
				Screen.SetResolution (996, 560, true);
			}
		
			if (resolutionSetting ==0){
				//Set to 1636x920
				Screen.SetResolution (1636, 920, true);
			}
			
		AC.KickStarter.playerMenus.RecalculateAll ();

		return 0f;
		}
		
		
		#if UNITY_EDITOR

		override public void ShowGUI ()
		{
			// Action-specific Inspector GUI code here
			
			AfterRunningOption ();
		}
		

		public override string SetLabel ()
		{
			// Return a string used to describe the specific action's job.
			
			string labelAdd = "";
			return labelAdd;
		}

		#endif
		
	}

}