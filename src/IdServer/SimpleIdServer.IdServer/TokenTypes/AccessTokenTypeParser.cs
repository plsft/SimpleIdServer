﻿// Copyright (c) SimpleIdServer. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.
using Microsoft.IdentityModel.JsonWebTokens;
using SimpleIdServer.IdServer.Exceptions;
using SimpleIdServer.IdServer.Jwt;
using System.Collections.Generic;

namespace SimpleIdServer.IdServer.TokenTypes;

public class AccessTokenTypeParser : ITokenTypeParser
{
    private readonly IJwtBuilder _jwtBuilder;

    public AccessTokenTypeParser(IJwtBuilder jwtBuilder)
    {
        _jwtBuilder = jwtBuilder;
    }

    public const string NAME = "urn:ietf:params:oauth:token-type:access_token";
    public string Name => NAME;

    public Dictionary<string, string> Parse(string realm, string token)
    {
        var extractionResult = _jwtBuilder.ReadSelfIssuedJsonWebToken(realm, token);
        if (extractionResult.Error != null) throw new OAuthException(ErrorCodes.INVALID_REQUEST, extractionResult.Error);
        var result = new Dictionary<string, object>();

        foreach (var cl in extractionResult.Jwt.Claims) result.Add(new KeyValuePair<string, string>(cl.Type, cl.Value));
        return result;
    }
}
