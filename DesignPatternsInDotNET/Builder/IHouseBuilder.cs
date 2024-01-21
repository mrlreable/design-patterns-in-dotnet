namespace Builder;

public interface IHouseBuilder
{
    public IHouseBuilder AddWalls();
    public IHouseBuilder AddWindows();
    public IHouseBuilder AddRoof();
    public IHouseBuilder AddBackyard();
    public IHouseBuilder AddSwimmingPool();
}
