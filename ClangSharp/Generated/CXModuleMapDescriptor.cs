namespace ClangSharp
{
    using System;
    using System.Runtime.InteropServices;

    public partial struct CXModuleMapDescriptor
    {
        public CXModuleMapDescriptor(IntPtr pointer)
        {
            Pointer = pointer;
        }

        public IntPtr Pointer;
    }
}
