class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    static int ExpectedMinutesInOven()
    {
        return 40;
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    static int RemainingMinutesInOven(int actualMins)
    {
        int expectedMins = ExpectedMinutesInOven();
        return expectedMins - actualMins;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    static int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }
        
    // TODO: define the 'ElapsedTimeInMinutes()' method
    static int ElapsedTimeInMinutes(int layers, int actual)
    {
        int prepTime = PreparationTimeInMinutes(layers);
        return prepTime + actual;
    }
}
