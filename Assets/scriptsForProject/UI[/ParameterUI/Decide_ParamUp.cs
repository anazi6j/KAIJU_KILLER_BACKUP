using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace robot
{

    public class Decide_ParamUp : MonoBehaviour
    {
        public DoeffectBase[] doeffectBases;
        Parametar_Cameracontroll paramcam;
        public GameObject Bar;
        public float delta;
        public float Gauge_MAX;
        private void Start()
        {
            paramcam = GetComponent<Parametar_Cameracontroll>();
           
            for (int j = 0; j < doeffectBases.Length; j++)
            {
                doeffectBases[j].GetComponent<DoeffectBase>();
            }
            
        }

        private void Update()
        {
            
           
            Bar_controll();
        }

        void Bar_controll()
        {
            Bar.GetComponent<Image>().fillAmount = delta /Gauge_MAX;

            if (paramcam.inputhandler.maru_pressed)
            {
                delta += Time.deltaTime;
            }
            else { delta = 0f; }
           if(Bar.GetComponent<Image>().fillAmount ==1)
            {
                doeffectBases[paramcam.selectedNum_Item].GetComponent<DoeffectBase>().DoEffect();
                delta = 0f;
            }
          
            
          
        }

        

    }

}