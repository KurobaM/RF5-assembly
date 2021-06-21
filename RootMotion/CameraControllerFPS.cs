using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000C8E RID: 3214
	[Token(Token = "0x2000838")]
	public class CameraControllerFPS : MonoBehaviour
	{
		// Token: 0x060052C8 RID: 21192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E9")]
		[Address(RVA = "0x29AAD50", Offset = "0x29AAE51", VA = "0x29AAD50")]
		private void Awake()
		{
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044EA")]
		[Address(RVA = "0x29AAD90", Offset = "0x29AAE91", VA = "0x29AAD90")]
		public void LateUpdate()
		{
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x0001B0D8 File Offset: 0x000192D8
		[Token(Token = "0x60044EB")]
		[Address(RVA = "0x29AAFD0", Offset = "0x29AB0D1", VA = "0x29AAFD0")]
		private float ClampAngle(float angle, float min, float max)
		{
			return 0f;
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044EC")]
		[Address(RVA = "0x29AB080", Offset = "0x29AB181", VA = "0x29AB080")]
		public CameraControllerFPS()
		{
		}

		// Token: 0x0400B1B8 RID: 45496
		[Token(Token = "0x400854E")]
		[FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		// Token: 0x0400B1B9 RID: 45497
		[Token(Token = "0x400854F")]
		[FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		// Token: 0x0400B1BA RID: 45498
		[Token(Token = "0x4008550")]
		[FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		// Token: 0x0400B1BB RID: 45499
		[Token(Token = "0x4008551")]
		[FieldOffset(Offset = "0x24")]
		private float x;

		// Token: 0x0400B1BC RID: 45500
		[Token(Token = "0x4008552")]
		[FieldOffset(Offset = "0x28")]
		private float y;
	}
}
