using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D75 RID: 3445
	[Token(Token = "0x20008D6")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x1487F0", Offset = "0x1488F1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x1487F0", Offset = "0x1488F1")]
	public class RotationLimitHinge : RotationLimit
	{
		// Token: 0x06005976 RID: 22902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2C")]
		[Address(RVA = "0x27CBBF0", Offset = "0x27CBCF1", VA = "0x27CBBF0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB5F0", Offset = "0x1AB6F1")]
		private void OpenUserManual()
		{
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2D")]
		[Address(RVA = "0x27CBC40", Offset = "0x27CBD41", VA = "0x27CBC40")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB630", Offset = "0x1AB731")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2E")]
		[Address(RVA = "0x27CBC90", Offset = "0x27CBD91", VA = "0x27CBC90")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB670", Offset = "0x1AB771")]
		private void SupportGroup()
		{
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2F")]
		[Address(RVA = "0x27CBCE0", Offset = "0x27CBDE1", VA = "0x27CBCE0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB6B0", Offset = "0x1AB7B1")]
		private void ASThread()
		{
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x0001D6E8 File Offset: 0x0001B8E8
		[Token(Token = "0x6004A30")]
		[Address(RVA = "0x27CBD30", Offset = "0x27CBE31", VA = "0x27CBD30", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x0001D700 File Offset: 0x0001B900
		[Token(Token = "0x6004A31")]
		[Address(RVA = "0x27CBD60", Offset = "0x27CBE61", VA = "0x27CBD60")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A32")]
		[Address(RVA = "0x27CC060", Offset = "0x27CC161", VA = "0x27CC060")]
		public RotationLimitHinge()
		{
		}

		// Token: 0x0400B8A6 RID: 47270
		[Token(Token = "0x4008A3C")]
		[FieldOffset(Offset = "0x38")]
		public bool useLimits;

		// Token: 0x0400B8A7 RID: 47271
		[Token(Token = "0x4008A3D")]
		[FieldOffset(Offset = "0x3C")]
		public float min;

		// Token: 0x0400B8A8 RID: 47272
		[Token(Token = "0x4008A3E")]
		[FieldOffset(Offset = "0x40")]
		public float max;

		// Token: 0x0400B8A9 RID: 47273
		[Token(Token = "0x4008A3F")]
		[FieldOffset(Offset = "0x44")]
		[Attribute(Name = "HideInInspector", RVA = "0x17B9E0", Offset = "0x17BAE1")]
		public float zeroAxisDisplayOffset;

		// Token: 0x0400B8AA RID: 47274
		[Token(Token = "0x4008A40")]
		[FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		// Token: 0x0400B8AB RID: 47275
		[Token(Token = "0x4008A41")]
		[FieldOffset(Offset = "0x58")]
		private float lastAngle;
	}
}
