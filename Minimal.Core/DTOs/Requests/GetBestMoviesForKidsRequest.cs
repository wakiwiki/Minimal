using MediatR;

namespace Minimal.Core.DTOs.Requests
{
    public class GetBestMoviesForKidsRequest : IRequest<BaseResponseDto<List<MovieDto>>>
    {

    }
}
