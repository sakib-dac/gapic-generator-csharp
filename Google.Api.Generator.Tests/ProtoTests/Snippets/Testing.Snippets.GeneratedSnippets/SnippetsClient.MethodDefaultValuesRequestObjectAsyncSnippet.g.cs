﻿// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    // [START snippets_generated_Snippets_MethodDefaultValues_async]
    using Google.Api.Gax;
    using Google.Protobuf;
    using System.Threading.Tasks;
    using ts = Testing.Snippets;

    public sealed partial class GeneratedSnippetsClientSnippets
    {
        /// <summary>Snippet for MethodDefaultValuesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task MethodDefaultValuesRequestObjectAsync()
        {
            // Create client
            ts::SnippetsClient snippetsClient = await ts::SnippetsClient.CreateAsync();
            // Initialize request argument(s)
            ts::DefaultValuesRequest request = new ts::DefaultValuesRequest
            {
                SingleDouble = 0,
                SingleFloat = 0F,
                SingleInt32 = 0,
                SingleInt64 = 0L,
                SingleUint32 = 0U,
                SingleUint64 = 0UL,
                SingleSint32 = 0,
                SingleSint64 = 0L,
                SingleFixed32 = 0U,
                SingleFixed64 = 0UL,
                SingleSfixed32 = 0,
                SingleSfixed64 = 0L,
                SingleBool = false,
                SingleString = "",
                SingleBytes = ByteString.Empty,
                SingleMessage = new ts::AnotherMessage(),
                SingleNestedMessage = new ts::DefaultValuesRequest.Types.NestedMessage(),
                SingleEnum = ts::Enum.Default,
                SingleNestedEnum = ts::DefaultValuesRequest.Types.NestedEnum.DefaultValue,
                RepeatedDouble = { 0, },
                RepeatedFloat = { 0F, },
                RepeatedInt32 = { 0, },
                RepeatedInt64 = { 0L, },
                RepeatedUint32 = { 0U, },
                RepeatedUint64 = { 0UL, },
                RepeatedSint32 = { 0, },
                RepeatedSint64 = { 0L, },
                RepeatedFixed32 = { 0U, },
                RepeatedFixed64 = { 0UL, },
                RepeatedSfixed32 = { 0, },
                RepeatedSfixed64 = { 0L, },
                RepeatedBool = { false, },
                RepeatedString = { "", },
                RepeatedBytes = { ByteString.Empty, },
                RepeatedMessage =
                {
                    new ts::AnotherMessage(),
                },
                RepeatedNestedMessage =
                {
                    new ts::DefaultValuesRequest.Types.NestedMessage(),
                },
                RepeatedEnum = { ts::Enum.Default, },
                RepeatedNestedEnum =
                {
                    ts::DefaultValuesRequest.Types.NestedEnum.DefaultValue,
                },
                SingleResourceNameAsAResourceName = ts::AResourceName.FromItemPart("[ITEM_ID]", "[PART_ID]"),
                RepeatedResourceNameAsAResourceNames =
                {
                    ts::AResourceName.FromItemPart("[ITEM_ID]", "[PART_ID]"),
                },
                SingleWildcardResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                RepeatedWildcardResourceAsResourceNames =
                {
                    new UnparsedResourceName("a/wildcard/resource"),
                },
                MultiPatternResourceNameAsMultiPatternResourceName = ts::MultiPatternResourceName.FromRootAItem("[ROOT_A_ID]", "[ITEM_ID]"),
                RepeatedMultiPatternResourceNameAsMultiPatternResourceNames =
                {
                    ts::MultiPatternResourceName.FromRootAItem("[ROOT_A_ID]", "[ITEM_ID]"),
                },
                MapIntString = { { 0, "" }, },
                SingleWrappedDouble = 0,
                SingleWrappedFloat = 0F,
                SingleWrappedInt64 = 0L,
                SingleWrappedUint64 = 0UL,
                SingleWrappedInt32 = 0,
                SingleWrappedUint32 = 0U,
                SingleWrappedBool = false,
                SingleWrappedString = "",
                SingleWrappedBytes = ByteString.Empty,
                RepeatedWrappedDouble = { 0, },
                RepeatedWrappedFloat = { 0F, },
                RepeatedWrappedInt64 = { 0L, },
                RepeatedWrappedUint64 = { 0UL, },
                RepeatedWrappedInt32 = { 0, },
                RepeatedWrappedUint32 = { 0U, },
                RepeatedWrappedBool = { false, },
                RepeatedWrappedString = { "", },
                RepeatedWrappedBytes = { ByteString.Empty, },
            };
            // Make the request
            ts::Response response = await snippetsClient.MethodDefaultValuesAsync(request);
        }
    }
    // [END snippets_generated_Snippets_MethodDefaultValues_async]
}
