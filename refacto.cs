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
