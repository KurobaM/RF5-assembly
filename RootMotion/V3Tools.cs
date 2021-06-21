using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000CA4 RID: 3236
	[Token(Token = "0x200084A")]
	public static class V3Tools
	{
		// Token: 0x0600536B RID: 21355 RVA: 0x0001BA38 File Offset: 0x00019C38
		[Token(Token = "0x6004589")]
		[Address(RVA = "0x27D9EB0", Offset = "0x27D9FB1", VA = "0x27D9EB0")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		// Token: 0x0600536C RID: 21356 RVA: 0x0001BA50 File Offset: 0x00019C50
		[Token(Token = "0x600458A")]
		[Address(RVA = "0x27D9FB0", Offset = "0x27DA0B1", VA = "0x27D9FB0")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		// Token: 0x0600536D RID: 21357 RVA: 0x0001BA68 File Offset: 0x00019C68
		[Token(Token = "0x600458B")]
		[Address(RVA = "0x27DA0B0", Offset = "0x27DA1B1", VA = "0x27DA0B0")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		// Token: 0x0600536E RID: 21358 RVA: 0x0001BA80 File Offset: 0x00019C80
		[Token(Token = "0x600458C")]
		[Address(RVA = "0x27DA1B0", Offset = "0x27DA2B1", VA = "0x27DA1B0")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x0001BA98 File Offset: 0x00019C98
		[Token(Token = "0x600458D")]
		[Address(RVA = "0x27DA2C0", Offset = "0x27DA3C1", VA = "0x27DA2C0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		// Token: 0x06005370 RID: 21360 RVA: 0x0001BAB0 File Offset: 0x00019CB0
		[Token(Token = "0x600458E")]
		[Address(RVA = "0x27DA4F0", Offset = "0x27DA5F1", VA = "0x27DA4F0")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		// Token: 0x06005371 RID: 21361 RVA: 0x0001BAC8 File Offset: 0x00019CC8
		[Token(Token = "0x600458F")]
		[Address(RVA = "0x27DA730", Offset = "0x27DA831", VA = "0x27DA730")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		// Token: 0x06005372 RID: 21362 RVA: 0x0001BAE0 File Offset: 0x00019CE0
		[Token(Token = "0x6004590")]
		[Address(RVA = "0x27DA980", Offset = "0x27DAA81", VA = "0x27DA980")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		// Token: 0x06005373 RID: 21363 RVA: 0x0001BAF8 File Offset: 0x00019CF8
		[Token(Token = "0x6004591")]
		[Address(RVA = "0x27DAB80", Offset = "0x27DAC81", VA = "0x27DAB80")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		// Token: 0x06005374 RID: 21364 RVA: 0x0001BB10 File Offset: 0x00019D10
		[Token(Token = "0x6004592")]
		[Address(RVA = "0x27DAD60", Offset = "0x27DAE61", VA = "0x27DAD60")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06005375 RID: 21365 RVA: 0x0001BB28 File Offset: 0x00019D28
		[Token(Token = "0x6004593")]
		[Address(RVA = "0x27DAEA0", Offset = "0x27DAFA1", VA = "0x27DAEA0")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}
	}
}
