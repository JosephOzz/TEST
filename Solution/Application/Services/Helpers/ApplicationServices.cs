using Application.Interfaces;

namespace Application.Services.Helpers
{
    public class ApplicationServices : IApplicationServices
    {
        private readonly IEntityOfCase1Service _case1Service;
        private readonly IEntityOfCase2Service _case2Service;

        public ApplicationServices(IEntityOfCase1Service case1Service,
            IEntityOfCase2Service case2Service)
        {
            _case1Service = case1Service;
            _case2Service = case2Service;
        }

        public IEntityOfCase1Service Case1Service => _case1Service;
        public IEntityOfCase2Service Case2Service => _case2Service;
    }
}