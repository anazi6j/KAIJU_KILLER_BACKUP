using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace robot
{
    public class ParameterUpTextManager : MonoBehaviour
    {
        public Text Name;
        public Text Item_Description;
        public GameObject[] item;
        int selected;

        

        // Update is called once per frame
        void Update()
        {
            selected = Camera.main.GetComponent<Parametar_Cameracontroll>().selectedNum_Item;
            Name.text = item[selected].GetComponent<ItemiconInfo>().ItemName;
            Item_Description.text = item[selected].GetComponent<ItemiconInfo>().Description;
        }
    }
}
