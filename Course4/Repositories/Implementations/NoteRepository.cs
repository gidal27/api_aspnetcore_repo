using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Course4.Models;
using Course4.Database;

namespace Course4.Repositories.Implementations
{
    public class NoteRepository: INoteRepository
    {
        private NotelyDbContext _context;

        public Note FindNoteById(long id) {

            Note note = _context.notes.Find(id);
            return note;
        }


        public IEnumerable<Note> GetAllNotes(){

            return _context.notes;
        }


        public void SaveNote(Note note) {

            _context.notes.Add(note);
            _context.SaveChanges();
        }

        public void EditNote( Note note) {

            //var _note = _context.notes.Find(Id);

            //_note.Id = note.Id;
            //_note.subject = note.subject;
            //_note.Detail = note.Detail;
            //_note.CreatedAt = note.CreatedAt;
            //_note.LastModiefiedDate = note.LastModiefiedDate;
            //_note.IsDeleted = note.IsDeleted;

            //_context.notes.Add(_note);
            _context.notes.Update(note);
            _context.SaveChanges();

            
        }
        public void DeleNote(Note note) {

            _context.notes.Remove(note);
            _context.SaveChanges();
        }
    }
}
