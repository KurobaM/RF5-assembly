using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D03 RID: 3331
	[Token(Token = "0x2000894")]
	public class FingerRig : SolverManager
	{
		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06005507 RID: 21767 RVA: 0x0001C020 File Offset: 0x0001A220
		// (set) Token: 0x06005508 RID: 21768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A9")]
		public bool initiated
		{
			[Token(Token = "0x60046EB")]
			[Address(RVA = "0x2C02300", Offset = "0x2C02401", VA = "0x2C02300")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9AA0", Offset = "0x1A9BA1")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60046EC")]
			[Address(RVA = "0x2C02310", Offset = "0x2C02411", VA = "0x2C02310")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1A9AB0", Offset = "0x1A9BB1")]
			private set
			{
			}
		}

		// Token: 0x06005509 RID: 21769 RVA: 0x0001C038 File Offset: 0x0001A238
		[Token(Token = "0x60046ED")]
		[Address(RVA = "0x2C02320", Offset = "0x2C02421", VA = "0x2C02320")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x0600550A RID: 21770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046EE")]
		[Address(RVA = "0x2C023B0", Offset = "0x2C024B1", VA = "0x2C023B0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9AC0", Offset = "0x1A9BC1")]
		public void AutoDetect()
		{
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046EF")]
		[Address(RVA = "0x2C02740", Offset = "0x2C02841", VA = "0x2C02740")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		// Token: 0x0600550C RID: 21772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F0")]
		[Address(RVA = "0x2C02900", Offset = "0x2C02A01", VA = "0x2C02900")]
		public void RemoveFinger(int index)
		{
		}

		// Token: 0x0600550D RID: 21773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F1")]
		[Address(RVA = "0x2C02620", Offset = "0x2C02721", VA = "0x2C02620")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F2")]
		[Address(RVA = "0x2C02AB0", Offset = "0x2C02BB1", VA = "0x2C02AB0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F3")]
		[Address(RVA = "0x2C02B90", Offset = "0x2C02C91", VA = "0x2C02B90")]
		public void UpdateFingerSolvers()
		{
		}

		// Token: 0x06005510 RID: 21776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F4")]
		[Address(RVA = "0x2C02C10", Offset = "0x2C02D11", VA = "0x2C02C10")]
		public void FixFingerTransforms()
		{
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F5")]
		[Address(RVA = "0x2C02C90", Offset = "0x2C02D91", VA = "0x2C02C90")]
		public void StoreDefaultLocalState()
		{
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F6")]
		[Address(RVA = "0x2C02D00", Offset = "0x2C02E01", VA = "0x2C02D00", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		// Token: 0x06005513 RID: 21779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F7")]
		[Address(RVA = "0x2C02D80", Offset = "0x2C02E81", VA = "0x2C02D80", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		// Token: 0x06005514 RID: 21780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046F8")]
		[Address(RVA = "0x2C02E00", Offset = "0x2C02F01", VA = "0x2C02E00")]
		public FingerRig()
		{
		}

		// Token: 0x0400B481 RID: 46209
		[Token(Token = "0x40087A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178AB0", Offset = "0x178BB1")]
		[Attribute(Name = "RangeAttribute", RVA = "0x178AB0", Offset = "0x178BB1")]
		public float weight;

		// Token: 0x0400B482 RID: 46210
		[Token(Token = "0x40087A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		// Token: 0x0400B483 RID: 46211
		[Token(Token = "0x40087A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x178B10", Offset = "0x178C11")]
		private bool <initiated>k__BackingField;
	}
}
