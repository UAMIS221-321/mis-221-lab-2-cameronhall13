// See https://aka.ms/new-console-template for more information


const double COST_OF_SANDWICH=4.55;
const double COST_OF_TOPPING=.55;
const double DISCOUNT_AMOUNT=.1;


Console.WriteLine("How many total sandwiches would you like to order?");
int numberOfSandwiches=int.Parse (Console.ReadLine());

Console.WriteLine("How many total toppings would you like to add?");
int numberOfToppings=int.Parse (Console.ReadLine());

Console.WriteLine("Leave a tip expressed as a decimal!");
double tip=double.Parse (Console.ReadLine());


double totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
double totalToppingCost = COST_OF_TOPPING * numberOfToppings;
double baseCost = totalSandwichCost + totalToppingCost;
double orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);

Console.WriteLine("Your total cost will be");
Console.WriteLine(orderCost);