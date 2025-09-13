using UnityEngine;

public class Final : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
}
