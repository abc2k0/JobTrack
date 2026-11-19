using System;
using JobTrack.Api.Models.Enums;

namespace JobTrack.Api.Models;

public class JobApplication
{
    public int Id {get; set;}
    public required string CompanyName {get; set;}
    public required string JobTitle {get; set;}
    public required DateOnly ApplicationDate{get; set;}
    public string? JobUrl {get; set;}
    public ApplicationStatus Status {get; set;}
    public string? Notes {get; set;}
    public DateTimeOffset CreatedAt {get; set;}
    public DateTimeOffset UpdatedAt {get; set;}
}