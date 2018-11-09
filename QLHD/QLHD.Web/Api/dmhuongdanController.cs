using AutoMapper;
using QLHD.Service;
using QLHD.Web.infrastructure.Core;
using QLHD.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLHD.Web.Api
{
    [RoutePrefix("api/dmhuongdan")]
    public class dmhuongdanController : ApiControllerBase
    {
        private IdmhuongdanService _dmhuongdanService;

        public dmhuongdanController(IErrorService errorService, IdmhuongdanService dmhuongdanService) : base(errorService)
        {
            _dmhuongdanService = dmhuongdanService;
        }

        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listHD = _dmhuongdanService.GetAll();

                var listHDViewModel = Mapper.Map<List<dmhuongdanViewModel>>(listHD);

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listHDViewModel);

                return response;
            });
        }

        //[Route("add")]
        //public HttpResponseMessage Post(HttpRequestMessage request, PostCategoryViewModel postCategoryVm)
        //{
        //    return CreateHttpResponse(request, () =>
        //    {
        //        HttpResponseMessage response = null;
        //        if (ModelState.IsValid)
        //        {
        //            request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
        //        }
        //        else
        //        {
        //            PostCategory newPostCategory = new PostCategory();
        //            newPostCategory.UpdatePostCategory(postCategoryVm);

        //            var category = _postCategoryService.Add(newPostCategory);
        //            _postCategoryService.Save();

        //            response = request.CreateResponse(HttpStatusCode.Created, category);

        //        }
        //        return response;
        //    });
        //}

    }
}