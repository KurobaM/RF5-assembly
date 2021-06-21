using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D16 RID: 3350
	[Token(Token = "0x20008A1")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x148260", Offset = "0x148361")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148260", Offset = "0x148361")]
	public class FullBodyBipedIK : IK
	{
		// Token: 0x060055CE RID: 21966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600477F")]
		[Address(RVA = "0x2C02E80", Offset = "0x2C02F81", VA = "0x2C02E80", Slot = "8")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA400", Offset = "0x1AA501")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x060055CF RID: 21967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004780")]
		[Address(RVA = "0x2C02ED0", Offset = "0x2C02FD1", VA = "0x2C02ED0", Slot = "9")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA440", Offset = "0x1AA541")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x060055D0 RID: 21968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004781")]
		[Address(RVA = "0x2C02F20", Offset = "0x2C03021", VA = "0x2C02F20")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA480", Offset = "0x1AA581")]
		private void OpenSetupTutorial()
		{
		}

		// Token: 0x060055D1 RID: 21969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004782")]
		[Address(RVA = "0x2C02F70", Offset = "0x2C03071", VA = "0x2C02F70")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA4C0", Offset = "0x1AA5C1")]
		private void OpenInspectorTutorial()
		{
		}

		// Token: 0x060055D2 RID: 21970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004783")]
		[Address(RVA = "0x2C02FC0", Offset = "0x2C030C1", VA = "0x2C02FC0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA500", Offset = "0x1AA601")]
		private void SupportGroup()
		{
		}

		// Token: 0x060055D3 RID: 21971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004784")]
		[Address(RVA = "0x2C03010", Offset = "0x2C03111", VA = "0x2C03010")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA540", Offset = "0x1AA641")]
		private void ASThread()
		{
		}

		// Token: 0x060055D4 RID: 21972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004785")]
		[Address(RVA = "0x2C03060", Offset = "0x2C03161", VA = "0x2C03060")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		// Token: 0x060055D5 RID: 21973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004786")]
		[Address(RVA = "0x2C030B0", Offset = "0x2C031B1", VA = "0x2C030B0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		// Token: 0x060055D6 RID: 21974 RVA: 0x0001C3F8 File Offset: 0x0001A5F8
		[Token(Token = "0x6004787")]
		[Address(RVA = "0x2C030C0", Offset = "0x2C031C1", VA = "0x2C030C0")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		// Token: 0x060055D7 RID: 21975 RVA: 0x0001C410 File Offset: 0x0001A610
		[Token(Token = "0x6004788")]
		[Address(RVA = "0x2C03290", Offset = "0x2C03391", VA = "0x2C03290")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		// Token: 0x060055D8 RID: 21976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004789")]
		[Address(RVA = "0x2C035F0", Offset = "0x2C036F1", VA = "0x2C035F0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA580", Offset = "0x1AA681")]
		private void Reinitiate()
		{
		}

		// Token: 0x060055D9 RID: 21977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600478A")]
		[Address(RVA = "0x2C03650", Offset = "0x2C03751", VA = "0x2C03650")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AA5C0", Offset = "0x1AA6C1")]
		private void AutoDetectReferences()
		{
		}

		// Token: 0x060055DA RID: 21978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600478B")]
		[Address(RVA = "0x2C03750", Offset = "0x2C03851", VA = "0x2C03750")]
		public FullBodyBipedIK()
		{
		}

		// Token: 0x0400B50A RID: 46346
		[Token(Token = "0x4008802")]
		[FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		// Token: 0x0400B50B RID: 46347
		[Token(Token = "0x4008803")]
		[FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;
	}
}
