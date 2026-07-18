using Microsoft.EntityFrameworkCore;
using RetailInventory.Data;

using var context = new AppDbContext();

var product = await context.Products.FirstOrDefaultAsync();

if (product != null)
{
    product.Price += 1000;

    try
    {
        await context.SaveChangesAsync();
        Console.WriteLine("Product updated successfully.");
    }
    catch (DbUpdateConcurrencyException)
    {
        Console.WriteLine("Concurrency conflict detected!");
    }
}
