using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace NodeCanvas.Tasks.Actions {

    public class WaitAT : ActionTask {

        //public BBParameter<bool> hasIngredient;
        public BBParameter<string> ingredientName;
        public BBParameter<bool> retrieveIngredient;

        public BBParameter<List<string>> onPlate;
        public TextMeshPro[] plate;
        

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			//EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			if(Input.GetKeyDown(KeyCode.C))
			{
				retrieveIngredient.value = true;
				ingredientName.value = "Cheese";
				EndAction(true);
			}
            if (Input.GetKeyDown(KeyCode.B))
            {
                retrieveIngredient.value = true;
                ingredientName.value = "Bread";
                EndAction(true);
            }
            if (Input.GetKeyDown(KeyCode.M))
            {
                retrieveIngredient.value = true;
                ingredientName.value = "Meat";
                EndAction(true);
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
				
                for (int i = 0; i < onPlate.value.Count(); i++)
                {
                    plate[i].text = "None";
                }
                onPlate.value.Clear();
                EndAction(true);
            }

            for (int i = 0; i < onPlate.value.Count(); i++)
            {
                plate[i].text = onPlate.value.ElementAt(i);
            }
           
			
        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}