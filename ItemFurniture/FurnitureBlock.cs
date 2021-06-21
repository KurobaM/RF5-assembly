using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ItemFurniture
{
	// Token: 0x02001043 RID: 4163
	[Token(Token = "0x2000A92")]
	public class FurnitureBlock : MonoBehaviour
	{
		// Token: 0x0600689A RID: 26778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600571E")]
		[Address(RVA = "0x223A110", Offset = "0x223A211", VA = "0x223A110", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x0600689B RID: 26779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600571F")]
		[Address(RVA = "0x223A1E0", Offset = "0x223A2E1", VA = "0x223A1E0", Slot = "5")]
		protected virtual void OnStayEvent(Collider fromCollider, Collider toCollider)
		{
		}

		// Token: 0x0600689C RID: 26780 RVA: 0x00023C70 File Offset: 0x00021E70
		[Token(Token = "0x6005720")]
		[Address(RVA = "0x2239C10", Offset = "0x2239D11", VA = "0x2239C10")]
		protected bool CallScript(string script_name)
		{
			return default(bool);
		}

		// Token: 0x0600689D RID: 26781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005721")]
		[Address(RVA = "0x2239D20", Offset = "0x2239E21", VA = "0x2239D20")]
		public FurnitureBlock()
		{
		}

		// Token: 0x040170FB RID: 94459
		[Token(Token = "0x4013D79")]
		[FieldOffset(Offset = "0x18")]
		public GameObject ReturnPos;

		// Token: 0x040170FC RID: 94460
		[Token(Token = "0x4013D7A")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "HideInInspector", RVA = "0x1803E0", Offset = "0x1804E1")]
		public bool bStartExit;

		// Token: 0x040170FD RID: 94461
		[Token(Token = "0x4013D7B")]
		[FieldOffset(Offset = "0x28")]
		protected SimpleTriggerEventDispatcher SimpleTriggerEventDispatcher;
	}
}
