using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<SelectListItem> listStates = new List<SelectListItem>();
        public List<SelectListItem> listCountries = new List<SelectListItem>();

        public bool isReactivate { get; set; } = false;

        public List<string> lstCheckedIds = new List<string>();

        public List<MachineModel> lstMachines = new List<MachineModel>();

        public int SelectedIndexId { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            listCountries.Add(new SelectListItem { Text = "India", Value = "1" });
            listCountries.Add(new SelectListItem { Text = "USA", Value = "2" });

            lstMachines.Add(new MachineModel { MachineId = "MachineId - 1", MachineName = "Machine One" });
            lstMachines.Add(new MachineModel { MachineId = "MachineId - 2", MachineName = "Machine Two" });
            lstMachines.Add(new MachineModel { MachineId = "MachineId - 3", MachineName = "Machine Three" });
        }

        public void OnGet()
        {
         
        }

        public void OnPostAsync(int indexvalue)
        {
            listStates = new List<SelectListItem>();
            SelectedIndexId = 1;
            if (SelectedIndexId == 1)
            {
                listStates.Add(new SelectListItem { Text = "Andhra Pradesh", Value = "-1" });
                listStates.Add(new SelectListItem { Text = "Telangana", Value = "-2" });
                listStates.Add(new SelectListItem { Text = "Tamil Nadu", Value = "-3" });
                listStates.Add(new SelectListItem { Text = "Maharastra", Value = "-4" });
            }
            else if (SelectedIndexId == 2)
            {
                listStates.Add(new SelectListItem { Text = "Texas", Value = "-5" });
                listStates.Add(new SelectListItem { Text = "California", Value = "-6" });
                listStates.Add(new SelectListItem { Text = "Michigan", Value = "-7" });
                listStates.Add(new SelectListItem { Text = "Nevada", Value = "-8" });
            }
        }
    }

    public class MachineModel
    {
        public string MachineId { set; get; }
        public string MachineName { set; get; }
    }
}
