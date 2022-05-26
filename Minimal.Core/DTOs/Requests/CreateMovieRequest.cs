using MediatR;

namespace Minimal.Core.DTOs.Requests
{
    public class CreateMovieRequest : IRequest<BaseResponseDto<bool>>
    {
        public string? Name { get; set; }
        public double Rating { get; set; }
    }
}
