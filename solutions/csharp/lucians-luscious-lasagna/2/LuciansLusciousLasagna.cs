class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;


    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int timeElapsed)
    {
        return this.ExpectedMinutesInOven() - timeElapsed;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layerCount)
    {
        return 2 * layerCount;
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layerCount, int timeInOven)
    {
        return timeInOven + 2 * layerCount;
    }
}
