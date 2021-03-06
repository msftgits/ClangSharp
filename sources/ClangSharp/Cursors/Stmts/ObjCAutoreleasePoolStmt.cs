// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using System.Diagnostics;
using ClangSharp.Interop;

namespace ClangSharp
{
    public sealed class ObjCAutoreleasePoolStmt : Stmt
    {
        internal ObjCAutoreleasePoolStmt(CXCursor handle) : base(handle, CXCursorKind.CXCursor_ObjCAutoreleasePoolStmt, CX_StmtClass.CX_StmtClass_ObjCAutoreleasePoolStmt)
        {
            Debug.Assert(NumChildren is 1);
        }

        public Stmt SubStmt => Children[0];
    }
}
