﻿namespace CorePortfolio.Entities.Concrete;
public class SocialMedia
{
    public int SocialMediaId { get; set; }
    public string SocialMediaName { get; set; }
    public string SocialMediaUrl { get; set; }
    public string SocialMediaIcon { get; set; }
    public bool IsActive { get; set; }
}