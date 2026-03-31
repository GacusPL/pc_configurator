using System.Data;
using PCConfigurator.PCConfiguratorDBDataSetTableAdapters;

namespace PCConfigurator.Controllers
{
    public class BuildListController
    {
        private SavedBuildsTableAdapter _adapter = new SavedBuildsTableAdapter();

        public DataTable GetAllBuilds()
        {
            return _adapter.GetData();
        }

        public void DeleteBuild(int id)
        {
            _adapter.DeleteQuery(id);
        }
    }
}