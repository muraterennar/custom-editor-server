using Business.Abstract;
using Entity.Concreate;
using Entity.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        readonly IBlogService _blogService;

        public BlogsController(IBlogService blogService)
        {
            _blogService = blogService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            List<Blog> blogs = _blogService.GetAll();
            return blogs != null ? Ok(blogs) : BadRequest();
        }

        [HttpGet("getllbtdto")]
        public IActionResult GetAllByDto()
        {
            List<BlogDetailDto> blogs = _blogService.GetAllByDto();
            return blogs != null ? Ok(blogs) : BadRequest();
        }

        //[HttpGet("getbyid/{id}")]
        //public IActionResult GetById(int id)
        //{
        //    Blog blog = _blogService.GetById(id);
        //    return blog != null ? Ok(blog) : BadRequest("Hata!");
        //}

        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            BlogDetailDto blog = _blogService.BlogDetailDtoById(id);
            return blog != null ? Ok(blog) : BadRequest("Hata!");
        }

        [HttpGet("getbycategoryid/{id}")]
        public IActionResult GetByCategoryName(int id)
        {
            Blog blog = _blogService.GetByCategoryId(id);
            return blog != null ? Ok(blog) : BadRequest("Hata!");
        }

        [HttpGet("getbyblogtitle/{blogTitle}")]
        public IActionResult GetByBlogTitle(string blogTitle)
        {
            BlogDetailDto blog = _blogService.BlogDetailDtoByBlogName(blogTitle);
            return blog != null ? Ok(blog) : BadRequest("Hata!");
        }

        [HttpPost("add")]
        public IActionResult Add(Blog blog)
        {
            _blogService.Add(blog);
            return Ok();
        }

        [HttpPatch("update")]
        public IActionResult Update(Blog blog)
        {
            _blogService.Update(blog);
            return Ok();
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Blog blog)
        {
            _blogService.Delete(blog);
            return Ok();
        }

    }
}
