using System.Collections;
using System.Collections.Generic; //access to lists
using UnityEngine;
using UnityEngine.UI; //fpr serializefield
using System.Linq; // allows us to move everything from arrays to list
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Question[] questions; //array of questions
    private static List<Question> unusedQuestions; //remembers what its stored

    private Question currentQuestion;

    [SerializeField]
    private Text facttext;

    [SerializeField]
    private Text trueAnswertext;

    [SerializeField]
    private Text falseAnswertext;

    [SerializeField]
    private float timeBetweenQuestions = 1f;

    [SerializeField]
    private Animator animator;

    void Start() //when the game starts(scene reloads)
    {
        if (unusedQuestions ==null || unusedQuestions.Count ==0)
        {
            unusedQuestions = questions.ToList<Question>(); //sets list = to array
        }
        SetCurrentQuestion();

       

    }

    void SetCurrentQuestion() //uses random index to get random number in list (which is the question)
    {
        int randomQuestionIndex = Random.Range(0, unusedQuestions.Count);
        currentQuestion = unusedQuestions[randomQuestionIndex];

        facttext.text = currentQuestion.fact;

 /*       if (currentQuestion.isTrue)
        {
            trueAnswertext.text = "CORRECT";
            falseAnswertext.text = "WRONG";
        }
        else
        {
            trueAnswertext.text = "WRONG";
            falseAnswertext.text = "CORRECT";
        }

    */
    }

    IEnumerator TransitionToNextQuestion () // allows us to wait a few seconds
    {
        unusedQuestions.Remove(currentQuestion); //makes sure we dont choose same question twice

        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }






    public void UserSelectA()
    {
        animator.SetTrigger("True");
        if (currentQuestion.a == currentQuestion.correctAnswer)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Try Again!");
        }
        StartCoroutine(TransitionToNextQuestion());
    }
    public void UserSelectB()
    {
        animator.SetTrigger("True");
        if (currentQuestion.b == currentQuestion.correctAnswer)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Try Again!");
        }
        StartCoroutine(TransitionToNextQuestion());

    }
    public void UserSelectC()
    {
        animator.SetTrigger("True");
        if (currentQuestion.c == currentQuestion.correctAnswer)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Try Again!");
        }
        StartCoroutine(TransitionToNextQuestion());

    }
    public void UserSelectD()
    {
        animator.SetTrigger("True");
        if (currentQuestion.d == currentQuestion.correctAnswer)
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Try Again!");
        }
        StartCoroutine(TransitionToNextQuestion());

    }

}
