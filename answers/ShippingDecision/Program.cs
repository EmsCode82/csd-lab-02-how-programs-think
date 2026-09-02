// ANSWER KEY — Lesson 2 shipping decision
// --------------------------------------
// Reference only. Try src/ShippingDecision/Program.cs first.
//
// Inputs:  the order total the person types.
// Steps:   read it, decide shipping, add shipping, print both numbers.
// Decision: if orderTotal >= 50 then shipping is 0, else shipping is 5.00.

Console.WriteLine("Shipping Decision");
Console.WriteLine("Orders of $50 or more ship free. Otherwise shipping is $5.00.");
Console.WriteLine();

Console.Write("Order total: ");
decimal orderTotal = decimal.Parse(Console.ReadLine());

decimal shipping;
if (orderTotal >= 50m)
{
    shipping = 0m;
}
else
{
    shipping = 5.00m;
}

decimal amountDue = orderTotal + shipping;

Console.WriteLine($"Shipping: {shipping:C}");
Console.WriteLine($"Amount due: {amountDue:C}");
