using Microsoft.AspNetCore.Razor.TagHelpers;
using WebApplication2.Model;

namespace WebApplication2.Helpers
{
	public class CustomCategoryTagHelper : TagHelper
	{
		public Category Category { get; set; }
		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.TagName = "tr";
			output.Content.SetHtmlContent(
				$@"
					<td width=""50%"">{Category.Name}</td>
					<td width=""30%"">{Category.DisplayOrder}</td>
					<td>
						<div class=""w-75 btn-group"" role=""group"">
							<a asp-page=""Edit"" asp-route-id=""{Category.Id}"" class=""btn btn-primary mx-2"">
								<i class=""bi bi-pencil-square""></i>
							</a>
							<a asp-page=""Delete"" asp-route-id=""{Category.Id}"" class=""btn btn-danger mx-2"">
								<i class=""bi bi-trash-fill""></i>
							</a>
						</div>
					</td>"
				);
		}
	}
}
