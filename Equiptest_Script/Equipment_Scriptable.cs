using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EquipmentManager {
    [CreateAssetMenu(menuName = "PlayerMenu/EquipmentScriptable")]
    [System.Serializable]
    public class Equipment_Scriptable :ScriptableObject
    {
        public AttackTypeAnimation type; 
        public List<Head> headlist;
        public List<Right_arm> rightarmlist;
        public List<Left_arm> leftarmlist;
        public List<Body> bodylist;
        public List<Leg> leglist;
        //public List<Weapon> weaponlist;
    }



}