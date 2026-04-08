#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "EIKHelpers.generated.h"

UCLASS()
class DRONEMULTIPLAYER_API UEIKHelpers : public UBlueprintFunctionLibrary
{
    GENERATED_BODY()

public:
    // Expose to Blueprint
    UFUNCTION(BlueprintCallable, Category="EIK|Networking")
    static void TravelToEIKSession(APlayerController* PlayerController, const FString& ConnectString);
};