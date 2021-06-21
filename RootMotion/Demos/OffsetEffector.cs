using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CCD RID: 3277
	[Token(Token = "0x200086B")]
	public class OffsetEffector : OffsetModifier
	{
		// Token: 0x0600540B RID: 21515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004613")]
		[Address(RVA = "0x285EAA0", Offset = "0x285EBA1", VA = "0x285EAA0", Slot = "5")]
		protected override void Start()
		{
		}

		// Token: 0x0600540C RID: 21516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004614")]
		[Address(RVA = "0x285EBC0", Offset = "0x285ECC1", VA = "0x285EBC0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		// Token: 0x0600540D RID: 21517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004615")]
		[Address(RVA = "0x285EDF0", Offset = "0x285EEF1", VA = "0x285EDF0")]
		public OffsetEffector()
		{
		}

		// Token: 0x0400B32C RID: 45868
		[Token(Token = "0x400868D")]
		[FieldOffset(Offset = "0x30")]
		public OffsetEffector.EffectorLink[] effectorLinks;

		// Token: 0x02000CCE RID: 3278
		[Token(Token = "0x20013DB")]
		[Serializable]
		public class EffectorLink
		{
			// Token: 0x0600540E RID: 21518 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60078C2")]
			[Address(RVA = "0x285EE00", Offset = "0x285EF01", VA = "0x285EE00")]
			public EffectorLink()
			{
			}

			// Token: 0x0400B32D RID: 45869
			[Token(Token = "0x401B8E3")]
			[FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			// Token: 0x0400B32E RID: 45870
			[Token(Token = "0x401B8E4")]
			[FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			// Token: 0x0400B32F RID: 45871
			[Token(Token = "0x401B8E5")]
			[FieldOffset(Offset = "0x18")]
			[Attribute(Name = "HideInInspector", RVA = "0x195AD0", Offset = "0x195BD1")]
			public Vector3 localPosition;
		}
	}
}
