using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CE5 RID: 3301
	[Token(Token = "0x200087D")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		// Token: 0x0600546B RID: 21611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004655")]
		[Address(RVA = "0x28661B0", Offset = "0x28662B1", VA = "0x28661B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600546C RID: 21612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004656")]
		[Address(RVA = "0x2866360", Offset = "0x2866461", VA = "0x2866360")]
		public VRIKCalibrationController()
		{
		}

		// Token: 0x0400B399 RID: 45977
		[Token(Token = "0x40086D7")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178000", Offset = "0x178101")]
		public VRIK ik;

		// Token: 0x0400B39A RID: 45978
		[Token(Token = "0x40086D8")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178040", Offset = "0x178141")]
		public VRIKCalibrator.Settings settings;

		// Token: 0x0400B39B RID: 45979
		[Token(Token = "0x40086D9")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178080", Offset = "0x178181")]
		public Transform headTracker;

		// Token: 0x0400B39C RID: 45980
		[Token(Token = "0x40086DA")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1780C0", Offset = "0x1781C1")]
		public Transform bodyTracker;

		// Token: 0x0400B39D RID: 45981
		[Token(Token = "0x40086DB")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178100", Offset = "0x178201")]
		public Transform leftHandTracker;

		// Token: 0x0400B39E RID: 45982
		[Token(Token = "0x40086DC")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178140", Offset = "0x178241")]
		public Transform rightHandTracker;

		// Token: 0x0400B39F RID: 45983
		[Token(Token = "0x40086DD")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x178180", Offset = "0x178281")]
		public Transform leftFootTracker;

		// Token: 0x0400B3A0 RID: 45984
		[Token(Token = "0x40086DE")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x1781C0", Offset = "0x1782C1")]
		public Transform rightFootTracker;

		// Token: 0x0400B3A1 RID: 45985
		[Token(Token = "0x40086DF")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "HeaderAttribute", RVA = "0x178200", Offset = "0x178301")]
		public VRIKCalibrator.CalibrationData data;
	}
}
