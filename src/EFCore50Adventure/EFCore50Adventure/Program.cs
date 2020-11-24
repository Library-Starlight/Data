using EFCore50Adventure;
using EFCore50Adventure.Data;
using EFCore50Adventure.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

var connString = $"Data Source={nameof(ContactContext.ContactDb)}.db";

await SetupDatabaseAsync();

await QueryAndChangeAsync();

async Task SetupDatabaseAsync()
{
    Console.WriteLine($"{new Unicorn()}{Environment.NewLine}Preparing database...");

    var optionBuilder = new DbContextOptionsBuilder<ContactContext>()
        .UseSqlite(connString)
        //.LogTo(Console.WriteLine)
        ;

    var context = new ContactContext(optionBuilder.Options);

    // Seed
    if (await context.Database.EnsureCreatedAsync() || await context.Contacts.CountAsync() == 0)
    {
        var newContact = new Contact { Id = 1, FirstName = "", State = "", ZipCode = "" };
        context.Contacts.Add(newContact);
        await context.SaveChangesAsync();
    }
}

async Task QueryAndChangeAsync()
{
    var services = new ServiceCollection();
    services.AddDbContextFactory<ContactContext>(
        opt =>
            opt.UseSqlite(connString)
             .LogTo(Console.WriteLine, LogLevel.Information)
             );

    List<Contact> contacts = null;
    var factory = services.BuildServiceProvider().GetService<IDbContextFactory<ContactContext>>();
    using var context = factory.CreateDbContext();

    var query1 = context.Contacts
        .Where(c => c.City.Contains(""))
        .Skip(20).Take(20);

    //var queryStr = query1.ToQueryString();
    //Console.WriteLine(queryStr);

    // Query
    contacts = await query1.ToListAsync();

    // Change
    var query2 = context.Contacts;

    //queryStr = query2.ToQueryString();
    //Console.WriteLine(queryStr);

    var contact = await query2.SingleOrDefaultAsync(c => c.Id == 1);

    contact.State = "1111";
    contact.ZipCode = "11";
    await context.SaveChangesAsync();

}