using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000CA0 RID: 3232
	[Token(Token = "0x2000846")]
	public static class QuaTools
	{
		// Token: 0x06005347 RID: 21319 RVA: 0x0001B8D0 File Offset: 0x00019AD0
		[Token(Token = "0x6004565")]
		[Address(RVA = "0x27D8600", Offset = "0x27D8701", VA = "0x27D8600")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		// Token: 0x06005348 RID: 21320 RVA: 0x0001B8E8 File Offset: 0x00019AE8
		[Token(Token = "0x6004566")]
		[Address(RVA = "0x27D8750", Offset = "0x27D8851", VA = "0x27D8750")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		// Token: 0x06005349 RID: 21321 RVA: 0x0001B900 File Offset: 0x00019B00
		[Token(Token = "0x6004567")]
		[Address(RVA = "0x27D88A0", Offset = "0x27D89A1", VA = "0x27D88A0")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		// Token: 0x0600534A RID: 21322 RVA: 0x0001B918 File Offset: 0x00019B18
		[Token(Token = "0x6004568")]
		[Address(RVA = "0x27D89C0", Offset = "0x27D8AC1", VA = "0x27D89C0")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x0001B930 File Offset: 0x00019B30
		[Token(Token = "0x6004569")]
		[Address(RVA = "0x27D8AE0", Offset = "0x27D8BE1", VA = "0x27D8AE0")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x0001B948 File Offset: 0x00019B48
		[Token(Token = "0x600456A")]
		[Address(RVA = "0x27D8C70", Offset = "0x27D8D71", VA = "0x27D8C70")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x0001B960 File Offset: 0x00019B60
		[Token(Token = "0x600456B")]
		[Address(RVA = "0x27C92C0", Offset = "0x27C93C1", VA = "0x27C92C0")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x0001B978 File Offset: 0x00019B78
		[Token(Token = "0x600456C")]
		[Address(RVA = "0x27D8D40", Offset = "0x27D8E41", VA = "0x27D8D40")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		// Token: 0x0600534F RID: 21327 RVA: 0x0001B990 File Offset: 0x00019B90
		[Token(Token = "0x600456D")]
		[Address(RVA = "0x27D9000", Offset = "0x27D9101", VA = "0x27D9000")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		// Token: 0x06005350 RID: 21328 RVA: 0x0001B9A8 File Offset: 0x00019BA8
		[Token(Token = "0x600456E")]
		[Address(RVA = "0x27D9230", Offset = "0x27D9331", VA = "0x27D9230")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return 0f;
		}

		// Token: 0x06005351 RID: 21329 RVA: 0x0001B9C0 File Offset: 0x00019BC0
		[Token(Token = "0x600456F")]
		[Address(RVA = "0x27D3430", Offset = "0x27D3531", VA = "0x27D3430")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		// Token: 0x06005352 RID: 21330 RVA: 0x0001B9D8 File Offset: 0x00019BD8
		[Token(Token = "0x6004570")]
		[Address(RVA = "0x27D93C0", Offset = "0x27D94C1", VA = "0x27D93C0")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x0001B9F0 File Offset: 0x00019BF0
		[Token(Token = "0x6004571")]
		[Address(RVA = "0x27D94D0", Offset = "0x27D95D1", VA = "0x27D94D0")]
		public static float ToBiPolar(float angle)
		{
			return 0f;
		}
	}
}
