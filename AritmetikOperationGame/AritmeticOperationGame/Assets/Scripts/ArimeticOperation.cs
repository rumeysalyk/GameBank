using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ArimeticOperation : MonoBehaviour
{
    public TMP_Text m_firstInput, m_secondInput, m_operation, m_result, m_output;
    private int firstNumber, secondNumber, output, operationSign;

    void Start()
    {
        firstNumber = Random.Range( 1, 11 );
        secondNumber = Random.Range( 1, 10 );
        operationSign = Random.Range( 1, 5 );

        m_firstInput.text = firstNumber.ToString();
        m_secondInput.text = secondNumber.ToString();

        switch( operationSign )
        {
            case 1:
                m_operation.text = "+";
                output = firstNumber + secondNumber;
                break;
            case 2:
                m_operation.text = "-";
                output = firstNumber + secondNumber;
                break;
            case 3:
                m_operation.text = "*";
                output = firstNumber * secondNumber;
                break;
            case 4:
                m_operation.text = "/";
                
                while( secondNumber == 0 || firstNumber % secondNumber != 0 )
                {
                    firstNumber = Random.Range( 1, 11 );
                    secondNumber = Random.Range( 1, 10 );
                }
                output = firstNumber / secondNumber;
                break;
            default:
                Debug.Log( "Write down an applicable operation" );
                break;
        }
    }
    public void CheckAnswer()
    {
        string y = m_output.text;
        var x = int.Parse( y  );
        if( x  == output )
        {
            m_result.text = "TRUE";
        }
        else
        {
            m_result.text = "FALSE";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
