using advanceReviewsStackOverflow.Models.Pages;
using advanceReviewsStackOverflow.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace advanceReviewsStackOverflow.Controllers;

public class SearchPageController : PageControllerBase<SearchPage>
{
    public ViewResult Index(SearchPage currentPage, string q)
    {
        var model = new SearchContentModel(currentPage)
        {
            Hits = Enumerable.Empty<SearchContentModel.SearchHit>(),
            NumberOfHits = 0,
            SearchServiceDisabled = true,
            SearchedQuery = q
        };

        return View(model);
    }
}
