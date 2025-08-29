using Ambev.DeveloperEvaluation.Application.Requests;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Application.Carts.UpdateCart
{
    public class UpdateCartHandler : IRequestApplicationHandler<UpdateCartCommand, UpdateCartResult>
    {
        private readonly ICartRepository _cartRepository;
        private readonly IMapper _mapper;

        public UpdateCartHandler(ICartRepository cartRepository, IMapper mapper)
        {
            _cartRepository = cartRepository;
            _mapper = mapper;
        }

        public async Task<UpdateCartResult> Handle(UpdateCartCommand command, CancellationToken cancellationToken)
        {
            // Adicione valida��o se necess�rio
            var cart = _mapper.Map<Cart>(command);
            var updated = await _cartRepository.UpdateAsync(cart, cancellationToken);
            var result = _mapper.Map<UpdateCartResult>(updated);
            return result;
        }
    }
}
