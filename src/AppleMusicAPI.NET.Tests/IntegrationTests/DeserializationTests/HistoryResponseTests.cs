﻿using AppleMusicAPI.NET.Models.Responses;
using Xunit;

namespace AppleMusicAPI.NET.Tests.IntegrationTests.DeserializationTests
{
    [Trait("Category", "HistoryResponseTests")]
    public class HistoryResponseTests : DeserializationTestBase
    {
        public const string JsonResponseResourceFileName = "HistoryResponse.json";

        public HistoryResponseTests()
            : base(JsonResponseResourceFileName)
        {
        }

        // TODO - Fix Response
        [Fact(Skip = "Response object requires rework")]
        public void Deserialization_ShouldSucceed()
        {
            // Arrange

            // Act
            var response = JsonSerializer.Deserialize<HistoryResponse>(JsonResponse);

            // Assert
            Assert.NotNull(response);
        }
    }
}