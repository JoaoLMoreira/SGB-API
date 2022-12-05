using SgbProject.Data;
using SgbProject.Enums;
using SgbProject.Models;
using SgbProject.Repositories;

namespace SgbProject.Services
{
    public class BovinosService : IBovinosService
    {
        private readonly IRepository<Baixa> _baixaRepository;
        private readonly IRepository<Bovino> _bovinoRepository;

        public BovinosService(IRepository<Baixa> baixaRepository, IRepository<Bovino> bovinoRepository)
        {
            _baixaRepository = baixaRepository;
            _bovinoRepository = bovinoRepository;
        }

        public IEnumerable<Bovino> GetAllBovinos()
        {
            return _bovinoRepository.GetAll();
        }
        public Bovino GetBovino(Guid id)
        {
            return _bovinoRepository.GetById(id);
        }

        public Bovino AddBovino(Bovino bovino)
        {
            bovino.Id = Guid.NewGuid();
            var bovinoadicionado = _bovinoRepository.Add(bovino);
            _bovinoRepository.SaveChanges();
            return (bovinoadicionado);
        }

        public Bovino UpdateBovino(Bovino bovino)
        {
            var novobovino = _bovinoRepository.Update(bovino);
            _bovinoRepository.SaveChanges();
            return (novobovino);

        }
        public RemoveBovinoRequest Delete(RemoveBovinoRequest request)
        {
            var bovinoExistente = _bovinoRepository.GetById(request.id);
            if (bovinoExistente != null)
            {
                var baixa = new Baixa
                {
                    Id = Guid.NewGuid(),
                    IdBovino = bovinoExistente.Id,
                    Motivo = ((eMotivo)request.Motivo).ToString(),
                    DataBaixa = DateTime.Now,
                    IdUsuario = Guid.Parse("0CD60E1E-DC47-427D-B95C-2B58C4C65ACB"), //meu usuario
                    Apelido = bovinoExistente.Apelido,
                    AnoNascimento = bovinoExistente.AnoNascimento,
                    Genitora = bovinoExistente.Genitora,
                    IdMaterno = bovinoExistente.IdMaterno,
                    IdPaterno = bovinoExistente.IdPaterno,
                    MesNascimento = bovinoExistente.MesNascimento,
                    QtdCria = bovinoExistente.QtdCria,
                    Raca = bovinoExistente.Raca,
                    Sexo = bovinoExistente.Sexo,
                };


                //var baixa = new Baixa(bovinoExistente, ((eMotivo)request.Motivo).ToString());
                _baixaRepository.Add(baixa);
                _bovinoRepository.Remove(bovinoExistente);
                _baixaRepository.SaveChanges();
                _bovinoRepository.SaveChanges();
                return (request);
            }
            else
            {
                return (null);
            }


        }


    }
}

