using EPiServer.Shell.Navigation;
using System.Collections.Generic;

namespace The.Great.Library
{
    [MenuProvider]
    public class MenuProvider : IMenuProvider
    {
        public IEnumerable<MenuItem> GetMenuItems()
        {
            // var url = Paths.ToResource(GetType(), "container");

            var link = new UrlMenuItem(
                "The Great Library",
                MenuPaths.Global + "/cms/thegreatlibrary",
                "/The.Great.Library")
            {
                SortIndex = 100
            };

            return new List<MenuItem>
            {
                link
            };
        }
    }
}
