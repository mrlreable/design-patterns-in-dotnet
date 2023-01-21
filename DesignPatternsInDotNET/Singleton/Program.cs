using Singleton;

Simulator simulator1 = Simulator.Instance;

simulator1.Initialize();
simulator1.Simulate();


Simulator simulator2 = Simulator.Instance;

simulator2.Initialize();
simulator2.Simulate();
