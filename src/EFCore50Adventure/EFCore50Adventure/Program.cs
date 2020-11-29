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

await RelationQueryAsync();

#region 关系查询

async Task RelationQueryAsync()
{
    var jack = new User { Name = "Jack" };
    var john = new ExternalUser { Name = "John", ExternalCompany = "Bigsoft" };

    var football = new Group { Name = "Football", Users = new List<User> { jack, john } };
    var basketball = new Group { Name = "Basketball", Users = new List<User> { john } };

    var context = new UserContext();
    await context.Database.EnsureDeletedAsync();
    await context.Database.EnsureCreatedAsync();
    context.AddRange(jack, john, football, basketball);
    await context.SaveChangesAsync();

    var users = await context.Users
        //.Where(user => user.Memberships.Any(m => m.Group.Name == "Basketball"))
        .Where(user => user.Groups.Any(g => g.Name == "Basketball"))
        .ToListAsync();
    foreach (var user in users)
    {
        Console.WriteLine($"Id: {user.Id}, User: {user.Name}");
    }

    var oldTimers = await context.Users.Where(u => u.Memberships.Any(m => m.MemberSince > new DateTime(2000, 1, 1))).ToListAsync();
    foreach (var user in oldTimers)
    {
        Console.WriteLine($"Id: {user.Id}, User: {user.Name}");
    }

    var externalUsers = await context.Set<ExternalUser>().ToListAsync();
    foreach (var user in externalUsers)
    {
        Console.WriteLine($"Id: {user.Id}, User: {user.Name}");
    }
}

#endregion

#region 查询

/// <summary>
/// 查询
/// </summary>
async Task QueryAsync()
{
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
}

#endregion

async Task QueryAndChangeAsync()
{
    var connString = $"Data Source={nameof(ContactContext.ContactDb)}.db";

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