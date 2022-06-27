using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourCalculation : MonoBehaviour
{
    public UnityEngine.UI.Text FirstNumber, SecondNumber, Sign, Solving, Result;
    public UnityEngine.UI.InputField resultInput;
    int num1,num2,sign;
    double result;
    bool answer=true;
    // Start is called before the first frame update
    void Start()
    {
       NewQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CheckAnswer(){
        if(Solving.text==result+""){
           Result.text="True";
           answer=true;
        }
        else{
           Result.text="False"; 
           answer=false;  
        }
    }
    public void NewQuestion(){
        if(answer){
        Result.text= "";
        Solving.text="";
        resultInput.text="";
        num1 =Random.Range(1,999);
        num2 =Random.Range(1,999);
        sign =Random.Range(1,5);
        switch(sign){
            case 1:
             Sign.text = "-";
             result= num1-num2;
             break;
            case 2:
             Sign.text = "+";
             result= num1+num2;
             break;
            case 3:
             Sign.text = "*";
             result= num1*num2;
             break;
            case 4:
              Sign.text = "/";
              result= num1/num2;
              break;          
        }
        FirstNumber.text = num1 +"";
        SecondNumber.text = num2 + "";
    }
    else
    Result.text="Please enter the correct answer";
    }
}
