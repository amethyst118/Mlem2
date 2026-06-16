using UnityEngine;

public class SidePanelController : MonoBehaviour
{
    public enum SidePanelState                                  //definiuje wszystkie stany SidePanel
    {
        Minimized,
        MaximizedA,
        MaximizedB,
        MaximizedC
    }

    public Animator animatorRef;
    public SidePanelState currentSidePanelState = SidePanelState.Minimized;     //ustawia początkowy stan SidePanel jako minimized

    public void OnSidePanelButtonClickA()                       //kiedy przycisk A jest kliknięty to zostaje ust. stan A, animator ustawiony na IsMaximizedA i inne panele się wyłączają
    {
        HandlePanelClick
        (
            SidePanelState.MaximizedA,
            "IsMaximizedA",
            "IsMaximizedB",
            "IsMaximizedC"
        );
    }

    public void OnSidePanelButtonClickB()                       //kiedy przycisk B jest kliknięty to zostaje ust. stan B, animator ustawiony na IsMaximizedB i inne panele się wyłączają
    {
        HandlePanelClick
        (
            SidePanelState.MaximizedB,
            "IsMaximizedB",
            "IsMaximizedA",
            "IsMaximizedC"
        );
    }

    public void OnSidePanelButtonClickC()                     //kiedy przycisk C jest kliknięty to zostaje ust. stan C, animator ustawiony na IsMaximizedC i inne panele się wyłączają
    {
        HandlePanelClick
        (
            SidePanelState.MaximizedC,
            "IsMaximizedC",
            "IsMaximizedA",
            "IsMaximizedB"
        );
    }

    private void HandlePanelClick(SidePanelState targetState, string selected, string otherA, string otherB)
    {
        switch (currentSidePanelState)                       //w zależności od otwartego panelu wykonuje się inna funkcja
        {
            case SidePanelState.Minimized:                   // w tym wypadku jeśli panel jest zamknięty to otwiera się wybrany przez nas panel i jest update animatora i stanu
                animatorRef.SetBool(selected, true);
                currentSidePanelState = targetState;
                break;

            case SidePanelState.MaximizedA:
            case SidePanelState.MaximizedB:
            case SidePanelState.MaximizedC:                 //tu jest wypadek kiedy jakikolwiek panel jest otwarty
                if (currentSidePanelState == targetState)   //tu jeśli klika się otwarty panel do zamknięcia
                {
                    animatorRef.SetBool(selected, false);
                    currentSidePanelState = SidePanelState.Minimized;
                }
                else                                        //tu jeśli inny panel jest otwarty to zamyka się poprzedni i otwiera się wybrany inny panel
                {
                    animatorRef.SetBool(otherA, false);
                    animatorRef.SetBool(otherB, false);
                    animatorRef.SetBool(selected, true);
                    currentSidePanelState = targetState;
                }
                break;
        }
    }
}