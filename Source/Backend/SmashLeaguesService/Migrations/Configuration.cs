using System.Collections.Generic;
using Microsoft.Azure.Mobile.Server.Tables;
using SmashLeaguesService.DataObjects;
using SmashLeaguesService.Models;

namespace SmashLeaguesService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SmashLeaguesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            SetSqlGenerator("System.Data.SqlClient", new EntityTableSqlGenerator());
        }

        protected override void Seed(SmashLeaguesContext context)
        {
            //context.TodoItems.AddOrUpdate(new TodoItem { Id = Guid.NewGuid().ToString(), Text = "First item", Complete = false });
            //context.TodoItems.AddOrUpdate(new TodoItem { Id = Guid.NewGuid().ToString(), Text = "Second item", Complete = false });

            //context.Users.AddOrUpdate(new User { Id = Guid.NewGuid().ToString(), Username = "roger", UserId = "123" });
            //context.Users.AddOrUpdate(new User { Id = Guid.NewGuid().ToString(), Username = "tally", UserId = "abc" });

            List<TodoItem> todoItems = new List<TodoItem>
            {
                new TodoItem {Id = Guid.NewGuid().ToString(), Text = "First item", Complete = false},
                new TodoItem {Id = Guid.NewGuid().ToString(), Text = "Second item", Complete = false},
            };
            foreach(TodoItem todoItem in todoItems)
            {
                context.Set<TodoItem>().Add(todoItem);
            }

            List<User> users = new List<User>
            {
                new User {Id = Guid.NewGuid().ToString(), Username = "roger", UserId = "123"},
                new User {Id = Guid.NewGuid().ToString(), Username = "tally", UserId = "abc"},
            };
            foreach(User user in users)
            {
                context.Set<User>().Add(user);
            }

            base.Seed(context);

            base.Seed(context);
        }
    }
}