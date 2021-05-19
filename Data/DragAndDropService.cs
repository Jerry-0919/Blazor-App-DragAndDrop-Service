using System;

namespace BlazorApp.Data
{
    public class DragAndDropService
    {
        public Employee Data { get; set; }
        public int Zone { get; set; }

        public void StartDrag(Employee data, int zone)
        {
            this.Data = data;
            this.Zone = zone;
        }

        public bool Accepts(int zone)
        {
            return this.Zone == zone;
        }
    }
}