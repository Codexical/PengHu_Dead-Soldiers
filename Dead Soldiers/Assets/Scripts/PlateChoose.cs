using UnityEngine;

public class PlateChoose : MonoBehaviour
{
    [SerializeField] private ClickPuDo[] clickPuDos;
    [SerializeField] private Timer timer;
    private int plateIndex;
    
    // Start is called once before the first e
    // xecution of Update after the MonoBehaviour is created
    public void setplate(int index){
        plateIndex=index;
        timer.Show();
    }
    void Start()
    {
        timer.Show();
        
    }
    public void SetFood(int foodIndex){
        clickPuDos[plateIndex].SetFood(foodIndex);
        timer.Show();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
