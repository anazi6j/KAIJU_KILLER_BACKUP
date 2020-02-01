using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace EquipmentManager {
    public class Select_Equipment : MonoBehaviour
    {
        public Transform[] parts;
       public EquipmentIDmanager equipmentIDmanager;
        public Read_EquipmentFile Read_EquipmentFile;
        public Equipment currentequipment;
        private void Update()
        {
            Camera.main.transform.position = new Vector3(Vector3.Lerp(Camera.main.transform.position, Getpartspos(), Time.deltaTime).x, Vector3.Lerp(Camera.main.transform.position, Getpartspos(), Time.deltaTime).y, 300f);

          

            currentequipment = GetEquipment();
            

        }

        Vector3 Getpartspos()
        {
            switch (equipmentIDmanager.partpointer)
            {
                case Part.HEAD:

                    return parts[0].position;



                case Part.RIGHTARM:

                    return parts[1].position;


                case Part.LEFTARM:
                    return parts[2].position;

                case Part.BODY:

                    return parts[3].position;

                case Part.LEG:

                    return parts[4].position;

                case Part.SAVE:
                    return parts[5].position;
            }

            return parts[0].position;
        }

        Equipment GetEquipment()
        {
            Equipment Temp_out =null;


            switch (equipmentIDmanager.partpointer)
            {
                case Part.HEAD:

                    return Read_EquipmentFile.ES.headlist[equipmentIDmanager.Head_pointer];



                case Part.RIGHTARM:

                    return Read_EquipmentFile.ES.rightarmlist[equipmentIDmanager.RightArm_pointer];


                case Part.LEFTARM:
                    return Read_EquipmentFile.ES.leftarmlist[equipmentIDmanager.LeftArm_pointer];

                case Part.BODY:

                    return Read_EquipmentFile.ES.bodylist[equipmentIDmanager.Body_pointer];

                case Part.LEG:

                    return Read_EquipmentFile.ES.leglist[equipmentIDmanager.Leg_pointer];

                   

                 

            }


            return Temp_out;
        }
    }
}
