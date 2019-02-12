using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInt : Interactable {

    public BattleController bc;
    public int hit;

      private void Update()
      {
          Interact();
      }

      override public void Interact()
      {
      //    Debug.Log(trigger);

          if (trigger)
          {
              bc.hit = this.hit;
            //hitvalue = this.hit;
          }
      }
      


    


}
