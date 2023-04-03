public class Product
{
    //fields
    private int productId;
    private string productName;
    private double cost;
    private double tax;
    private int quantityInStock;
    public static int TotalNoOfProducts;
    public const string CategoryName = "Electronics";
    private readonly string dateOfPurchase;

    //constructor
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }

    //Method
    /*cost <= 20000 then tax = 10%
     * cost> 20000 then tax = 12.5%*/

    //the parameter for this method is an example of a default argument
    public void CalculateTax(in double percentage)
    {
        //percentage = 10.45;

        //create local variable
        double t;

        if (cost <= 20000)
        {
            t = cost * 10 / 100;
        }
        else
        {
            t = cost * percentage / 100;
        }

        tax = t;

    }

    //overloaded calculatetax method
    public void CalculateTax(double percentage, double cost) {

        double t;

        if (cost <= 50000)
        {
            t = cost * 5 / 100;
        }
        else
        {
            t = cost * percentage / 100;
        }

        tax = t;
    }

    //Set method for fields

    public void SetProductId(int value)
    {
        productId = value;
    }

    public void SetProductName(string value)
    {
        productName = value;
    }

    public void SetCost(double value) {
        cost = value;
    }

    public void SetTax(double value) {
        tax = value;
    }

    public void SetQuantityInStock(int value) {
        quantityInStock = value;
    }

    public static void SetTotalNoOfProducts(int value) {
        TotalNoOfProducts = value;
    }

    //Get method for fields

    public int GetProductId()
    {
        return productId;
    }

    public string GetProductName()
    {
        return productName;
    }

    public double GetCost() {
        return cost;
    }

    public double GetTax() {
        return tax;
    }

    public int GetQuantityInStock() {
        return quantityInStock;
    }

    public string GetDateOfPurchase() {
        return dateOfPurchase;
    }

    //getters and setters are instance methods for working with instance fields, for static fields you must use static methods.

    public static int GetTotalNoOfProducts() {
        return TotalNoOfProducts;
    }


    //creating method that calculates total quantity
    public static int GetTotalQuantity(Product product1, Product product2, Product product3) {
        int total = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
        return total;
    }

//this is a property we will learn about it later
    //public string ProductName { get; set; }

}