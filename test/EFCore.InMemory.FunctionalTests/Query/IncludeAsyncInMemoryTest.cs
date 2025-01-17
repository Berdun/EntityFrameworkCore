// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Xunit;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class IncludeAsyncInMemoryTest : IncludeAsyncTestBase<IncludeInMemoryFixture>
    {
        public IncludeAsyncInMemoryTest(IncludeInMemoryFixture fixture)
            : base(fixture)
        {
        }

        [ConditionalFact(Skip = "Issue #16963")]
        public override Task Include_collection_with_client_filter() => null;
    }
}
