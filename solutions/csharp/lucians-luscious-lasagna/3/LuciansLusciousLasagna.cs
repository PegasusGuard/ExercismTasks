class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int timeElapsed) => this.ExpectedMinutesInOven() - timeElapsed;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layerCount) => 2 * layerCount;
    
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layerCount, int timeInOven) => timeInOven + 2 * layerCount;
}
