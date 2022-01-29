﻿namespace Meets.WebApi.Entities;

public class UserEntity
{
    public Guid Id { get; set; }
    public string DisplayName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    
    public ICollection<MeetupEntity>? SignedUpMeetups { get; set; }
}
