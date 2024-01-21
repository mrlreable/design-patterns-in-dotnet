using Builder;


// In this example the director is the client
// If we don't want to let the client control the building process
// Delegate the building to a Director class that has a reference to an IHouseBuilder
// The client only sets the type of builder when creating the Director
// And then, the client only gets the product from a single method call

var builder = new MidcenturyModernHouseBuilder();
    
builder
    .AddWalls()
    .AddWindows()
    .AddRoof()
    .AddSwimmingPool();

var house = builder.Build();