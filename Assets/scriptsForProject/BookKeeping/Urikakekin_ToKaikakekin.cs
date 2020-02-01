using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public abstract class Accounts_receivableandAccount_payable
{
    public List<Accounts_receivableandAccount_payable> Bookkeeping_Leftlist;
    public List<Accounts_receivableandAccount_payable> Bookkeeping_Rightlist;
    public string RightAccount;//貸方勘定科目
    public string LeftAccount;//借方勘定科目
    public int Left_Object_money;//借方金額
    public int Right_Object_money;//貸方金額
}




public class Urikakekin_ToKaikakekin : MonoBehaviour
{
    //仕入れと買掛金が増えた時
   //左仕入れ右買掛金
  public class Left_Purchase_Right_AccountPayable:Accounts_receivableandAccount_payable
    {
       
        Left_Purchase_Right_AccountPayable(int in_purchased, int in_account_payable)
        {
             Left_Object_money= in_purchased;
            Right_Object_money = in_account_payable;
        }
        

        void Add_LP_RAP(int in_purchased, int in_account_payable)
        {

            if (Bookkeeping_Leftlist.Count > 5)
            {
                Bookkeeping_Leftlist.Remove(Bookkeeping_Leftlist[0]);
                Bookkeeping_Leftlist.Add(new Left_Purchase_Right_AccountPayable(in_purchased, in_account_payable));
            }
            else
            {

                Bookkeeping_Leftlist.Add(new Left_Purchase_Right_AccountPayable(in_purchased, in_account_payable));
            }
        }
    }

    public class LeftAccountPayable_RightCash:Accounts_receivableandAccount_payable
    {
        LeftAccountPayable_RightCash(int in_AccountPa,int in_cash)
        {
            Left_Object_money = in_AccountPa;
            Right_Object_money = in_cash;
        }

        void Add_LAp_RC(int in_AccountPa, int in_cash)
        {
            if (Bookkeeping_Rightlist.Count > 5)
            {
                Bookkeeping_Rightlist.Remove(Bookkeeping_Rightlist[0]);
                Bookkeeping_Rightlist.Add(new LeftAccountPayable_RightCash(in_AccountPa, in_cash));
            }
            else
            {
                Bookkeeping_Rightlist.Add(new LeftAccountPayable_RightCash(in_AccountPa, in_cash));
            }
        }
    }
}
