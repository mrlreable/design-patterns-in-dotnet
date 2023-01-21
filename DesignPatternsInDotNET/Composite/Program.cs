using Composite;

Box whole = new Box();

Box container1 = new Box();
Box container2 = new Box();

IComposite appleWatch = new Product("Apple watch", 79900);
IComposite iphone = new Product("IPhone 14 Pro", 450990);
IComposite airpods = new Product("Apple Airpods", 56900);

container1.AddChild(appleWatch);
container1.AddChild(iphone);
container1.AddChild(airpods);

IComposite xiaomi = new Product("Xiaomi Redmi Note Pro+", 159900);
IComposite earbuds = new Product("Huawei earbuds", 28990);

container2.AddChild(xiaomi);
container2.AddChild(earbuds);

container2.RemoveChild(earbuds);

whole.AddChild(container1);
whole.AddChild(container2);
whole.AddChild(new Receipt());

var totalPrice = whole.CalculateCost();


Console.WriteLine($"Total price for product: {totalPrice} HUF");