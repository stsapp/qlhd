using QLHD.Data.Infrastructure;
using QLHD.Data.Models;
using QLHD.Data.Repositories;
using System.Collections.Generic;

namespace QLHD.Service
{
    public interface IdmhuongdanService
    {
        void Add(dmhuongdan dmhd);

        void Update(dmhuongdan dmhd);

        void Delete(int id);

        IEnumerable<dmhuongdan> GetAll();

        IEnumerable<dmhuongdan> GetAllPaging(int page, int pageSize, out int totalRow);

        //IEnumerable<dmhuongdan> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);

        dmhuongdan GetById(string id);

        //IEnumerable<dmhuongdan> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }

    public class dmhuongdanService : IdmhuongdanService
    {
        private IdmhuongdanRepository _dmhuongdanRepository;
        private IUnitOfWork _unitOfWork;

        public dmhuongdanService(IdmhuongdanRepository dmhuongdanRepository, IUnitOfWork unitOfWork)
        {
            _dmhuongdanRepository = dmhuongdanRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(dmhuongdan dmhd)
        {
            _dmhuongdanRepository.Add(dmhd);
        }

        public void Delete(int id)
        {
            _dmhuongdanRepository.Delete(id);
        }

        public IEnumerable<dmhuongdan> GetAll()
        {
            return _dmhuongdanRepository.GetAll();
        }

        //public IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow)
        //{
        //    return _postRepository.GetMultiPaging(x => x.Status && x.CategoryID == categoryId, out totalRow, page, pageSize, new string[] { "PostCategory" });
        //}

        //public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        //{
        //    //TODO: Select all post by tag
        //    return _postRepository.GetAllByTag(tag, page, pageSize, out totalRow);

        //}

        public IEnumerable<dmhuongdan> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _dmhuongdanRepository.GetMultiPaging(x => x.Status == true, out totalRow, page, pageSize);
        }

        public dmhuongdan GetById(string id)
        {
            return _dmhuongdanRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(dmhuongdan dmhd)
        {
            _dmhuongdanRepository.Update(dmhd);
        }
    }
}