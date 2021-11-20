using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTip : MonoBehaviour
{
    
    private string message = 
    "<유인원의 피눈물>\n 종강을 앞둔 대학생은 모두\n 만들어 낼 수 있는 것으로 추정됨. \n------\n <기묘한 깃털>\n 과제를 하다 지친 대학생들이 \n결국 뽑아버린 머리털들. \n------\n <빛나는 버섯>\n 소원을 이뤄준다는 전설이 있는 귀한 재료. \n------\n<유혹의 사탕>\n 모든 과제를 잊고 편안한 잠을 잘 수 있도록 도와주는 흔한 재료.\n\n **이 중 3개를 골라 솥에 넣고 \n지팡이를 휘둘러라.**" ;

    private void OnMouseEnter()
    {
        TooltipManager._instance.SetAndShowToolTip(message);
        
    }

    private void OnMouseExit()
    {
        TooltipManager._instance.HideToolTip();
    }
}
