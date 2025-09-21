using ContactManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employee : Person
{
    public Guid employeeNumber { get; set; } = Guid.NewGuid();
    public string department { get; set; }
    public DateTime startDate { get; set; }
    public DateTime endDate { get; set; }
    public int employment { get; set; } // 100 für 100%
    public string role { get; set; }
    public int cadreLevel { get; set; } // Führungsebene
}

