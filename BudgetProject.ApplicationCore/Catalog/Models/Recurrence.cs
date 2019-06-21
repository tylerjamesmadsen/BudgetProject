using System.Data.SqlTypes;

namespace BudgetProject.ApplicationCore.Catalog.Models
{
    public enum Recurrence
    {
       None,
       Daily,
       // DaysOfWeek,
       Weekly,
       BiWeekly,
       Monthly,
       // MonthsOfYear,
       Quarterly,
       SemiAnnually,
       Annually
    }
}