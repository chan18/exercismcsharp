using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        //a fast attack can be made if the knight is sleepin
        if(knightIsAwake) {
            return false;
        }

        return true;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        // no one is awake 
        if (!knightIsAwake  && 
            !prisonerIsAwake &&
            !archerIsAwake ) {
            return false;
        }

        // every one is awake
        if (knightIsAwake  && 
            prisonerIsAwake &&
            archerIsAwake ) {
            return true;
        }

        // if anyone of them is awake
        if(knightIsAwake  || 
           prisonerIsAwake ||
           archerIsAwake  ) {
            return true;
        }
        
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(archerIsAwake == false && prisonerIsAwake == true) {
            return true;
        }

        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(knightIsAwake &&
            archerIsAwake &&
            prisonerIsAwake) {
             return false;
        } 

        if(petDogIsPresent) {
             if (archerIsAwake) {
                  return false;
             }           
        } else if (prisonerIsAwake) {        
            if (!knightIsAwake && !archerIsAwake) {
                return true;                    
            }  else {
                return false;
            }      
        } else {
             return false;
        }

        return true;
    }
}
