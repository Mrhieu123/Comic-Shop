using System;
using System.Collections.Generic;

namespace ComicManagement.Models;

public partial class User
{
    public int Id { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public int Role { get; set; }

    public bool? Status {get; set; }

    public override string ToString()
    {
        return Id + FirstName + LastName + Address + Phone + Email + Role + Status;
    }
}
