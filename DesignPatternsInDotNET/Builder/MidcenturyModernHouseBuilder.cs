namespace Builder;

public class MidcenturyModernHouseBuilder : IHouseBuilder
{
    private MidcenturyModernHouse _house;

    public MidcenturyModernHouseBuilder()
    {
        _house = new MidcenturyModernHouse();
    }

    public IHouseBuilder AddBackyard()
    {
        throw new NotImplementedException();
    }

    public IHouseBuilder AddRoof()
    {
        throw new NotImplementedException();
    }

    public IHouseBuilder AddSwimmingPool()
    {
        throw new NotImplementedException();
    }

    public IHouseBuilder AddWalls()
    {
        throw new NotImplementedException();
    }

    public IHouseBuilder AddWindows()
    {
        throw new NotImplementedException();
    }

    public MidcenturyModernHouse Build()
    {
        return _house;
    }
}
