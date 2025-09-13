using UnityEngine;

public class FoodChoosing : MonoBehaviour
{
    [SerializeField] private GameObject ChooseFood;
    [SerializeField] private ClickPuDo[] clickPuDos;
    [SerializeField] private int foodIndex;
    private int plateIndex;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }
    public void setplate(int index){
        plateIndex=index;
        Debug.Log("Set plate to "+plateIndex);
    }
    public void CloseWindow(){
        ChooseFood.SetActive(false);
    }
    public void OnMouseDown(){
        Debug.Log("Choose food "+foodIndex+" for plate "+plateIndex);
        clickPuDos[plateIndex].SetFood(foodIndex);
        ChooseFood.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
