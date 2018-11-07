﻿using AppleMusicAPI.NET.Models.Responses;
using Xunit;

namespace AppleMusicAPI.NET.Tests.IntegrationTests.DeserializationTests
{
    [Trait("Category", "LibrarySearchResponseTests")]
    public class LibrarySearchResponseTests : DeserializationTestBase
    {
        public const string JsonResponseResourceFileName = "LibrarySearchResponse.json";

        public LibrarySearchResponseTests()
            : base(JsonResponseResourceFileName)
        {
        }

        // TODO - Fix Response
        [Fact(Skip = "Response object requires rework")]
        public void Deserialization_ShouldSucceed()
        {
            // Arrange

            // Act
            var response = JsonSerializer.Deserialize<LibrarySearchResponse>(JsonResponse);

            // Assert
            Assert.NotNull(response);
        }
    }
}