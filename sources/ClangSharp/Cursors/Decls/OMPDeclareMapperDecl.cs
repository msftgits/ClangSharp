// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using ClangSharp.Interop;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClangSharp
{
    public sealed class OMPDeclareMapperDecl : ValueDecl, IDeclContext
    {
        private readonly Lazy<IReadOnlyList<Decl>> _decls;

        internal OMPDeclareMapperDecl(CXCursor handle) : base(handle, CXCursorKind.CXCursor_UnexposedDecl, CX_DeclKind.CX_DeclKind_OMPDeclareMapper)
        {
            _decls = new Lazy<IReadOnlyList<Decl>>(() => CursorChildren.OfType<Decl>().ToList());
        }

        public IReadOnlyList<Decl> Decls => _decls.Value;
    }
}
