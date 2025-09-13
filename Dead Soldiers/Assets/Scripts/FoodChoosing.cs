using UnityEngine;

public class FoodChoosing : MonoBehaviour
{
    [SerializeField] private GameObject ChooseFood;
    [SerializeField] private int foodIndex;
    public StartPuDo startPuDo;
    public PlateChoose plateChoose;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       plateChoose = ChooseFood.GetComponent<PlateChoose>();
       startPuDo = GameObject.Find("Sence2").GetComponent<StartPuDo>();
    }
    
    public void CloseWindow(){
        startPuDo.EnableALLplate();
        ChooseFood.SetActive(false);
    }
    public void OnMouseDown(){
        startPuDo.EnableALLplate();
        plateChoose.SetFood(foodIndex);
        ChooseFood.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
