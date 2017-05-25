﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Wilson.Web.Areas.Scheduler.Models.SharedViewModels;

namespace Wilson.Web.Areas.Scheduler.Models.PayrollViewModels
{
    public class ReviewPaychecksViewModel
    {
        [StringLength(36)]
        [Display(Name = "Employee")]
        public string EmployeeId { get; set; }

        [StringLength(7)]
        [Display(Name = "From")]
        public string From { get; set; }

        [StringLength(7)]
        [Display(Name = "To")]
        public string To { get; set; }

        public IEnumerable<SelectListItem> EmployeeOptions { get; set; }

        public IEnumerable<SelectListItem> PeriodOptions { get; set; }

        public IEnumerable<EmployeeConciseViewModel> Employees { get; set; }
    }
}
