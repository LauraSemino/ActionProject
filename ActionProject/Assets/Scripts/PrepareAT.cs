using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions {

	public class PrepareAT : ActionTask {

        public BBParameter<string> ingredientName;
        public BBParameter<bool> retrieveIngredient;
        public BBParameter<bool> hasIngredient;
        public BBParameter<List<string>> onPlate;

        public Transform plate;
        public NavMeshAgent navAgent;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
          
            navAgent.SetDestination(plate.position);
            
            //EndAction(true);
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
            if (Vector3.Distance(plate.position, navAgent.transform.position) < 2)
            {

                onPlate.value.Add(ingredientName.value);
                hasIngredient.value = false;
                ingredientName.value = "None";
                retrieveIngredient.value = false;
                EndAction(true);
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