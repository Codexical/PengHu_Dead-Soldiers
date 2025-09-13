using UnityEngine;

public class Final : MonoBehaviour,TimerController
{
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Timer timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
 
    public void OnEnable(){
        timer.Show();
    } 
    public void BacktoHome(){
        gameManager.SenceChange(1);
    }
    public void Again(){
        gameManager.SenceChange(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TimeOut(){
        gameManager.SenceChange(1);
    }
}
