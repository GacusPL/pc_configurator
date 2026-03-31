using PCConfigurator;
using PCConfigurator.PCConfiguratorDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace PCConfigurator.Controllers
{
    public class PartViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Socket { get; set; }
        public string Type { get; set; }
        public string ImageUrl { get; set; }
    }

    public class BuildStatus
    {
        public decimal TotalPrice { get; set; }
        public int TotalWattage { get; set; }
        public string ErrorMessage { get; set; }
        public bool IsValid { get; set; }
    }

    public class BuildController
    {
        private ComponentsTableAdapter _adapter = new ComponentsTableAdapter();
        private SavedBuildsTableAdapter _buildsAdapter = new SavedBuildsTableAdapter();
        private PCConfiguratorDBDataSet.ComponentsDataTable _table;

        public List<int> CurrentBuildIds { get; private set; } = new List<int>();

        public BuildController()
        {
            //pobranie danych z bazy
            _table = _adapter.GetData();
        }

        public List<PartViewModel> GetParts(string type, string socketFilter = null, string memoryFilter = null)
        {
            var query = _table.AsEnumerable().Where(x => x.Type == type);

            if (!string.IsNullOrEmpty(socketFilter) && type == "MOBO")
            {
                query = query.Where(x => x.Socket == socketFilter);
            }

            if (!string.IsNullOrEmpty(memoryFilter) && type == "RAM")
            {
                query = query.Where(x => x.MemoryType == memoryFilter);
            }

            return query.Select(x => new PartViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Socket = x.IsSocketNull() ? "-" : x.Socket,
                Type = x.Type,
                ImageUrl = x.IsImageUrlNull() ? null : x.ImageUrl
            }).ToList();
        }

        public void AddPart(int id)
        {
            var newPart = _table.FindById(id);
            if (newPart == null) return;

            var existing = _table.AsEnumerable()
                .Where(x => CurrentBuildIds.Contains(x.Id) && x.Type == newPart.Type)
                .FirstOrDefault();

            if (existing != null)
            {
                CurrentBuildIds.Remove(existing.Id);
            }

            CurrentBuildIds.Add(id);
        }

        public string GetSelectedPartName(string type)
        {
            var part = _table.AsEnumerable()
                .Where(x => CurrentBuildIds.Contains(x.Id) && x.Type == type)
                .FirstOrDefault();
            return part != null ? part.Name : "Nie wybrano";
        }

        public string GetCurrentSocket()
        {
            var cpu = _table.AsEnumerable()
                .Where(x => CurrentBuildIds.Contains(x.Id) && x.Type == "CPU")
                .FirstOrDefault();
            return cpu?.Socket;
        }

        public BuildStatus Validate()
        {
            var parts = _table.AsEnumerable().Where(x => CurrentBuildIds.Contains(x.Id)).ToList();
            var status = new BuildStatus
            {
                TotalPrice = parts.Sum(x => x.Price),
                TotalWattage = parts.Where(x => x.Type != "PSU").Sum(x => x.Wattage),
                IsValid = true
            };

            var psu = parts.FirstOrDefault(x => x.Type == "PSU");
            if (psu != null)
            {
                if (status.TotalWattage > psu.Wattage)
                {
                    status.IsValid = false;
                    status.ErrorMessage = $"UWAGA: Pobór mocy ({status.TotalWattage}W) przekracza moc zasilacza ({psu.Wattage}W)!";
                }
            }
            else
            {
                status.ErrorMessage = "Brak zasilacza.";
            }

            return status;
        }

        public void SaveBuildToDb(string name)
        {
            if (CurrentBuildIds.Count == 0) return;

            decimal total = Validate().TotalPrice;
            string ids = string.Join(",", CurrentBuildIds);

            _buildsAdapter.Insert(name, total, DateTime.Now, ids);
        }

        public void LoadFromIdsString(string idsString)
        {
            CurrentBuildIds.Clear();
            if (string.IsNullOrEmpty(idsString)) return;

            var ids = idsString.Split(',');
            foreach (var idStr in ids)
            {
                if (int.TryParse(idStr, out int id))
                {
                    CurrentBuildIds.Add(id);
                }
            }
        }

        public string GetSelectedPartImage(string type)
        {
            var part = _table.AsEnumerable()
                .Where(x => CurrentBuildIds.Contains(x.Id) && x.Type == type)
                .FirstOrDefault();

            return part != null && !part.IsImageUrlNull() ? part.ImageUrl : null;
        }

    }
}