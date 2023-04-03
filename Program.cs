class Sample {

    static void Main() {

        const string developerName = "Chris";

        //create reference variables
        Product product1, product2, product3;

        //create objects
        product1 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);//1
        product2 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);//2
        product3 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1);//3
        //this is a way to increment a static value

        //initialize fields
        product1.SetProductId(1001);
        product1.SetProductName("Mobile");
        product1.SetCost(20000);
        product1.SetQuantityInStock(1200);
        product2.SetProductId(1002);
        product2.SetProductName("Laptop");
        product2.SetCost(45000);
        product2.SetQuantityInStock(3400);
        product3.SetProductId(1003);
        product3.SetProductName("Speakers");
        product3.SetCost(36000);
        product3.SetQuantityInStock(800);

        //Call method


        double q = 9.2;
        product1.CalculateTax(percentage:in q);

        //creating the variable within the argument using the out declaration
        double p = 5.6;
        product2.CalculateTax(in p);
        Console.WriteLine("p is " + p);

        product3.CalculateTax(cost: 10000, percentage: 3.4);


        //Get values from field
        Console.WriteLine("Created by: " + developerName);

        Console.WriteLine("\nProduct 1:");
        Console.WriteLine("Product ID: " + product1.GetProductId());
        Console.WriteLine("Product Name: " + product1.GetProductName());
        Console.WriteLine("Product Cost: " + product1.GetCost());
        Console.WriteLine("Product Tax: " + product1.GetTax());
        Console.WriteLine("Product Quantity: " + product1.GetQuantityInStock());
        Console.WriteLine("Date of Purchase: " + product1.GetDateOfPurchase());

        Console.WriteLine("\nProduct 2:");
        Console.WriteLine("Product ID: " + product2.GetProductId());
        Console.WriteLine("Product Name: " + product2.GetProductName());
        Console.WriteLine("Product Cost: " + product2.GetCost());
        Console.WriteLine("Product Tax: " + product2.GetTax());
        Console.WriteLine("Product Quantity: " + product2.GetQuantityInStock());
        Console.WriteLine("Date of Purchase: " + product2.GetDateOfPurchase());

        Console.WriteLine("\nProduct 3:");
        Console.WriteLine("Product ID: " + product3.GetProductId());
        Console.WriteLine("Product Name: " + product3.GetProductName());
        Console.WriteLine("Product Cost: " + product3.GetCost());
        Console.WriteLine("Product Tax: " + product3.GetTax());
        Console.WriteLine("Product Quantity: " + product3.GetQuantityInStock());
        Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurchase());

        int totalQuantity = Product.GetTotalQuantity(product1, product2, product3);

        Console.WriteLine("\nTotal Quantity: " + totalQuantity);

        Console.WriteLine("\nTotal Number of Products: " + Product.GetTotalNoOfProducts());
        Console.WriteLine("\nCategory of Products: " + Product.CategoryName);

        System.Console.ReadKey();

    }

}