using System;
using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D1C RID: 3356
	[Token(Token = "0x20008A7")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x1483E0", Offset = "0x1484E1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x1483E0", Offset = "0x1484E1")]
	public class TrigonometricIK : IK
	{
		// Token: 0x060055FB RID: 22011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047AC")]
		[Address(RVA = "0x27CFA90", Offset = "0x27CFB91", VA = "0x27CFA90", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA900", Offset = "0x1AAA01")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060055FC RID: 22012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047AD")]
		[Address(RVA = "0x27CFAE0", Offset = "0x27CFBE1", VA = "0x27CFAE0", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA940", Offset = "0x1AAA41")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060055FD RID: 22013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047AE")]
		[Address(RVA = "0x27CFB30", Offset = "0x27CFC31", VA = "0x27CFB30")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA980", Offset = "0x1AAA81")]
		private void SupportGroup()
		{
		}

		// Token: 0x060055FE RID: 22014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047AF")]
		[Address(RVA = "0x27CFB80", Offset = "0x27CFC81", VA = "0x27CFB80")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA9C0", Offset = "0x1AAAC1")]
		private void ASThread()
		{
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047B0")]
		[Address(RVA = "0x27CFBD0", Offset = "0x27CFCD1", VA = "0x27CFBD0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047B1")]
		[Address(RVA = "0x27CFBE0", Offset = "0x27CFCE1", VA = "0x27CFBE0")]
		public TrigonometricIK()
		{
		}

		// Token: 0x0400B512 RID: 46354
		[Token(Token = "0x400880A")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;
	}
}
