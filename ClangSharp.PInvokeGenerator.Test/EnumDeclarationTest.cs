﻿using System.Threading.Tasks;
using Xunit;

namespace ClangSharp.Test
{
    public sealed class EnumDeclarationTest : PInvokeGeneratorTest
    {
        [Fact]
        public async Task BasicTest()
        {
            var inputContents = @"enum MyEnum
{
    MyEnum_Value0,
    MyEnum_Value1,
    MyEnum_Value2,
};
";

            var expectedOutputContents = @"namespace ClangSharp.Test
{
    public enum MyEnum
    {
        MyEnum_Value0,
        MyEnum_Value1,
        MyEnum_Value2,
    }
}
";

            await ValidateGeneratedBindings(inputContents, expectedOutputContents);
        }

        [Fact]
        public async Task BasicValueTest()
        {
            var inputContents = @"enum MyEnum
{
    MyEnum_Value1 = 1,
    MyEnum_Value2,
    MyEnum_Value3,
};
";

            var expectedOutputContents = @"namespace ClangSharp.Test
{
    public enum MyEnum
    {
        MyEnum_Value1 = 1,
        MyEnum_Value2,
        MyEnum_Value3,
    }
}
";

            await ValidateGeneratedBindings(inputContents, expectedOutputContents);
        }

        [Fact]
        public async Task ExcludeTest()
        {
            var inputContents = "typedef enum MyEnum MyEnum;";
            var expectedOutputContents = string.Empty;
            await ValidateGeneratedBindings(inputContents, expectedOutputContents, excludedNames: "MyEnum");
        }

        [Theory]
        [InlineData("unsigned char", "byte")]
        [InlineData("short", "short")]
        [InlineData("long long", "long")]
        [InlineData("char", "sbyte")]
        [InlineData("unsigned short", "ushort")]
        [InlineData("unsigned int", "uint")]
        [InlineData("unsigned long long", "ulong")]
        public async Task ExplicitTypedTest(string nativeType, string expectedManagedType)
        {
            var inputContents = $@"enum MyEnum : {nativeType}
{{
    MyEnum_Value0,
    MyEnum_Value1,
    MyEnum_Value2,
}};
";

            var expectedOutputContents = $@"namespace ClangSharp.Test
{{
    public enum MyEnum : {expectedManagedType}
    {{
        MyEnum_Value0,
        MyEnum_Value1,
        MyEnum_Value2,
    }}
}}
";

            await ValidateGeneratedBindings(inputContents, expectedOutputContents);
        }

        [Fact]
        public async Task NoDefinitionTest()
        {
            var inputContents = "typedef enum MyEnum MyEnum;";

            var expectedOutputContents = $@"namespace ClangSharp.Test
{{
    public enum MyEnum
    {{
    }}
}}
";

            await ValidateGeneratedBindings(inputContents, expectedOutputContents);
        }

        [Fact]
        public async Task SkipNonDefinitionTest()
        {
            var inputContents = $@"typedef enum MyEnum MyEnum;

enum MyEnum
{{
    MyEnum_Value0,
    MyEnum_Value1,
    MyEnum_Value2,
}};
";

            var expectedOutputContents = $@"namespace ClangSharp.Test
{{
    public enum MyEnum
    {{
        MyEnum_Value0,
        MyEnum_Value1,
        MyEnum_Value2,
    }}
}}
";

            await ValidateGeneratedBindings(inputContents, expectedOutputContents);
        }
    }
}
