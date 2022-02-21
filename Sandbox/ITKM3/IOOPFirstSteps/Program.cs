using System;

class Car
{
    public string brand;
    public string model;
    public string color;
}
class Program
{
    static void Main()
    {
        Car[] car = new Car[]
        {
            new Car
            {
                brand = "Audi",
                model = "X1",
                color = "turunjav"
            },
            new Car
            {
                brand = "asd",
                model = "dsa",
                color = "dsa"
            },
            new Car
            {
                brand = "jgf",
                model = "hgf",
                color = "hgf"
            }
        };




        Car car1 = new Car();
        Car car2 = new Car();
        Car car3 = new Car();

        car1.brand = "BMW";
        car1.model = "X5";
        car1.color = "blue";

        car2.brand = "Tesla";
        car2.model = "T1";
        car2.color = "gray";

        car3.brand = "Dacia";
        car3.model = "TEP";
        car3.color = "red";
    }
}
