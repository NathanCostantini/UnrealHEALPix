#pragma once

#include "Modules/ModuleManager.h"

class FUnrealHEALPixModule : public IModuleInterface
{
public:
    virtual void StartupModule() override;
    virtual void ShutdownModule() override;
};