using System;
namespace InterfaceExercise
{
    public interface ICompany
    {
        public string CompName { get; set; }
        public double Income { get; set; }

        public void CompanyDescription();
    }
}
