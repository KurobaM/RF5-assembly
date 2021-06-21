using System;
using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D15 RID: 3349
	[Token(Token = "0x20008A0")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x148200", Offset = "0x148301")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148200", Offset = "0x148301")]
	public class FABRIKRoot : IK
	{
		// Token: 0x060055C8 RID: 21960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004779")]
		[Address(RVA = "0x2872F40", Offset = "0x2873041", VA = "0x2872F40", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA300", Offset = "0x1AA401")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600477A")]
		[Address(RVA = "0x2872F90", Offset = "0x2873091", VA = "0x2872F90", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA340", Offset = "0x1AA441")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600477B")]
		[Address(RVA = "0x2872FE0", Offset = "0x28730E1", VA = "0x2872FE0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA380", Offset = "0x1AA481")]
		private void SupportGroup()
		{
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600477C")]
		[Address(RVA = "0x2873030", Offset = "0x2873131", VA = "0x2873030")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA3C0", Offset = "0x1AA4C1")]
		private void ASThread()
		{
		}

		// Token: 0x060055CC RID: 21964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600477D")]
		[Address(RVA = "0x2873080", Offset = "0x2873181", VA = "0x2873080", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x060055CD RID: 21965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600477E")]
		[Address(RVA = "0x2873090", Offset = "0x2873191", VA = "0x2873090")]
		public FABRIKRoot()
		{
		}

		// Token: 0x0400B509 RID: 46345
		[Token(Token = "0x4008801")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;
	}
}
