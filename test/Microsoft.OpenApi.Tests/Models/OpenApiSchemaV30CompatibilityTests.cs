// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Xunit;

namespace Microsoft.OpenApi.Tests.Models
{
    [Collection("DefaultSettings")]
    public class OpenApiSchemaV30CompatibilityTests
    {
        private static IOpenApiSchema ParseSchemaFromV30Document(string schemaJson)
        {
            var jsonContent = $$"""
                {
                  "openapi": "3.0.0",
                  "info": { "title": "Test", "version": "1.0" },
                  "paths": {},
                  "components": {
                    "schemas": {
                      "TestSchema": {{schemaJson}}
                    }
                  }
                }
                """;

            var readResult = OpenApiDocument.Parse(jsonContent, "json");
            Assert.Empty(readResult.Diagnostic.Errors);
            return readResult.Document.Components.Schemas["TestSchema"];
        }

        [Fact]
        public async Task NullableEnumShouldRoundTripCorrectly()
        {
            var schema = new OpenApiSchema
            {
                Enum =
                [
                    JsonValue.Create(1),
                    JsonValue.Create(2),
                    JsonNullSentinel.JsonNull,
                ]
            };

            var actual = await schema.SerializeAsJsonAsync(OpenApiSpecVersion.OpenApi3_0);
            var deserializedSchema = ParseSchemaFromV30Document(actual);

            Assert.Equal(3, deserializedSchema.Enum.Count);
            Assert.Equal(1, deserializedSchema.Enum[0].GetValue<int>());
            Assert.Equal(2, deserializedSchema.Enum[1].GetValue<int>());
            Assert.True(deserializedSchema.Enum[2].IsJsonNullSentinel());
        }

        [Fact]
        public async Task TypeNullAloneAsV3ShouldRoundTripCorrectly()
        {
            var schema = new OpenApiSchema { Type = JsonSchemaType.Null };

            var actual = await schema.SerializeAsJsonAsync(OpenApiSpecVersion.OpenApi3_0);
            var expected =
                """
                {
                  "enum": [
                    null
                  ],
                  "nullable": true
                }
                """;
            Assert.True(JsonNode.DeepEquals(JsonNode.Parse(expected), JsonNode.Parse(actual)));

            var deserializedSchema = ParseSchemaFromV30Document(actual);

            Assert.Equal(JsonSchemaType.Null, deserializedSchema.Type);
            Assert.Null(deserializedSchema.Enum);
        }

        [Fact]
        public async Task NullableTypeAsV3ShouldRoundTripCorrectly()
        {
            var schema = new OpenApiSchema { Type = JsonSchemaType.String | JsonSchemaType.Null };

            var actual = await schema.SerializeAsJsonAsync(OpenApiSpecVersion.OpenApi3_0);
            var deserializedSchema = ParseSchemaFromV30Document(actual);

            Assert.Equal(JsonSchemaType.String | JsonSchemaType.Null, deserializedSchema.Type);
        }
    }
}
