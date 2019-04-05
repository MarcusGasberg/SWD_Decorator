namespace SWD_Decorator
{
    public interface IEquipment
    {
        T GetStat<T>() where T : IStat;
    }
}