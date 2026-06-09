using System.Linq;
using UnityEngine;

public class SidePanelController : MonoBehaviour
{
    public enum SidePanelState
    {
        Minimized,
        MaximizedA,
        MaximizedB,
        MaximizedC
    }

    public Animator animatorRef;

    public SidePanelState currentSidePanelState = SidePanelState.Minimized;

    void Start()
    {

    }

    public void OnSidePanelButtonClickA()
    {
        if (currentSidePanelState == SidePanelState.MaximizedA){
            animatorRef.SetBool("IsMaximizedA", false);
            currentSidePanelState = SidePanelState.Minimized;
        }
        else if(currentSidePanelState == SidePanelState.Minimized)
        {
            animatorRef.SetBool("IsMaximizedA", true);
            currentSidePanelState = SidePanelState.MaximizedA;
        }
        else if (currentSidePanelState == SidePanelState.MaximizedB)
        {
            animatorRef.SetBool("IsMaximizedB", false);
            animatorRef.SetBool("IsMaximizedA", true);
            currentSidePanelState = SidePanelState.MaximizedA;
        }
        else
        {
            animatorRef.SetBool("IsMaximizedC", false);
            animatorRef.SetBool("IsMaximizedA", true);
            currentSidePanelState = SidePanelState.MaximizedA;
        }
    
    }
    public void OnSidePanelButtonClickB()
    {
       if (currentSidePanelState == SidePanelState.MaximizedB){
            animatorRef.SetBool("IsMaximizedB", false);
            currentSidePanelState = SidePanelState.Minimized;
       }
        else if(currentSidePanelState == SidePanelState.Minimized)
        {
            animatorRef.SetBool("IsMaximizedB", true);
            currentSidePanelState = SidePanelState.MaximizedB;
        }
        else if (currentSidePanelState == SidePanelState.MaximizedA)
        {
            animatorRef.SetBool("IsMaximizedA", false);
            animatorRef.SetBool("IsMaximizedB", true);
            currentSidePanelState = SidePanelState.MaximizedB;
        }
        else
        {
            animatorRef.SetBool("IsMaximizedC", false);
            animatorRef.SetBool("IsMaximizedB", true);
            currentSidePanelState = SidePanelState.MaximizedB;
        }
    }
    public void OnSidePanelButtonClickC()
    {
      if (currentSidePanelState == SidePanelState.MaximizedC){
            animatorRef.SetBool("IsMaximizedC", false);
            currentSidePanelState = SidePanelState.Minimized;
    }
        else if(currentSidePanelState == SidePanelState.Minimized)
        {
            animatorRef.SetBool("IsMaximizedC", true);
            currentSidePanelState = SidePanelState.MaximizedC;
        }
        else if (currentSidePanelState == SidePanelState.MaximizedB)
        {
            animatorRef.SetBool("IsMaximizedB", false);
            animatorRef.SetBool("IsMaximizedC", true);
            currentSidePanelState = SidePanelState.MaximizedC;
        }
        else
        {
            animatorRef.SetBool("IsMaximizedA", false);
            animatorRef.SetBool("IsMaximizedC", true);
            currentSidePanelState = SidePanelState.MaximizedC;
        }
    }

}
