using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x02000CA3 RID: 3235
	[Token(Token = "0x2000849")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		// Token: 0x06005367 RID: 21351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004585")]
		[Address(RVA = "0x27D9C60", Offset = "0x27D9D61", VA = "0x27D9C60")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		// Token: 0x06005368 RID: 21352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004586")]
		[Address(RVA = "0x27D9D20", Offset = "0x27D9E21", VA = "0x27D9D20")]
		private void OnTriggerStay(Collider collider)
		{
		}

		// Token: 0x06005369 RID: 21353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004587")]
		[Address(RVA = "0x27D9DE0", Offset = "0x27D9EE1", VA = "0x27D9DE0")]
		private void OnTriggerExit(Collider collider)
		{
		}

		// Token: 0x0600536A RID: 21354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004588")]
		[Address(RVA = "0x27D9EA0", Offset = "0x27D9FA1", VA = "0x27D9EA0")]
		public TriggerEventBroadcaster()
		{
		}

		// Token: 0x0400B223 RID: 45603
		[Token(Token = "0x40085A8")]
		[FieldOffset(Offset = "0x18")]
		public GameObject target;
	}
}
