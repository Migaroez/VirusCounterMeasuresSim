namespace Assets.Code.Services
{
    public interface ISimulationService
    {
        int SimSpeed { get; set; }
        bool SimIsPaused { get; set; }
    }
}