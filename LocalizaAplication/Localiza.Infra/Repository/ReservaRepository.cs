using Localiza.Domain.Enuns;
using Localiza.Domain.Interfaces.Repositories;
using Localiza.Domain.Models;
using Localiza.Infra.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localiza.Infra.Repository
{
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        private readonly LocalizaDbContext _context;
        public ReservaRepository(LocalizaDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Reserva>> GetReservasByClienteId(long ClienteId)
        {
            var result = _context.Reserva
                .Include(x => x.Cliente)
                .Include(x => x.Veiculo)
                .Where(x => x.ClienteId == ClienteId)
                .AsEnumerable();

            return result;
        }

        public async Task<bool> RetirarVeiculo(long ClienteId, string cpf)
        {
            Cliente cliente = null;
            Reserva reserva = null;
            IEnumerable<Reserva> reservas = null;


            if (ClienteId != 0)
            {
                reservas = _context.Reserva.Where(x => x.ClienteId == ClienteId && x.StatusReserva == StatusReserva.Reservado).ToList();

                if (reservas.Count() > 0)
                {
                    reserva = reservas.Where(x => x.DataRetirada.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy")).FirstOrDefault();

                    reserva.StatusReserva = StatusReserva.Retirado;
                    reserva.HoraRetirada = DateTime.Now.Hour.ToString();
                    await Update(reserva);
                    return true;
                }

            }
            else
            {
                cliente = _context.Cliente.Where(x => x.CPF == cpf).FirstOrDefault();
                reservas = _context.Reserva.Where(x => x.ClienteId == cliente.ClienteId && x.StatusReserva == StatusReserva.Reservado).ToList();

                if (reservas.Count() > 0)
                {
                    reserva = reservas.Where(x => x.DataRetirada.ToString("MM/dd/yyyy") == DateTime.Now.ToString("MM/dd/yyyy")).FirstOrDefault();

                    reserva.StatusReserva = StatusReserva.Retirado;
                    reserva.HoraRetirada = DateTime.Now.ToString("hh:mm:ss tt");
                    await Update(reserva);
                    return true;
                }
            }
            return false;
        }
    }
}
