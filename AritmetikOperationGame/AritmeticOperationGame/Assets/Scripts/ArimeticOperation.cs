using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ArimeticOperation : MonoBehaviour
{
    public TMP_Text m_firstInput, m_secondInput, m_operation, m_result;
    public TMP_InputField m_output;
    private int firstNumber, secondNumber, output, operationSign;
    public Button m_newQuestionButton;
    public Image m_arrowImage;

    void Start()
    {
        NewQuestion();
    }


    public void CheckAnswer()
    {
        int result = System.Convert.ToInt32( m_output.text );
        if( result  == output )
        {
            m_result.text = "TRUE";
        }
        else
        {
            m_result.text = "FALSE";
        }
        m_newQuestionButton.gameObject.SetActive( true );
        m_arrowImage.gameObject.SetActive( true );
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewQuestion()
    {
        m_result.text = "";
        m_output.text = "";
        m_newQuestionButton.gameObject.SetActive( false );
        m_arrowImage.gameObject.SetActive( false );

        firstNumber = Random.Range( 1, 11 );
        secondNumber = Random.Range( 1, 10 );
        operationSign = Random.Range( 1, 5 );


        switch( operationSign )
        {
            case 1:
                m_operation.text = "+";
                output = firstNumber + secondNumber;
                break;
            case 2:
                m_operation.text = "-";
                output = firstNumber - secondNumber;
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

        m_firstInput.text = firstNumber.ToString();
        m_secondInput.text = secondNumber.ToString();

    }
}
