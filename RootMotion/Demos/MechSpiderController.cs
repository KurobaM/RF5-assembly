using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CAE RID: 3246
	[Token(Token = "0x2000853")]
	public class MechSpiderController : MonoBehaviour
	{
		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06005392 RID: 21394 RVA: 0x0001BB88 File Offset: 0x00019D88
		[Token(Token = "0x17000895")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60045AC")]
			[Address(RVA = "0x29B8B90", Offset = "0x29B8C91", VA = "0x29B8B90")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06005393 RID: 21395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AD")]
		[Address(RVA = "0x29B8C30", Offset = "0x29B8D31", VA = "0x29B8C30")]
		private void Update()
		{
		}

		// Token: 0x06005394 RID: 21396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045AE")]
		[Address(RVA = "0x29B8F50", Offset = "0x29B9051", VA = "0x29B8F50")]
		public MechSpiderController()
		{
		}

		// Token: 0x0400B265 RID: 45669
		[Token(Token = "0x40085EA")]
		[FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		// Token: 0x0400B266 RID: 45670
		[Token(Token = "0x40085EB")]
		[FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		// Token: 0x0400B267 RID: 45671
		[Token(Token = "0x40085EC")]
		[FieldOffset(Offset = "0x28")]
		public float speed;

		// Token: 0x0400B268 RID: 45672
		[Token(Token = "0x40085ED")]
		[FieldOffset(Offset = "0x2C")]
		public float turnSpeed;
	}
}
