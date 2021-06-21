using System;
using Define;
using Il2CppDummyDll;
using UnityEngine;

namespace ItemFurniture
{
	// Token: 0x02001054 RID: 4180
	[Token(Token = "0x2000A9D")]
	public abstract class StorageFurniture : PlayerItemFurniture2, ItemInteractionInterface, FocusInterface
	{
		// Token: 0x06006957 RID: 26967
		[Token(Token = "0x60057C9")]
		public abstract bool CanItemInteraction(HumanController character, ItemData itemData, bool isThrow);

		// Token: 0x06006958 RID: 26968 RVA: 0x000240A8 File Offset: 0x000222A8
		[Token(Token = "0x60057CA")]
		[Address(RVA = "0x2084160", Offset = "0x2084261", VA = "0x2084160", Slot = "35")]
		public bool CanRapidItemInteraction(HumanController character, ItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x06006959 RID: 26969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057CB")]
		[Address(RVA = "0x2082370", Offset = "0x2082471", VA = "0x2082370", Slot = "37")]
		public virtual void DoItemInteraction(HumanController character, ItemData itemData, bool isThrow)
		{
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057CC")]
		[Address(RVA = "0x207ED90", Offset = "0x207EE91", VA = "0x207ED90")]
		public void Shake()
		{
		}

		// Token: 0x0600695B RID: 26971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057CD")]
		[Address(RVA = "0x207D510", Offset = "0x207D611", VA = "0x207D510")]
		public void StorageAction(bool is_storage)
		{
		}

		// Token: 0x0600695C RID: 26972 RVA: 0x000240C0 File Offset: 0x000222C0
		[Token(Token = "0x60057CE")]
		[Address(RVA = "0x2084170", Offset = "0x2084271", VA = "0x2084170", Slot = "32")]
		public override ushort GetInteractionType()
		{
			return 0;
		}

		// Token: 0x0600695D RID: 26973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057CF")]
		[Address(RVA = "0x2082390", Offset = "0x2082491", VA = "0x2082390")]
		protected StorageFurniture()
		{
		}

		// Token: 0x0600695E RID: 26974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D0")]
		[Address(RVA = "0x2084270", Offset = "0x2084371", VA = "0x2084270", Slot = "30")]
		private GameObject get_gameObject()
		{
			return null;
		}

		// Token: 0x0600695F RID: 26975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D1")]
		[Address(RVA = "0x2084280", Offset = "0x2084381", VA = "0x2084280", Slot = "31")]
		private Transform get_transform()
		{
			return null;
		}

		// Token: 0x04017159 RID: 94553
		[Token(Token = "0x4013DBC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject m_model;

		// Token: 0x0401715A RID: 94554
		[Token(Token = "0x4013DBD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private InteractionType m_InteractionType;
	}
}
