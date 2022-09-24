using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication1.Entities;

namespace WebApplication1.Taghelpers
{
    [HtmlTargetElement("employee-list")]
    public class EmployeeListTagHelper:TagHelper
    {
        public List<Employee> _employees;
        public EmployeeListTagHelper()
        {
            _employees= new List<Employee>
            {
                new Employee
                {
                    Id=1,
                     CityId=1,
                      Firstname="Elvin",
                       Lastname="Camalzade"
                },
                new Employee
                {
                    Id=2,
                     CityId=1,
                      Firstname="Leyla",
                       Lastname="Mammadova"
                },
                new Employee
                {
                    Id=3,
                     CityId=2,
                      Firstname="Tural",
                       Lastname="Aliyev"
                },
            };
        }

        private const string ListCountAttribute = "count";
        [HtmlAttributeName(ListCountAttribute)]
        public int ListCount { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";

            var query = _employees.Take(ListCount);

            StringBuilder sb = new StringBuilder();

            foreach (var item in query)
            {
                sb.AppendFormat("<h2><a href='/employee/detail/{0}'>{1}</a></h2>",item.Id,item.Firstname);
            }

            output.Content.SetHtmlContent(sb.ToString());
        }
    }
}
