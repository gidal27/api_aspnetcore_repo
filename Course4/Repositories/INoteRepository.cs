using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Course4.Models;

namespace Course4.Repositories
{
   public interface INoteRepository
    {
        Note FindNoteById(long id);
        IEnumerable<Note> GetAllNotes();
        void SaveNote(Note note);
        void EditNote(Note note);
        void DeleNote(Note note);
    }
}
