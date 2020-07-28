using AutoMapper;
using DemoCompra.Application.Interfaces;
using DemoCompra.Application.ViewModels;
using DemoCompra.Domain.Interfaces;
using DemoCompra.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoCompra.Application.Services
{
    public class CompraAppService : ICompraAppService
    {
        private readonly ICompraRepository _compraRepository;
        private readonly IMapper _mapper;

        public CompraAppService(ICompraRepository compraRepository, IMapper mapper)
        {
            _compraRepository = compraRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CompraViewModel>> ObterTodos()
        {
            return _mapper.Map<IEnumerable<CompraViewModel>>(await _compraRepository.ObterTodos());
        }

        public async Task<CompraViewModel> ObterPorId(Guid id)
        {
            return _mapper.Map<CompraViewModel>(await _compraRepository.ObterPorId(id));
        }

        public void AdicionarCompra(CompraViewModel compraViewModel)
        {
            var compra = _mapper.Map<Compra>(compraViewModel);
            _compraRepository.Adicionar(compra);

            _compraRepository.UnitOfWork.Commit();
        }

        public void AtualizarCompra(CompraViewModel compraViewModel)
        {
            var compra = _mapper.Map<Compra>(compraViewModel);
            _compraRepository.Atualizar(compra);

            _compraRepository.UnitOfWork.Commit();
        }

        public void Dispose()
        {
            _compraRepository?.Dispose();
        }
    }
}
