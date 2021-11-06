
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using T3ESOT.Models;

namespace T3ESOT.Repositorio
{
    public interface IHomeRepo
    {
        List<Etiqueta> GetEtiquetas();
        Etiqueta GetEtiqueta(int idCategoria);
        Nota GetNota(int id);
        List<EtiquetaNota> GetEtiquetaNotas();
        List<EtiquetaNota> GetEtiquetaNotasUser(int idUser, int idCategoria);
        List<Nota> GetNotas(int idUser);
        void SaveNota(Nota nota);
        void ActualizeNota(Nota nota);
        void SaveEtiquetaNota(List<EtiquetaNota> etique);
        void EliminarNota(int id);
        void EliminarEtiquetas(int id);
        List<User> GetUsersC(int id);
        Compartido GetCompartido(int idNota, int idUser);
        void SaveCompartido(Compartido Compartido);
        List<Compartido> GetCompartidos(int idUser);
    }
    public class HomeRepo: IHomeRepo
    {
        private readonly ContextE context;

        public HomeRepo(ContextE context)
        {
            this.context = context;
        }

        public Nota GetNota(int id)
        {
            return context.Notas.Where(o => o.Id == id).FirstOrDefault();
        }

        public List<EtiquetaNota> GetEtiquetaNotas()
        {
            return context.EtiquetaNotas
                .Include(o => o.Etiqueta)
                .Include(o => o.Nota)
                .ToList();
        }

        public List<Etiqueta> GetEtiquetas()
        {
            return context.Etiquetas.ToList();
        }

        public List<Nota> GetNotas(int idUser)
        {
            return context.Notas.
                Where(o => o.IdUser == idUser).
                ToList();
        }

        public void SaveNota(Nota nota)
        {
            context.Notas.Add(nota);
            context.SaveChanges();
        }

        public void SaveEtiquetaNota(List<EtiquetaNota> etique)
        {
            context.EtiquetaNotas.AddRange(etique);
            context.SaveChanges();
        }

        public void EliminarNota(int id)
        {
            var nota = context.Notas.Where(o => o.Id == id).FirstOrDefault();
            var etiqueta = context.EtiquetaNotas.Where(o => o.IdNota == id).ToList();
            context.Notas.Remove(nota);
            context.EtiquetaNotas.RemoveRange(etiqueta);
            context.SaveChanges();
        }

        public void EliminarEtiquetas(int id)
        {
            var etiquetatita = context.EtiquetaNotas.Where(o => o.IdNota == id).ToList();
            context.EtiquetaNotas.RemoveRange(etiquetatita);
        }

        public void ActualizeNota(Nota nota)
        {
            context.Notas.Update(nota);
            context.SaveChanges();
        }

        public Etiqueta GetEtiqueta(int idCategoria)
        {
            return context.Etiquetas.Where(o => o.Id == idCategoria).First();
        }

        public List<EtiquetaNota> GetEtiquetaNotasUser(int idUser, int idCategoria)
        {
            return context.EtiquetaNotas
                .Include(o => o.Etiqueta)
                .Include(o => o.Nota)
                .Where(O => O.Nota.IdUser == idUser && O.IdEtiqueta == idCategoria)
                .ToList();
        }

        public List<User> GetUsersC(int id)
        {
            return context.Users.Where(o => o.Id != id).ToList();
        }

        public Compartido GetCompartido(int idNota, int idUser)
        {
            return context.Compartidos.Where(o => o.IdNota == idNota && o.IdUser == idUser).FirstOrDefault();
        }

        public void SaveCompartido(Compartido Compartido)
        {
            context.Compartidos.Add(Compartido);
            context.SaveChanges();
        }

        public List<Compartido> GetCompartidos(int idUser)
        {
            return context.Compartidos
                .Where(o => o.IdUser == idUser)
                .Include(o => o.Nota)
                .Include(o => o.User)
                .ToList();
        }
    }
}
