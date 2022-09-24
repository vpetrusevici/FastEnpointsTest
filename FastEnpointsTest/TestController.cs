using Microsoft.AspNetCore.Mvc;

namespace FastEnpointsTest
{
    [ApiController]
    [Route("test")]
    public class TestController: ControllerBase
    {
        [HttpGet("TestGet")]
        public void TestGet([FromQuery]PaginationFilterWithTextAndSort<AdminArticlesSortColumn> filter)
        {

        }
    }
}
