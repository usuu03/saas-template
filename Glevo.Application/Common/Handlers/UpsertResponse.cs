using System;
using Glevo.Application.Common.Enums;

namespace Glevo.Application.Common.Handlers;

public class UpsertTransactionResponse
{
    public UpsertAction Action { get; set; }

    public UpsertTransactionResponse(UpsertAction action)
    {
        Action = action;
    }

}
