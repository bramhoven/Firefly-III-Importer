﻿using Luciferin.Infrastructure.GoCardless.Enums;

namespace Luciferin.Infrastructure.GoCardless.Models;

public class Requisition
{
    public ICollection<string> Accounts { get; set; }

    public bool AccountSelection { get; set; }

    public string Agreement { get; set; }

    public DateTime Created { get; set; }

    public string Id { get; set; }

    public string InstitutionId { get; set; }

    public string Link { get; set; }

    public string Redirect { get; set; }

    public string Reference { get; set; }

    public string Ssn { get; set; }

    public RequisitionStatus Status { get; set; }

    public string UserLanguage { get; set; }

    public bool IsSuspended { get; set; }

    public bool IsRevoked { get; set; }
}