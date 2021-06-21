using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D0C RID: 3340
	[Token(Token = "0x200089A")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x148020", Offset = "0x148121")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x148020", Offset = "0x148121")]
	public class GrounderVRIK : Grounder
	{
		// Token: 0x0600555E RID: 21854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600473B")]
		[Address(RVA = "0x2C0B0E0", Offset = "0x2C0B1E1", VA = "0x2C0B0E0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9D60", Offset = "0x1A9E61")]
		private void OpenTutorial()
		{
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600473C")]
		[Address(RVA = "0x2C0B130", Offset = "0x2C0B231", VA = "0x2C0B130", Slot = "5")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9DA0", Offset = "0x1A9EA1")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600473D")]
		[Address(RVA = "0x2C0B180", Offset = "0x2C0B281", VA = "0x2C0B180", Slot = "6")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9DE0", Offset = "0x1A9EE1")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600473E")]
		[Address(RVA = "0x2C0B1D0", Offset = "0x2C0B2D1", VA = "0x2C0B1D0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x0001C128 File Offset: 0x0001A328
		[Token(Token = "0x600473F")]
		[Address(RVA = "0x2C0B1F0", Offset = "0x2C0B2F1", VA = "0x2C0B1F0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		// Token: 0x06005563 RID: 21859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004740")]
		[Address(RVA = "0x2C0B290", Offset = "0x2C0B391", VA = "0x2C0B290")]
		private void Update()
		{
		}

		// Token: 0x06005564 RID: 21860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004741")]
		[Address(RVA = "0x2C0B350", Offset = "0x2C0B451", VA = "0x2C0B350")]
		private void Initiate()
		{
		}

		// Token: 0x06005565 RID: 21861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004742")]
		[Address(RVA = "0x2C0B5A0", Offset = "0x2C0B6A1", VA = "0x2C0B5A0")]
		private void OnSolverUpdate()
		{
		}

		// Token: 0x06005566 RID: 21862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004743")]
		[Address(RVA = "0x2C0B840", Offset = "0x2C0B941", VA = "0x2C0B840")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		// Token: 0x06005567 RID: 21863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004744")]
		[Address(RVA = "0x2C0B950", Offset = "0x2C0BA51", VA = "0x2C0B950")]
		private void OnPostSolverUpdate()
		{
		}

		// Token: 0x06005568 RID: 21864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004745")]
		[Address(RVA = "0x2C0BB50", Offset = "0x2C0BC51", VA = "0x2C0BB50")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06005569 RID: 21865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004746")]
		[Address(RVA = "0x2C0BCB0", Offset = "0x2C0BDB1", VA = "0x2C0BCB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600556A RID: 21866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004747")]
		[Address(RVA = "0x2C0BE50", Offset = "0x2C0BF51", VA = "0x2C0BE50")]
		public GrounderVRIK()
		{
		}

		// Token: 0x0400B4CB RID: 46283
		[Token(Token = "0x40087E3")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x179240", Offset = "0x179341")]
		public VRIK ik;

		// Token: 0x0400B4CC RID: 46284
		[Token(Token = "0x40087E4")]
		[FieldOffset(Offset = "0x48")]
		private Transform[] feet;
	}
}
