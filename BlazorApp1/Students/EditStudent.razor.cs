using BlazorApp1.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Students
{
    public partial class EditStudent
    {
        [Parameter]
        public int Id { get; set; }

        public Student student { get; set; }
        public List<Depat> depats { get; set; }
        [Inject]
        public NavigationManager NavManager { get; set; }

        public bool DataSave { get; set; } = false;

        protected override void OnInitialized()
        {
            student = stuService.getById(Id);
            depats = depatService.getAll();
            base.OnInitialized();
        }
        private void Save(Microsoft.AspNetCore.Components.Forms.EditContext args)
        {
            // save 
            Console.WriteLine("Saaaaaaave in Valid"+student);
            //DataSave = true;
            NavManager.NavigateTo("/student/Details/" + Id);
        }
        private void InValid(Microsoft.AspNetCore.Components.Forms.EditContext args)
        {
            Console.WriteLine("Herrrrrrrre in InValid" + student);
            //DataSave = false;
        }
    }
}