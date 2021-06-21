using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000CDB RID: 3291
	[Token(Token = "0x2000875")]
	public class TransferMotion : MonoBehaviour
	{
		// Token: 0x06005447 RID: 21575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004639")]
		[Address(RVA = "0x2864CC0", Offset = "0x2864DC1", VA = "0x2864CC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06005448 RID: 21576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600463A")]
		[Address(RVA = "0x2864D00", Offset = "0x2864E01", VA = "0x2864D00")]
		private void Update()
		{
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600463B")]
		[Address(RVA = "0x2864E60", Offset = "0x2864F61", VA = "0x2864E60")]
		public TransferMotion()
		{
		}

		// Token: 0x0400B375 RID: 45941
		[Token(Token = "0x40086B8")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177F00", Offset = "0x178001")]
		public Transform to;

		// Token: 0x0400B376 RID: 45942
		[Token(Token = "0x40086B9")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "TooltipAttribute", RVA = "0x177F40", Offset = "0x178041")]
		[Attribute(Name = "RangeAttribute", RVA = "0x177F40", Offset = "0x178041")]
		public float transferMotion;

		// Token: 0x0400B377 RID: 45943
		[Token(Token = "0x40086BA")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;
	}
}
