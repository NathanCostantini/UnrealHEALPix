#include "UnrealHEALPix.h"
#include "Modules/ModuleManager.h"

IMPLEMENT_MODULE(FUnrealHEALPixModule, UnrealHEALPix)

void FUnrealHEALPixModule::StartupModule()
{
    UE_LOG(LogTemp, Warning, TEXT("UnrealHEALPix module started!"));
}

void FUnrealHEALPixModule::ShutdownModule()
{
    UE_LOG(LogTemp, Warning, TEXT("UnrealHEALPix module shutdown."));
}