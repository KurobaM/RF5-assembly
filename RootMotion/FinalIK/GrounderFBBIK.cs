using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D07 RID: 3335
	[Token(Token = "0x2000897")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x147F00", Offset = "0x148001")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x147F00", Offset = "0x148001")]
	public class GrounderFBBIK : Grounder
	{
		// Token: 0x0600552F RID: 21807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600470F")]
		[Address(RVA = "0x2C06110", Offset = "0x2C06211", VA = "0x2C06110")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9BA0", Offset = "0x1A9CA1")]
		private void OpenTutorial()
		{
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004710")]
		[Address(RVA = "0x2C06160", Offset = "0x2C06261", VA = "0x2C06160", Slot = "5")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9BE0", Offset = "0x1A9CE1")]
		protected override void OpenUserManual()
		{
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004711")]
		[Address(RVA = "0x2C061B0", Offset = "0x2C062B1", VA = "0x2C061B0", Slot = "6")]
		[Attribute(Name = "ContextMenu", RVA = "0x1A9C20", Offset = "0x1A9D21")]
		protected override void OpenScriptReference()
		{
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004712")]
		[Address(RVA = "0x2C06200", Offset = "0x2C06301", VA = "0x2C06200", Slot = "4")]
		public override void ResetPosition()
		{
		}

		// Token: 0x06005533 RID: 21811 RVA: 0x0001C0C8 File Offset: 0x0001A2C8
		[Token(Token = "0x6004713")]
		[Address(RVA = "0x2C06280", Offset = "0x2C06381", VA = "0x2C06280")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		// Token: 0x06005534 RID: 21812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004714")]
		[Address(RVA = "0x2C06320", Offset = "0x2C06421", VA = "0x2C06320")]
		private void Update()
		{
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004715")]
		[Address(RVA = "0x2C06620", Offset = "0x2C06721", VA = "0x2C06620")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004716")]
		[Address(RVA = "0x2C06630", Offset = "0x2C06731", VA = "0x2C06630")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005537 RID: 21815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004717")]
		[Address(RVA = "0x2C063E0", Offset = "0x2C064E1", VA = "0x2C063E0")]
		private void Initiate()
		{
		}

		// Token: 0x06005538 RID: 21816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004718")]
		[Address(RVA = "0x2C06640", Offset = "0x2C06741", VA = "0x2C06640")]
		private void OnSolverUpdate()
		{
		}

		// Token: 0x06005539 RID: 21817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004719")]
		[Address(RVA = "0x2C06AE0", Offset = "0x2C06BE1", VA = "0x2C06AE0")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		// Token: 0x0600553A RID: 21818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471A")]
		[Address(RVA = "0x2C06CA0", Offset = "0x2C06DA1", VA = "0x2C06CA0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x0600553B RID: 21819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471B")]
		[Address(RVA = "0x2C06E00", Offset = "0x2C06F01", VA = "0x2C06E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600553C RID: 21820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600471C")]
		[Address(RVA = "0x2C06F30", Offset = "0x2C07031", VA = "0x2C06F30")]
		public GrounderFBBIK()
		{
		}

		// Token: 0x0400B492 RID: 46226
		[Token(Token = "0x40087B1")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178C90", Offset = "0x178D91")]
		public FullBodyBipedIK ik;

		// Token: 0x0400B493 RID: 46227
		[Token(Token = "0x40087B2")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178CD0", Offset = "0x178DD1")]
		public float spineBend;

		// Token: 0x0400B494 RID: 46228
		[Token(Token = "0x40087B3")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178D10", Offset = "0x178E11")]
		public float spineSpeed;

		// Token: 0x0400B495 RID: 46229
		[Token(Token = "0x40087B4")]
		[FieldOffset(Offset = "0x50")]
		public GrounderFBBIK.SpineEffector[] spine;

		// Token: 0x0400B496 RID: 46230
		[Token(Token = "0x40087B5")]
		[FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		// Token: 0x0400B497 RID: 46231
		[Token(Token = "0x40087B6")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		// Token: 0x0400B498 RID: 46232
		[Token(Token = "0x40087B7")]
		[FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		// Token: 0x02000D08 RID: 3336
		[Token(Token = "0x20013E9")]
		[Serializable]
		public class SpineEffector
		{
			// Token: 0x0600553D RID: 21821 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078EA")]
			[Address(RVA = "0x2C07090", Offset = "0x2C07191", VA = "0x2C07090")]
			public SpineEffector()
			{
			}

			// Token: 0x0600553E RID: 21822 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078EB")]
			[Address(RVA = "0x2C070A0", Offset = "0x2C071A1", VA = "0x2C070A0")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}

			// Token: 0x0400B499 RID: 46233
			[Token(Token = "0x401B925")]
			[FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195AE0", Offset = "0x195BE1")]
			public FullBodyBipedEffector effectorType;

			// Token: 0x0400B49A RID: 46234
			[Token(Token = "0x401B926")]
			[FieldOffset(Offset = "0x14")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195B20", Offset = "0x195C21")]
			public float horizontalWeight;

			// Token: 0x0400B49B RID: 46235
			[Token(Token = "0x401B927")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x195B60", Offset = "0x195C61")]
			public float verticalWeight;
		}
	}
}
