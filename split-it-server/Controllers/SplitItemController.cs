using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using split_it_server.DataObjects;
using split_it_server.Models;

namespace split_it_server.Controllers
{
    public class SplitItemController : TableController<SplitItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileServiceContext context = new MobileServiceContext();
            DomainManager = new EntityDomainManager<SplitItem>(context, Request);
        }

        // GET tables/SplitItem
        public IQueryable<SplitItem> GetAllSplitItem()
        {
            return Query(); 
        }

        // GET tables/SplitItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<SplitItem> GetSplitItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/SplitItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<SplitItem> PatchSplitItem(string id, Delta<SplitItem> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/SplitItem
        public async Task<IHttpActionResult> PostSplitItem(SplitItem item)
        {
            SplitItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/SplitItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteSplitItem(string id)
        {
             return DeleteAsync(id);
        }
    }
}
