using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000C90 RID: 3216
	[Token(Token = "0x200083A")]
	public class AxisTools
	{
		// Token: 0x060052CC RID: 21196 RVA: 0x0001B0F0 File Offset: 0x000192F0
		[Token(Token = "0x60044ED")]
		[Address(RVA = "0x29A1680", Offset = "0x29A1781", VA = "0x29A1680")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x0001B108 File Offset: 0x00019308
		[Token(Token = "0x60044EE")]
		[Address(RVA = "0x29A1770", Offset = "0x29A1871", VA = "0x29A1770")]
		public static Axis ToAxis(Vector3 v)
		{
			return Axis.X;
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x0001B120 File Offset: 0x00019320
		[Token(Token = "0x60044EF")]
		[Address(RVA = "0x29A1820", Offset = "0x29A1921", VA = "0x29A1820")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return Axis.X;
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x0001B138 File Offset: 0x00019338
		[Token(Token = "0x60044F0")]
		[Address(RVA = "0x29A1A30", Offset = "0x29A1B31", VA = "0x29A1A30")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return Axis.X;
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x0001B150 File Offset: 0x00019350
		[Token(Token = "0x60044F1")]
		[Address(RVA = "0x29A1940", Offset = "0x29A1A41", VA = "0x29A1940")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x0001B168 File Offset: 0x00019368
		[Token(Token = "0x60044F2")]
		[Address(RVA = "0x29A1B60", Offset = "0x29A1C61", VA = "0x29A1B60")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x0001B180 File Offset: 0x00019380
		[Token(Token = "0x60044F3")]
		[Address(RVA = "0x29A1BB0", Offset = "0x29A1CB1", VA = "0x29A1BB0")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F4")]
		[Address(RVA = "0x29A1E90", Offset = "0x29A1F91", VA = "0x29A1E90")]
		public AxisTools()
		{
		}
	}
}
