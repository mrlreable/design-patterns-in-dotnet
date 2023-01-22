using Observer;

Store store = new Store();

store.Subscribe(new Customer());
store.Subscribe(new Customer());
store.Subscribe(new Customer());
store.Subscribe(new Customer());

store.ProductPrice = 10000;
store.ProductPrice = 7812;
store.ProductPrice = 78112;
store.ProductPrice = 782;