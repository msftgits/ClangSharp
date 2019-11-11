// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

namespace ClangSharp.Interop
{
    public enum CXCompletionChunkKind
    {
        CXCompletionChunk_Optional,
        CXCompletionChunk_TypedText,
        CXCompletionChunk_Text,
        CXCompletionChunk_Placeholder,
        CXCompletionChunk_Informative,
        CXCompletionChunk_CurrentParameter,
        CXCompletionChunk_LeftParen,
        CXCompletionChunk_RightParen,
        CXCompletionChunk_LeftBracket,
        CXCompletionChunk_RightBracket,
        CXCompletionChunk_LeftBrace,
        CXCompletionChunk_RightBrace,
        CXCompletionChunk_LeftAngle,
        CXCompletionChunk_RightAngle,
        CXCompletionChunk_Comma,
        CXCompletionChunk_ResultType,
        CXCompletionChunk_Colon,
        CXCompletionChunk_SemiColon,
        CXCompletionChunk_Equal,
        CXCompletionChunk_HorizontalSpace,
        CXCompletionChunk_VerticalSpace,
    }
}
