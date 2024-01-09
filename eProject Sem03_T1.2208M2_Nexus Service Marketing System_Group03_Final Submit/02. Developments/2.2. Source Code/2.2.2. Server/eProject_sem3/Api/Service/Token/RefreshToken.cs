﻿namespace Api.Service.Token
{
    public record RefreshToken
    (
        string Token,
        DateTime Created,
        DateTime Expires
    );
}
