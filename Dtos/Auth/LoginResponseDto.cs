﻿namespace IT_Tools.Dtos.Auth;

public class LoginResponseDto
{
    public int UserId { get; set; } // ID của người dùng
    public string Token { get; set; } = string.Empty; // JWT Token
    public string Username { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
}