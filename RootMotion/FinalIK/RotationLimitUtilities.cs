using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000D24 RID: 3364
	[Token(Token = "0x20008AE")]
	public static class RotationLimitUtilities
	{
		// Token: 0x06005639 RID: 22073 RVA: 0x0001C5A8 File Offset: 0x0001A7A8
		[Token(Token = "0x60047E5")]
		[Address(RVA = "0x27CE950", Offset = "0x27CEA51", VA = "0x27CE950")]
		public static Quaternion LimitHinge(Quaternion rotation, float min, float max, bool useLimits, Vector3 axis, ref Quaternion lastRotation, ref float lastAngle)
		{
			return default(Quaternion);
		}

		// Token: 0x0600563A RID: 22074 RVA: 0x0001C5C0 File Offset: 0x0001A7C0
		[Token(Token = "0x60047E6")]
		[Address(RVA = "0x27CEC80", Offset = "0x27CED81", VA = "0x27CEC80")]
		public static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		// Token: 0x0600563B RID: 22075 RVA: 0x0001C5D8 File Offset: 0x0001A7D8
		[Token(Token = "0x60047E7")]
		[Address(RVA = "0x27CED70", Offset = "0x27CEE71", VA = "0x27CED70")]
		public static Quaternion LimitAngle(Quaternion rotation, Vector3 axis, Vector3 secondaryAxis, float limit, float twistLimit)
		{
			return default(Quaternion);
		}

		// Token: 0x0600563C RID: 22076 RVA: 0x0001C5F0 File Offset: 0x0001A7F0
		[Token(Token = "0x60047E8")]
		[Address(RVA = "0x27CEDE0", Offset = "0x27CEEE1", VA = "0x27CEDE0")]
		public static Quaternion LimitSwing(Quaternion rotation, Vector3 axis, float limit)
		{
			return default(Quaternion);
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x0001C608 File Offset: 0x0001A808
		[Token(Token = "0x60047E9")]
		[Address(RVA = "0x27CF020", Offset = "0x27CF121", VA = "0x27CF020")]
		public static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}
	}
}
