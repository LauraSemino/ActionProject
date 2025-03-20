using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Collections.Generic;
using System.Linq;


namespace NodeCanvas.Tasks.Conditions {

	public class PreparedCT : ConditionTask {


        public BBParameter<List<string>> onPlate;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
			if(onPlate.value.Count() == 4)
			{
                if (onPlate.value.ElementAt(0) == "Bread" && onPlate.value.ElementAt(1) == "Meat" && onPlate.value.ElementAt(2) == "Cheese" && onPlate.value.ElementAt(3) == "Bread")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
	}
}