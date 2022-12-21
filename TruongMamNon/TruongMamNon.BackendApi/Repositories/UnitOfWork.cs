using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TruongMamNon.BackendApi.Data.EF;
using TruongMamNon.BackendApi.Interfaces;
using TruongMamNon.BackendApi.Interfaces.MamNon;
using TruongMamNon.BackendApi.Repositories.MamNon;

namespace TruongMamNon.BackendApi.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TruongMamNonDbContext _context;
        private readonly IMapper _mapper;

        public UnitOfWork(TruongMamNonDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            DanhMucThucDon = new DanhMucThucDonRepository(_context, _mapper);
        }

        public IDanhMucThucDonRepository DanhMucThucDon { get; set; }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}