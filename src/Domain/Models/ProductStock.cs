namespace Domain.Models;

public class ProductStock
{
    public string ProductId { get; set; } = null!;
    public int Stock { get; private set; }

    public void SetStock(int stock)
    {
        if (stock < 0)
            throw new Exception("Stock can't be lower than 0.");
        Stock = stock;
    }

    public void RemoveItem()
    {
        if (Stock == 0)
            throw new Exception("There're no items in stock to perform this action.");
        Stock--;
    }

    public void AddItem()
    {
        Stock++;
    }
}