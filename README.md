# Order Processing Method

This repository contains a `Process` method for handling orders. The method performs several checks to ensure that the order is valid and ready to be processed. If any of the checks fail, the method either returns without processing the order or throws an appropriate exception.

## Method Overview

```csharp
public void Process(Order? order)
{
    if (order is null ||
        !order.IsVerified ||
        !order.Items.Any())
    {
        return;
    }

    if (order.Items.Count > 15)
    {
        throw new Exception(
            "The order " + order.Id + " has too many items");
    }

    if (order.Status != "ReadyToProcess")
    {
        throw new Exception(
            "The order " + order.Id + " isn't ready to process");
    }

    order.IsProcessed = true;
}
