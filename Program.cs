class Sample {

    static void Main() {

        const string developerName = "Chris";

        //create reference variables
        Product product1, product2, product3;

        //create objects
        product1 = new Product();
        Product.TotalNoProducts++;
        product2 = new Product();
        Product.TotalNoProducts++;
        product3 = new Product();
        Product.TotalNoProducts++;

        //initialize fields
        product1.productId = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantitiyInStock = 1200;
        product2.productId = 1002;
        product2.productName = "Laptop";
        product2.cost = 45000;
        product2.quantitiyInStock = 3400;
        product3.productId = 1003;
        product3.productName = "Speakers";
        product3.cost = 36000;
        product3.quantitiyInStock = 800;

        //Call method

        product1.CalculateTax();
        product2.CalculateTax();
        product3.CalculateTax();


        //Get values from field
        Console.WriteLine("Created by: " + developerName);

        Console.WriteLine("\nProduct 1:");
        Console.WriteLine("Product ID: " + product1.productId);
        Console.WriteLine("Product Name: " + product1.productName);
        Console.WriteLine("Product Cost: " + product1.cost);
        Console.WriteLine("Product Tax: " + product1.tax);
        Console.WriteLine("Product Quantity: " + product1.quantitiyInStock);
        Console.WriteLine("Date of Purchase: " + product1.dateOfPurchase);

        Console.WriteLine("\nProduct 2:");
        Console.WriteLine("Product ID: " + product2.productId);
        Console.WriteLine("Product Name: " + product2.productName);
        Console.WriteLine("Product Cost: " + product2.cost);
        Console.WriteLine("Product Tax: " + product2.tax);
        Console.WriteLine("Product Quantity: " + product2.quantitiyInStock);
        Console.WriteLine("Date of Purchase: " + product2.dateOfPurchase);

        Console.WriteLine("\nProduct 3:");
        Console.WriteLine("Product ID: " + product3.productId);
        Console.WriteLine("Product Name: " + product3.productName);
        Console.WriteLine("Product Cost: " + product3.cost);
        Console.WriteLine("Product Tax: " + product3.tax);
        Console.WriteLine("Product Quantity: " + product3.quantitiyInStock);
        Console.WriteLine("Date of Purchase: " + product3.dateOfPurchase);

        int totalQuantity = product1.quantitiyInStock + product2.quantitiyInStock + product3.quantitiyInStock;

        Console.WriteLine("\nTotal Quantity: " + totalQuantity);

        Console.WriteLine("\nTotal Number of Products: " + Product.TotalNoProducts);
        Console.WriteLine("\nCategory of Products: " + Product.CategoryName);

        System.Console.ReadKey();

    }

}