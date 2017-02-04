using System;
using System.Data.Entity.Migrations;
using Microsoft.Azure.Mobile.Server.Tables;
using SmashLeaguesService.DataObjects;
using SmashLeaguesService.Models;

namespace SmashLeaguesService.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SmashLeaguesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SqlClient", new EntityTableSqlGenerator());
        }

        protected override void Seed(SmashLeaguesContext context)
        {
            context.TodoItems.AddOrUpdate(new TodoItem
            {
                Id = Guid.NewGuid().ToString(),
                Text = "First item",
                Complete = false
            });
            context.TodoItems.AddOrUpdate(new TodoItem
            {
                Id = Guid.NewGuid().ToString(),
                Text = "Second item",
                Complete = false
            });

            context.Users.AddOrUpdate(new User {Id = Guid.NewGuid().ToString(), Username = "roger", UserId = "123"});
            context.Users.AddOrUpdate(new User {Id = Guid.NewGuid().ToString(), Username = "tally", UserId = "abc"});

            base.Seed(context);
        }
    }
}