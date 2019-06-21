using System;

namespace BudgetProject.ApplicationCore.Catalog.Models
{
    public abstract class RecurringBudgetItem : BudgetItem
    {
        public Recurrence Recurrence { get; set; }
        public DateTime? EndDate { get; set; }

        public DateTime OnGetNextOccurrence()
        {
            // TODO: if not past EndDate, use Date property and Recurrence to calculate and return next occurrence.
            throw new NotImplementedException();
        }
    }
}