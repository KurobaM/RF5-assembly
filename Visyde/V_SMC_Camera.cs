using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Visyde
{
	// Token: 0x02000C89 RID: 3209
	[Token(Token = "0x2000834")]
	public class V_SMC_Camera : MonoBehaviour
	{
		// Token: 0x060052AC RID: 21164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CD")]
		[Address(RVA = "0x1E47620", Offset = "0x1E47721", VA = "0x1E47620")]
		private void Start()
		{
		}

		// Token: 0x060052AD RID: 21165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CE")]
		[Address(RVA = "0x1E47650", Offset = "0x1E47751", VA = "0x1E47650")]
		private void Update()
		{
		}

		// Token: 0x060052AE RID: 21166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CF")]
		[Address(RVA = "0x1E47760", Offset = "0x1E47861", VA = "0x1E47760")]
		private void Hit()
		{
		}

		// Token: 0x060052AF RID: 21167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044D0")]
		[Address(RVA = "0x1E47A90", Offset = "0x1E47B91", VA = "0x1E47A90")]
		public V_SMC_Camera()
		{
		}

		// Token: 0x0400B185 RID: 45445
		[Token(Token = "0x4008520")]
		[FieldOffset(Offset = "0x18")]
		public V_SMC_Handler crosshairHandler;

		// Token: 0x0400B186 RID: 45446
		[Token(Token = "0x4008521")]
		[FieldOffset(Offset = "0x20")]
		private float rotationX;

		// Token: 0x0400B187 RID: 45447
		[Token(Token = "0x4008522")]
		[FieldOffset(Offset = "0x24")]
		private float rotationY;

		// Token: 0x0400B188 RID: 45448
		[Token(Token = "0x4008523")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 fireDirection;

		// Token: 0x0400B189 RID: 45449
		[Token(Token = "0x4008524")]
		[FieldOffset(Offset = "0x34")]
		private Vector3 firePoint;
	}
}
