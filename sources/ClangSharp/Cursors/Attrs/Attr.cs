// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using System;
using ClangSharp.Interop;

namespace ClangSharp
{
    public class Attr : Cursor
    {
        private protected Attr(CXCursor handle) : base(handle, handle.Kind)
        {
            if (handle.AttrKind == CX_AttrKind.CX_AttrKind_Invalid)
            {
                throw new ArgumentException(nameof(handle));
            }
        }

        internal static new Attr Create(CXCursor handle) => handle.AttrKind switch
        {
            CX_AttrKind.CX_AttrKind_AddressSpace => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_NoDeref => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCGC => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCInertUnsafeUnretained => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCKindOf => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_OpenCLConstantAddressSpace => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_OpenCLGenericAddressSpace => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_OpenCLGlobalAddressSpace => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_OpenCLLocalAddressSpace => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_OpenCLPrivateAddressSpace => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_Ptr32 => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_Ptr64 => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_SPtr => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_TypeNonNull => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_TypeNullUnspecified => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_TypeNullable => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_UPtr => new TypeAttr(handle),
            CX_AttrKind.CX_AttrKind_FallThrough => new StmtAttr(handle),
            CX_AttrKind.CX_AttrKind_Suppress => new StmtAttr(handle),
            CX_AttrKind.CX_AttrKind_AArch64VectorPcs => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AcquireHandle => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AnyX86NoCfCheck => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CDecl => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_FastCall => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_IntelOclBicc => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_LifetimeBound => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MSABI => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NSReturnsRetained => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCOwnership => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Pascal => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Pcs => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_PreserveAll => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_PreserveMost => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_RegCall => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_StdCall => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_SwiftCall => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_SysVABI => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ThisCall => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_VectorCall => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_SwiftContext => new ParameterABIAttr(handle),
            CX_AttrKind.CX_AttrKind_SwiftErrorResult => new ParameterABIAttr(handle),
            CX_AttrKind.CX_AttrKind_SwiftIndirectResult => new ParameterABIAttr(handle),
            CX_AttrKind.CX_AttrKind_Annotate => new InheritableParamAttr(handle),
            CX_AttrKind.CX_AttrKind_CFConsumed => new InheritableParamAttr(handle),
            CX_AttrKind.CX_AttrKind_CarriesDependency => new InheritableParamAttr(handle),
            CX_AttrKind.CX_AttrKind_NSConsumed => new InheritableParamAttr(handle),
            CX_AttrKind.CX_AttrKind_NonNull => new InheritableParamAttr(handle),
            CX_AttrKind.CX_AttrKind_OSConsumed => new InheritableParamAttr(handle),
            CX_AttrKind.CX_AttrKind_PassObjectSize => new InheritableParamAttr(handle),
            CX_AttrKind.CX_AttrKind_ReleaseHandle => new InheritableParamAttr(handle),
            CX_AttrKind.CX_AttrKind_UseHandle => new InheritableParamAttr(handle),
            CX_AttrKind.CX_AttrKind_AMDGPUFlatWorkGroupSize => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AMDGPUNumSGPR => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AMDGPUNumVGPR => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AMDGPUWavesPerEU => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ARMInterrupt => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AVRInterrupt => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AVRSignal => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AcquireCapability => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AcquiredAfter => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AcquiredBefore => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AlignMac68k => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Aligned => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AllocAlign => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AllocSize => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AlwaysDestroy => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AlwaysInline => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AnalyzerNoReturn => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AnyX86Interrupt => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AnyX86NoCallerSavedRegisters => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ArcWeakrefUnavailable => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ArgumentWithTypeTag => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ArmMveAlias => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Artificial => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AsmLabel => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AssertCapability => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AssertExclusiveLock => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AssertSharedLock => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AssumeAligned => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Availability => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_BPFPreserveAccessIndex => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Blocks => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_C11NoReturn => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CFAuditedTransfer => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CFGuard => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CFICanonicalJumpTable => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CFReturnsNotRetained => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CFReturnsRetained => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CFUnknownTransfer => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CPUDispatch => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CPUSpecific => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CUDAConstant => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CUDADevice => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CUDAGlobal => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CUDAHost => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CUDAInvalidTarget => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CUDALaunchBounds => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CUDAShared => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CXX11NoReturn => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CallableWhen => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Callback => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Capability => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CapturedRecord => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Cleanup => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_CodeSeg => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Cold => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Common => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Const => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ConstInit => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Constructor => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Consumable => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ConsumableAutoCast => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ConsumableSetOnRead => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Convergent => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_DLLExport => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_DLLExportStaticLocal => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_DLLImport => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_DLLImportStaticLocal => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Deprecated => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Destructor => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_DiagnoseIf => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_DisableTailCalls => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_EmptyBases => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_EnableIf => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_EnumExtensibility => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ExcludeFromExplicitInstantiation => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ExclusiveTrylockFunction => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ExternalSourceSymbol => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Final => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_FlagEnum => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Flatten => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Format => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_FormatArg => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_GNUInline => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_GuardedBy => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_GuardedVar => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_HIPPinnedShadow => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Hot => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_IBAction => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_IBOutlet => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_IBOutletCollection => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_InitPriority => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_InternalLinkage => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_LTOVisibilityPublic => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_LayoutVersion => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_LockReturned => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_LocksExcluded => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MIGServerRoutine => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MSAllocator => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MSInheritance => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MSNoVTable => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MSP430Interrupt => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MSStruct => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MSVtorDisp => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MaxFieldAlignment => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MayAlias => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MicroMips => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MinSize => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MinVectorWidth => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Mips16 => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MipsInterrupt => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MipsLongCall => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_MipsShortCall => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NSConsumesSelf => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NSReturnsAutoreleased => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NSReturnsNotRetained => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Naked => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoAlias => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoCommon => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoDebug => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoDestroy => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoDuplicate => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoInline => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoInstrumentFunction => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoMicroMips => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoMips16 => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoReturn => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoSanitize => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoSpeculativeLoadHardening => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoSplitStack => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoStackProtector => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoThreadSafetyAnalysis => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoThrow => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NoUniqueAddress => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_NotTailCalled => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_OMPAllocateDecl => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_OMPCaptureNoInit => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_OMPDeclareTargetDecl => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_OMPDeclareVariant => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_OMPThreadPrivateDecl => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_OSConsumesThis => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_OSReturnsNotRetained => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_OSReturnsRetained => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_OSReturnsRetainedOnNonZero => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_OSReturnsRetainedOnZero => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCBridge => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCBridgeMutable => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCBridgeRelated => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCException => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCExplicitProtocolImpl => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCExternallyRetained => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCIndependentClass => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCMethodFamily => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCNSObject => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCPreciseLifetime => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCRequiresPropertyDefs => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCRequiresSuper => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCReturnsInnerPointer => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCRootClass => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ObjCSubclassingRestricted => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_OpenCLIntelReqdSubGroupSize => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_OpenCLKernel => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_OpenCLUnrollHint => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_OptimizeNone => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Override => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Owner => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Ownership => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Packed => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ParamTypestate => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_PatchableFunctionEntry => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Pointer => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_PragmaClangBSSSection => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_PragmaClangDataSection => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_PragmaClangRelroSection => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_PragmaClangRodataSection => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_PragmaClangTextSection => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_PtGuardedBy => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_PtGuardedVar => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Pure => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_RISCVInterrupt => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Reinitializes => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ReleaseCapability => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ReqdWorkGroupSize => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_RequiresCapability => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Restrict => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ReturnTypestate => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ReturnsNonNull => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ReturnsTwice => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_SYCLKernel => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_ScopedLockable => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Section => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_SelectAny => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Sentinel => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_SetTypestate => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_SharedTrylockFunction => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_SpeculativeLoadHardening => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_TLSModel => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Target => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_TestTypestate => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_TransparentUnion => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_TrivialABI => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_TryAcquireCapability => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_TypeTagForDatatype => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_TypeVisibility => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Unavailable => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Uninitialized => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Unused => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Used => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Uuid => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_VecReturn => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_VecTypeHint => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Visibility => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_WarnUnused => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_WarnUnusedResult => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_Weak => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_WeakImport => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_WeakRef => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_WebAssemblyExportName => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_WebAssemblyImportModule => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_WebAssemblyImportName => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_WorkGroupSizeHint => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_X86ForceAlignArgPointer => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_XRayInstrument => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_XRayLogArgs => new InheritableAttr(handle),
            CX_AttrKind.CX_AttrKind_AbiTag => new Attr(handle),
            CX_AttrKind.CX_AttrKind_Alias => new Attr(handle),
            CX_AttrKind.CX_AttrKind_AlignValue => new Attr(handle),
            CX_AttrKind.CX_AttrKind_IFunc => new Attr(handle),
            CX_AttrKind.CX_AttrKind_InitSeg => new Attr(handle),
            CX_AttrKind.CX_AttrKind_LoopHint => new Attr(handle),
            CX_AttrKind.CX_AttrKind_Mode => new Attr(handle),
            CX_AttrKind.CX_AttrKind_NoBuiltin => new Attr(handle),
            CX_AttrKind.CX_AttrKind_NoEscape => new Attr(handle),
            CX_AttrKind.CX_AttrKind_OMPCaptureKind => new Attr(handle),
            CX_AttrKind.CX_AttrKind_OMPDeclareSimdDecl => new Attr(handle),
            CX_AttrKind.CX_AttrKind_OMPReferencedVar => new Attr(handle),
            CX_AttrKind.CX_AttrKind_ObjCBoxable => new Attr(handle),
            CX_AttrKind.CX_AttrKind_ObjCClassStub => new Attr(handle),
            CX_AttrKind.CX_AttrKind_ObjCDesignatedInitializer => new Attr(handle),
            CX_AttrKind.CX_AttrKind_ObjCDirect => new Attr(handle),
            CX_AttrKind.CX_AttrKind_ObjCDirectMembers => new Attr(handle),
            CX_AttrKind.CX_AttrKind_ObjCNonLazyClass => new Attr(handle),
            CX_AttrKind.CX_AttrKind_ObjCRuntimeName => new Attr(handle),
            CX_AttrKind.CX_AttrKind_ObjCRuntimeVisible => new Attr(handle),
            CX_AttrKind.CX_AttrKind_OpenCLAccess => new Attr(handle),
            CX_AttrKind.CX_AttrKind_Overloadable => new Attr(handle),
            CX_AttrKind.CX_AttrKind_RenderScriptKernel => new Attr(handle),
            CX_AttrKind.CX_AttrKind_Thread => new Attr(handle),
            _ => new Attr(handle),
        };

        public CX_AttrKind Kind => Handle.AttrKind;

        public string KindSpelling => Handle.AttrKindSpelling;
    }
}
