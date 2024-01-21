using Visitor;

var nodes = new List<INode>();

nodes.Add(new City
{
    Name = "Budapest",
    Latitude = 47.497913,
    Longitude = 19.040236,
    Population = 1.756e6
});

nodes.Add(new City
{
    Name = "San Francisco",
    Latitude = 37.773972,
    Longitude = -122.431297,
    Population = 815201
});

nodes.Add(new Industry
{
    Name = "Microsoft",
    Sector = "Information technology",
    LocatedAt = "Redmont, Washington USA",
    NetWorth = 168_000_000_000
});

foreach (var node in nodes)
{
    node.Accept(new ExportToJsonVisitor());
    node.Accept(new ExportToXmlVisitor());
}