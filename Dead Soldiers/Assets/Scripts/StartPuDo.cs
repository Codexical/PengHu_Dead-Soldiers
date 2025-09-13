using UnityEngine;

public class StartPuDo : MonoBehaviour, TimerController
{
    [SerializeField] private ClickPuDo[] clickPuDos;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private Timer timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void OnEnable()
    {
        timer.Show();
    }
    /*
    A類：生魚、哇沙米、紅酒、吐司麵包、餅乾、香菸＋打火機、牛肉
    B類：蘋果、香蕉、神豬、泡麵、雞蛋、醬油、米酒、汽水、啤酒、麵羊、草鞋、瓜子、金紙、糖果、醋、味素、白糖
    */
    int A,B,total; 
    public void FinalCount(){
        timer.Hide();
        A=0;B=0;total=0;
        foreach (var item in clickPuDos)
        {
            if (item.foodIndex==1 || item.foodIndex==5 || item.foodIndex==7  || item.foodIndex==13  || item.foodIndex==10 || item.foodIndex==9 || item.foodIndex==25) A++;
            else if (item.foodIndex!=0) B++;
        }
        total=A+B;
        Debug.Log("A類: "+A+" B類: "+B+" 總共: "+total);
        if(total>=12 && A>0 && B>0) gameManager.SenceChange(3);
        else gameManager.SenceChange(4);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void TimeOut(){
        gameManager.SenceChange(1);
    }
    public void DisableALLplate(){
        foreach (var item in clickPuDos)
        {
            item.DisablePlate();
        }
    }
    public void EnableALLplate(){
        foreach (var item in clickPuDos)
        {
            item.EnablePlate();
        }
    }
}
