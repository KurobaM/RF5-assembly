using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D79 RID: 3449
	[Token(Token = "0x20008D8")]
	[Attribute(Name = "HelpURLAttribute", RVA = "0x1488B0", Offset = "0x1489B1")]
	[Attribute(Name = "AddComponentMenu", RVA = "0x1488B0", Offset = "0x1489B1")]
	public class RotationLimitSpline : RotationLimit
	{
		// Token: 0x06005995 RID: 22933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A43")]
		[Address(RVA = "0x27CE380", Offset = "0x27CE481", VA = "0x27CE380")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB7F0", Offset = "0x1AB8F1")]
		private void OpenUserManual()
		{
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A44")]
		[Address(RVA = "0x27CE3D0", Offset = "0x27CE4D1", VA = "0x27CE3D0")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB830", Offset = "0x1AB931")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A45")]
		[Address(RVA = "0x27CE420", Offset = "0x27CE521", VA = "0x27CE420")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB870", Offset = "0x1AB971")]
		private void SupportGroup()
		{
		}

		// Token: 0x06005998 RID: 22936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A46")]
		[Address(RVA = "0x27CE470", Offset = "0x27CE571", VA = "0x27CE470")]
		[Attribute(Name = "ContextMenu", RVA = "0x1AB8B0", Offset = "0x1AB9B1")]
		private void ASThread()
		{
		}

		// Token: 0x06005999 RID: 22937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A47")]
		[Address(RVA = "0x27CE4C0", Offset = "0x27CE5C1", VA = "0x27CE4C0")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		// Token: 0x0600599A RID: 22938 RVA: 0x0001D820 File Offset: 0x0001BA20
		[Token(Token = "0x6004A48")]
		[Address(RVA = "0x27CE4E0", Offset = "0x27CE5E1", VA = "0x27CE4E0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x0600599B RID: 22939 RVA: 0x0001D838 File Offset: 0x0001BA38
		[Token(Token = "0x6004A49")]
		[Address(RVA = "0x27CE5A0", Offset = "0x27CE6A1", VA = "0x27CE5A0")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x0600599C RID: 22940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A4A")]
		[Address(RVA = "0x27CE8D0", Offset = "0x27CE9D1", VA = "0x27CE8D0")]
		public RotationLimitSpline()
		{
		}

		// Token: 0x0400B8B7 RID: 47287
		[Token(Token = "0x4008A47")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "RangeAttribute", RVA = "0x17BAF0", Offset = "0x17BBF1")]
		public float twistLimit;

		// Token: 0x0400B8B8 RID: 47288
		[Token(Token = "0x4008A48")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Attribute(Name = "HideInInspector", RVA = "0x17BB10", Offset = "0x17BC11")]
		public AnimationCurve spline;
	}
}
