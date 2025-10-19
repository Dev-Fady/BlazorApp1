using BlazorApp1.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.MyCompooent
{
    public partial class ShowStudent
    {
        private List<Depat> Depats = new();
        private List<Student> Students = new();
        private List<Student> FilteredStudents = new();
        private int SelectedDepartId;

        private SampleData sampleData = new SampleData();

        protected override void OnInitialized()
        {
            Depats = sampleData.GetDepats();
            Students = sampleData.GetStudents();
        }

        private void OnDepartmentChanged(ChangeEventArgs e)
        {
            if (int.TryParse(e.Value?.ToString(), out int deptId))
            {
                SelectedDepartId = deptId;
                FilteredStudents = Students.Where(s => s.DepartId == deptId).ToList();
            }
            else
            {
                FilteredStudents.Clear();
                SelectedDepartId = 0;
            }
        }
    }
}
