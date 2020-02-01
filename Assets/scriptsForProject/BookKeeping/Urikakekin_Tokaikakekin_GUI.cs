using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Urikakekin_Tokaikakekin_GUI : MonoBehaviour
{
    public Accounts_receivableandAccount_payable m_accounts;
    Vector3 offset;
   

    public  AccountGUI m_gui;
    public Accounts_receivableandAccount_payable m_AR_AP;
    void Init_LeftAccountsGUI()
    {
        //5つの履歴を表示する
        for(int i=0;i<5;i++)
        {
            m_gui.LeftObject_GUI[i].GetComponentInChildren<Text>().text = m_AR_AP.Bookkeeping_Leftlist[i].LeftAccount;
            m_gui.LeftObject_money[i].GetComponentInChildren<Text>().text = m_AR_AP.Bookkeeping_Rightlist[i].Left_Object_money.ToString();
        }
    }

    void Init_RightAccountsGUI()
    {
        for (int i = 0; i < 5; i++) {
            m_gui.Right_Object_GUI[i].GetComponentInChildren<Text>().text = m_AR_AP.Bookkeeping_Rightlist[i].RightAccount;
            m_gui.Right_Object_Money[i].GetComponentInChildren<Text>().text = m_AR_AP.Bookkeeping_Leftlist[i].Right_Object_money.ToString();
    }
                }


}
