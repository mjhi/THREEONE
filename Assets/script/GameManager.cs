using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int Order;
    public Text OrderShow;
    public Text Num;
    public int num1=0;
    // Start is called before the first frame update
    void Start()
    {
        Order = 1;
        if(Order==0){
            OrderShow.text="당신의 차례입니다.";
        }
        else if(Order==1){
            OrderShow.text="컴퓨터가 고르고있습니다...";
            Invoke("BotJudgment",2);
        }
        Debug.Log(Order);
    }

    // Update is called once per frame
    void Update()
    {
        if(num1>31){
            OrderShow.text="당신이 졌습니다.";
             SceneManager.LoadScene("ReGame");
        }
    }
 
    public void BotJudgment()
    {
        if(num1==2 || num1==6 || num1==10 || num1==14 || num1==18 || num1==22 || num1==26 || num1==30)
        {
            num1+=1;
            Num.text=num1.ToString();
        }
        else if(num1<2){
            num1+=2-num1;
            Num.text=num1.ToString();
            
            
        }
        else if(num1<6){
            num1+=6-num1;
            Num.text=num1.ToString();
            
            
        }
        else if(num1<10){
            num1+=10-num1;
            Num.text=num1.ToString();
            
            
        }
        else if(num1<14){
            num1+=14-num1;
            Num.text=num1.ToString();
            
            
        }
        else if(num1<18){
            num1+=18-num1;
            Num.text=num1.ToString();
            
            
        }
        else if(num1<22){
            num1+=22-num1;
            Num.text=num1.ToString();
            
            
        }
        else if(num1<26){
            num1+=26-num1;
            Num.text=num1.ToString();
            
            
        }
        else if(num1<30){
            num1+=30-num1;
            Num.text=num1.ToString();
            
            
        }
        Order=0;
        OrderShow.text="당신의 차례입니다.";
    }

    public void BtnOne()
    {
        if(Order==0)
        {
            num1+=1;
            Debug.Log(num1);
            string tt=num1.ToString();
            Num.text=tt;
            Order=1;            
            OrderShow.text="컴퓨터가 고르고있습니다...";
            Invoke("BotJudgment",2);
        }
        
    }
    public void BtnTwo()
    {
        if(Order==0)
        {
            num1+=2;
            string tt=num1.ToString();
            Num.text=tt;
            Order=1;
            OrderShow.text="컴퓨터가 고르고있습니다...";
            Invoke("BotJudgment",2);
        }
        
    }
    public void BtnThree()
    {
        if(Order==0)
        {
            num1+=3;
            string tt=num1.ToString();
            Num.text=tt;
            Order=1;          
            OrderShow.text="컴퓨터가 고르고있습니다...";
            Invoke("BotJudgment",2);
        }
        
    }

}
