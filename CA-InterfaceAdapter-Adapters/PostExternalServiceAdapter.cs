using CA_ApplicationLayer;
using CA_EnterpriseLayer;
using CA_InterfaceAdapter_Adapters.DTOs;

namespace CA_InterfaceAdapter_Adapters
{
    public class PostExternalServiceAdapter : IExternalServiceAdapter<Post>
    {
        private readonly IExternalService<PostServiceDTO> _externalService;
        public PostExternalServiceAdapter(IExternalService<PostServiceDTO> externalService)
        {
            _externalService = externalService;
        }
        public async Task<IEnumerable<Post>> GetDataAsync()
        {
            var postES = await _externalService.GetContentAsync();
            var post = postES.Select(p => new Post //transformation
            {
                Id = p.Id,
                Title = p.Title,
                Body = p.Body
            });
            return post;
        }
    }
}
