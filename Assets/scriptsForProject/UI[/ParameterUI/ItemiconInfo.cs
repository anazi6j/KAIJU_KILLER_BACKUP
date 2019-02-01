using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace robot
{
    public class ItemiconInfo : MonoBehaviour
    {
        //最終的にはXMLからアイテム名、説明を読み込めるようにする
        public string ItemName;
        [Multiline]
        public string Description;

        GameObject Text;
        // Start is called before the first frame update
        void Start()
        {
            Text = GameObject.Find("ParameterUpText_Manager");
            
        }

        // Update is called once per frame
        void Update()
        {
           
        }

        
    }

   

}