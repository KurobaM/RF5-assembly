using System;
using Il2CppDummyDll;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D11 RID: 3345
	[Token(Token = "0x200089C")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x148080", Offset = "0x148181")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148080", Offset = "0x148181")]
	public class AimIK : IK
	{
		// Token: 0x060055AF RID: 21935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004760")]
		[Address(RVA = "0x2867FB0", Offset = "0x28680B1", VA = "0x2867FB0", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9EC0", Offset = "0x1A9FC1")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060055B0 RID: 21936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004761")]
		[Address(RVA = "0x2868000", Offset = "0x2868101", VA = "0x2868000", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9F00", Offset = "0x1AA001")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060055B1 RID: 21937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004762")]
		[Address(RVA = "0x2868050", Offset = "0x2868151", VA = "0x2868050")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9F40", Offset = "0x1AA041")]
		private void OpenSetupTutorial()
		{
		}

		// Token: 0x060055B2 RID: 21938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004763")]
		[Address(RVA = "0x28680A0", Offset = "0x28681A1", VA = "0x28680A0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9F80", Offset = "0x1AA081")]
		private void SupportGroup()
		{
		}

		// Token: 0x060055B3 RID: 21939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004764")]
		[Address(RVA = "0x28680F0", Offset = "0x28681F1", VA = "0x28680F0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9FC0", Offset = "0x1AA0C1")]
		private void ASThread()
		{
		}

		// Token: 0x060055B4 RID: 21940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004765")]
		[Address(RVA = "0x2868140", Offset = "0x2868241", VA = "0x2868140", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x060055B5 RID: 21941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004766")]
		[Address(RVA = "0x2868150", Offset = "0x2868251", VA = "0x2868150")]
		public AimIK()
		{
		}

		// Token: 0x0400B505 RID: 46341
		[Token(Token = "0x40087FD")]
		[FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;
	}
}
