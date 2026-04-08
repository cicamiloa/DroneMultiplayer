#include "EIKHelpers.h"
#include "GameFramework/PlayerController.h"

void UEIKHelpers::TravelToEIKSession(APlayerController* PlayerController, const FString& ConnectString)
{
    if (!PlayerController)
    {
        UE_LOG(LogTemp, Warning, TEXT("TravelToEIKSession: PlayerController is null"));
        return;
    }

    // Absolute travel for EOS P2P NetDriver
    PlayerController->ClientTravel(ConnectString, ETravelType::TRAVEL_Absolute);
}