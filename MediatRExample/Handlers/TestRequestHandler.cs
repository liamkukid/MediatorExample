﻿namespace MediatRExample.Handlers;

public class TestRequestHandler : IRequestHandler<TestRequest, bool>
{
    public Task<bool> Handle(TestRequest command, CancellationToken cancellationToken)
    {
        if (command.CallException)
            throw new TestException("request threw an exception");

        return Task.FromResult(true);
    }
}