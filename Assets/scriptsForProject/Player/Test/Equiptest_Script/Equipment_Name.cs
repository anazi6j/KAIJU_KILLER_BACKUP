using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace EquipmentManager
{
    //Gameobject Equipmentmanagerにアタッチする
    public class Equipment_Name : MonoBehaviour
    {
        public Text head;
        public Text RightArm;
        public Text LeftArm;
        public Text body;
        public Text Leg;
        public Read_EquipmentFile Read_EquipmentFile;
        public EquipmentIDmanager EquipmentIDmanager;
        

        // Start is called before the first frame update
        void Start()
        {
            Read_EquipmentFile = GetComponentInParent<Read_EquipmentFile>();
            EquipmentIDmanager = GameObject.Find("Equipmentmanager").GetComponent<EquipmentIDmanager>();
        }

        // Update is called once per frame
        void Update()
        {
            head.text ="頭："+ Read_EquipmentFile.ES.headlist[EquipmentIDmanager.Head_pointer].ToString();
            RightArm.text ="右腕:"+ Read_EquipmentFile.ES.rightarmlist[EquipmentIDmanager.RightArm_pointer].ToString();
            LeftArm.text ="左腕:"+ Read_EquipmentFile.ES.leftarmlist[EquipmentIDmanager.LeftArm_pointer].ToString();
            body.text = "胴体:"+Read_EquipmentFile.ES.bodylist[EquipmentIDmanager.Body_pointer].ToString();
            Leg.text = "足:"+Read_EquipmentFile.ES.leglist[EquipmentIDmanager.Leg_pointer].ToString();
        }
    }
}