using UnityEngine;
using UnityEngine.UI;

public class ClickPuDo : MonoBehaviour
{
    [SerializeField] private GameObject ChooseFood;  
    [SerializeField] private Image foodImage;
    [SerializeField] private Sprite[] foodSprites;
    [SerializeField] private Image textImage;
    [SerializeField] private Sprite[] textSprites;
    public StartPuDo startPuDo;
    public BoxCollider2D boxCollider;
    public int foodIndex = 0;
    public int plateIndex = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChooseFood.SetActive(false); 
        boxCollider=GetComponent<BoxCollider2D>();
        startPuDo = GameObject.Find("Sence2").GetComponent<StartPuDo>();
    }

    void OnMouseDown(){
        ChooseFood.SetActive(true);
        ChooseFood.GetComponent<PlateChoose>().setplate(plateIndex);
        startPuDo.DisableALLplate();
    }
    public void SetFood(int index){
        if(index < 0 || index >= foodSprites.Length){
            return;
        }
        foodIndex = index;
        foodImage.color = new Color(1,1,1,1);
        foodImage.sprite = foodSprites[index];
        foodImage.SetNativeSize();
        textImage.sprite = textSprites[index];
        textImage.SetNativeSize();
    }
    void OnEnable(){
        foodImage.color = new Color(1,1,1,0);
        foodIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnablePlate(){
        boxCollider.enabled=true;
    }
    public void DisablePlate(){
        boxCollider.enabled=false;
    }
}
