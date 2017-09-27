using CS_OOP_Advanced_Exam_Prep_July_2016.Interfaces;
using CS_OOP_Advanced_Exam_Prep_July_2016.Lifecycle;
using CS_OOP_Advanced_Exam_Prep_July_2016.Lifecycle.Controller;
using CS_OOP_Advanced_Exam_Prep_July_2016.Lifecycle.Request;

namespace CS_OOP_Advanced_Exam_Prep_July_2016.Controllers
{
    [Controller]
    public class ProductController
    {
        private IDatabase database;

        [RequestMapping(value: "/product/{size}/{name}/{type}", method: RequestMethod.ADD)]
        public void AddProduct([UriParameter(value: "size")]int size, [UriParameter(value: "name")]string name, [UriParameter(value: "type")]string type)
        {
        }
    }
}