using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

    public class MyToDoApi : DbContext
    {
        public MyToDoApi (DbContextOptions<MyToDoApi> options)
            : base(options)
        {
        }

        public DbSet<TodoApi.Models.TodoItem> TodoItem { get; set; } = default!;
    }
