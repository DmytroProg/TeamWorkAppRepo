using NetworkApp5.Services;

//MyService.DoWork();
ProductService productService = new ProductService("products.json");
productService.Init();