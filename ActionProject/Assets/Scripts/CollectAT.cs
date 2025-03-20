using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class CollectAT : ActionTask {

        public BBParameter<string> ingredientName;
        public BBParameter<bool> retrieveIngredient;
        public BBParameter<bool> hasIngredient;

		public NavMeshAgent navAgent;
		public Vector3 destination;

		public Transform fridge;
		public Transform cupboard;
		//public Transform plate;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
            if (ingredientName.value == "Cheese")
            {
				destination = fridge.position;
                navAgent.SetDestination(destination);
            }
            if (ingredientName.value == "Meat")
            {
                destination = fridge.position;
                navAgent.SetDestination(destination);
            }
            if (ingredientName.value == "Bread")
            {
                destination = cupboard.position;
                navAgent.SetDestination(destination);
            }

            //EndAction(true);
        }

		//Called once per frame while the action is active.
		protected override void OnUpdate()
		{
			if (Vector3.Distance(destination, navAgent.transform.position) < 1)
			{
				hasIngredient.value = true;
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