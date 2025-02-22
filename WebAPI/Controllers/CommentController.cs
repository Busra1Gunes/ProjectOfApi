using Business.Abstract;
using Entities;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpPost]
        public IActionResult CommentAdd([FromForm] CommentAddDto commentAdd)
        {
            var baseUri = new Uri(this.Request.GetEncodedUrl());
            var baseUrl = $"{baseUri.GetLeftPart(UriPartial.Authority)}{this.Request.PathBase}/";
            int kullaniciId = Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
            var result = _commentService.Add(commentAdd, baseUrl, kullaniciId);

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        [HttpGet]
        public IActionResult CommentGet()=>Ok(_commentService.GetAll());
    }
}
