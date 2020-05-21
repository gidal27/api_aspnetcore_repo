using Course4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course4.Database
{
    public class NotelyDbContext :DbContext
    {
        public NotelyDbContext(DbContextOptions<NotelyDbContext> options) : base(options) { } //Constructor inherited from method base(options) from the base class DbContext
        public DbSet<Note> notes;//Represents the database
    }
}
