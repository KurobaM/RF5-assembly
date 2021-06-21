using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000DA2 RID: 3490
	[Token(Token = "0x20008E8")]
	public static class VRIKCalibrator
	{
		// Token: 0x06005A4A RID: 23114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A93")]
		[Address(RVA = "0x27D1F10", Offset = "0x27D2011", VA = "0x27D1F10")]
		public static void RecalibrateScale(VRIK ik, VRIKCalibrator.Settings settings)
		{
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A94")]
		[Address(RVA = "0x27D2080", Offset = "0x27D2181", VA = "0x27D2080")]
		public static VRIKCalibrator.CalibrationData Calibrate(VRIK ik, VRIKCalibrator.Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A95")]
		[Address(RVA = "0x27D35A0", Offset = "0x27D36A1", VA = "0x27D35A0")]
		private static void CalibrateLeg(VRIKCalibrator.Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A96")]
		[Address(RVA = "0x27D40B0", Offset = "0x27D41B1", VA = "0x27D40B0")]
		public static void Calibrate(VRIK ik, VRIKCalibrator.CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A97")]
		[Address(RVA = "0x27D4C80", Offset = "0x27D4D81", VA = "0x27D4C80")]
		private static void CalibrateLeg(VRIKCalibrator.CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		// Token: 0x02000DA3 RID: 3491
		[Token(Token = "0x2001428")]
		[Serializable]
		public class Settings
		{
			// Token: 0x06005A4F RID: 23119 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A70")]
			[Address(RVA = "0x27D50D0", Offset = "0x27D51D1", VA = "0x27D50D0")]
			public Settings()
			{
			}

			// Token: 0x0400B999 RID: 47513
			[Token(Token = "0x401BB07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198CF0", Offset = "0x198DF1")]
			public float scaleMlp;

			// Token: 0x0400B99A RID: 47514
			[Token(Token = "0x401BB08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198D30", Offset = "0x198E31")]
			public Vector3 headTrackerForward;

			// Token: 0x0400B99B RID: 47515
			[Token(Token = "0x401BB09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198D70", Offset = "0x198E71")]
			public Vector3 headTrackerUp;

			// Token: 0x0400B99C RID: 47516
			[Token(Token = "0x401BB0A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198DB0", Offset = "0x198EB1")]
			public Vector3 bodyTrackerForward;

			// Token: 0x0400B99D RID: 47517
			[Token(Token = "0x401BB0B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198DF0", Offset = "0x198EF1")]
			public Vector3 bodyTrackerUp;

			// Token: 0x0400B99E RID: 47518
			[Token(Token = "0x401BB0C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198E30", Offset = "0x198F31")]
			public Vector3 handTrackerForward;

			// Token: 0x0400B99F RID: 47519
			[Token(Token = "0x401BB0D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198E70", Offset = "0x198F71")]
			public Vector3 handTrackerUp;

			// Token: 0x0400B9A0 RID: 47520
			[Token(Token = "0x401BB0E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198EB0", Offset = "0x198FB1")]
			public Vector3 footTrackerForward;

			// Token: 0x0400B9A1 RID: 47521
			[Token(Token = "0x401BB0F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198EF0", Offset = "0x198FF1")]
			public Vector3 footTrackerUp;

			// Token: 0x0400B9A2 RID: 47522
			[Token(Token = "0x401BB10")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Attribute(Name = "SpaceAttribute", RVA = "0x198F30", Offset = "0x199031")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198F30", Offset = "0x199031")]
			public Vector3 headOffset;

			// Token: 0x0400B9A3 RID: 47523
			[Token(Token = "0x401BB11")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198F80", Offset = "0x199081")]
			public Vector3 handOffset;

			// Token: 0x0400B9A4 RID: 47524
			[Token(Token = "0x401BB12")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x198FC0", Offset = "0x1990C1")]
			public float footForwardOffset;

			// Token: 0x0400B9A5 RID: 47525
			[Token(Token = "0x401BB13")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x199000", Offset = "0x199101")]
			public float footInwardOffset;

			// Token: 0x0400B9A6 RID: 47526
			[Token(Token = "0x401BB14")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Attribute(Name = "TooltipAttribute", RVA = "0x199040", Offset = "0x199141")]
			[Attribute(Name = "RangeAttribute", RVA = "0x199040", Offset = "0x199141")]
			public float footHeadingOffset;

			// Token: 0x0400B9A7 RID: 47527
			[Token(Token = "0x401BB15")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Attribute(Name = "RangeAttribute", RVA = "0x1990A0", Offset = "0x1991A1")]
			public float pelvisPositionWeight;

			// Token: 0x0400B9A8 RID: 47528
			[Token(Token = "0x401BB16")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Attribute(Name = "RangeAttribute", RVA = "0x1990C0", Offset = "0x1991C1")]
			public float pelvisRotationWeight;
		}

		// Token: 0x02000DA4 RID: 3492
		[Token(Token = "0x2001429")]
		[Serializable]
		public class CalibrationData
		{
			// Token: 0x06005A50 RID: 23120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007A71")]
			[Address(RVA = "0x27D3420", Offset = "0x27D3521", VA = "0x27D3420")]
			public CalibrationData()
			{
			}

			// Token: 0x0400B9A9 RID: 47529
			[Token(Token = "0x401BB17")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			// Token: 0x0400B9AA RID: 47530
			[Token(Token = "0x401BB18")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public VRIKCalibrator.CalibrationData.Target head;

			// Token: 0x0400B9AB RID: 47531
			[Token(Token = "0x401BB19")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VRIKCalibrator.CalibrationData.Target leftHand;

			// Token: 0x0400B9AC RID: 47532
			[Token(Token = "0x401BB1A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VRIKCalibrator.CalibrationData.Target rightHand;

			// Token: 0x0400B9AD RID: 47533
			[Token(Token = "0x401BB1B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public VRIKCalibrator.CalibrationData.Target pelvis;

			// Token: 0x0400B9AE RID: 47534
			[Token(Token = "0x401BB1C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public VRIKCalibrator.CalibrationData.Target leftFoot;

			// Token: 0x0400B9AF RID: 47535
			[Token(Token = "0x401BB1D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public VRIKCalibrator.CalibrationData.Target rightFoot;

			// Token: 0x0400B9B0 RID: 47536
			[Token(Token = "0x401BB1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public VRIKCalibrator.CalibrationData.Target leftLegGoal;

			// Token: 0x0400B9B1 RID: 47537
			[Token(Token = "0x401BB1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public VRIKCalibrator.CalibrationData.Target rightLegGoal;

			// Token: 0x0400B9B2 RID: 47538
			[Token(Token = "0x401BB20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			// Token: 0x0400B9B3 RID: 47539
			[Token(Token = "0x401BB21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			// Token: 0x0400B9B4 RID: 47540
			[Token(Token = "0x401BB22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			// Token: 0x02000DA5 RID: 3493
			[Token(Token = "0x2001665")]
			[Serializable]
			public class Target
			{
				// Token: 0x06005A51 RID: 23121 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080CE")]
				[Address(RVA = "0x27D3FE0", Offset = "0x27D40E1", VA = "0x27D3FE0")]
				public Target(Transform t)
				{
				}

				// Token: 0x06005A52 RID: 23122 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60080CF")]
				[Address(RVA = "0x27D4C20", Offset = "0x27D4D21", VA = "0x27D4C20")]
				public void SetTo(Transform t)
				{
				}

				// Token: 0x0400B9B5 RID: 47541
				[Token(Token = "0x401C449")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				// Token: 0x0400B9B6 RID: 47542
				[Token(Token = "0x401C44A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				// Token: 0x0400B9B7 RID: 47543
				[Token(Token = "0x401C44B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;
			}
		}
	}
}
