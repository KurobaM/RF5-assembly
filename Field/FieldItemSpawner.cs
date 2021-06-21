using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x02001128 RID: 4392
	[Token(Token = "0x2000B0B")]
	public class FieldItemSpawner : MonoBehaviour
	{
		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06006F06 RID: 28422 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006F07 RID: 28423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B02")]
		public OnGroundItem OnGroundItem
		{
			[Token(Token = "0x6005C02")]
			[Address(RVA = "0x1F85ED0", Offset = "0x1F85FD1", VA = "0x1F85ED0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEF40", Offset = "0x1AF041")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C03")]
			[Address(RVA = "0x1F85EE0", Offset = "0x1F85FE1", VA = "0x1F85EE0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEF50", Offset = "0x1AF051")]
			private set
			{
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06006F08 RID: 28424 RVA: 0x00026388 File Offset: 0x00024588
		// (set) Token: 0x06006F09 RID: 28425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B03")]
		public bool IsInit
		{
			[Token(Token = "0x6005C04")]
			[Address(RVA = "0x1F85EF0", Offset = "0x1F85FF1", VA = "0x1F85EF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEF60", Offset = "0x1AF061")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005C05")]
			[Address(RVA = "0x1F85F00", Offset = "0x1F86001", VA = "0x1F85F00")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEF70", Offset = "0x1AF071")]
			set
			{
			}
		}

		// Token: 0x06006F0A RID: 28426 RVA: 0x000263A0 File Offset: 0x000245A0
		[Token(Token = "0x6005C06")]
		[Address(RVA = "0x1F85F10", Offset = "0x1F86011", VA = "0x1F85F10")]
		public FieldItemSpawnID GetFieldItemSpawnID()
		{
			return FieldItemSpawnID.EMPTY;
		}

		// Token: 0x06006F0B RID: 28427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C07")]
		[Address(RVA = "0x1F85F20", Offset = "0x1F86021", VA = "0x1F85F20")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006F0C RID: 28428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C08")]
		[Address(RVA = "0x1F83A10", Offset = "0x1F83B11", VA = "0x1F83A10")]
		public void DestroySpawnObject()
		{
		}

		// Token: 0x06006F0D RID: 28429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C09")]
		[Address(RVA = "0x1F86000", Offset = "0x1F86101", VA = "0x1F86000")]
		private void Start()
		{
		}

		// Token: 0x06006F0E RID: 28430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0A")]
		[Address(RVA = "0x1F854D0", Offset = "0x1F855D1", VA = "0x1F854D0")]
		public void Spawn()
		{
		}

		// Token: 0x06006F0F RID: 28431 RVA: 0x000263B8 File Offset: 0x000245B8
		[Token(Token = "0x6005C0B")]
		[Address(RVA = "0x1F86080", Offset = "0x1F86181", VA = "0x1F86080")]
		private ItemID CheckSpawnItemID(ItemID checkItemID)
		{
			return ItemID.ITEM_EMPTY;
		}

		// Token: 0x06006F10 RID: 28432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0C")]
		[Address(RVA = "0x1F86140", Offset = "0x1F86241", VA = "0x1F86140")]
		public FieldItemSpawner()
		{
		}

		// Token: 0x04018200 RID: 98816
		[Token(Token = "0x4014C9A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FieldItemSpawnID FieldItemSpawnID;

		// Token: 0x04018201 RID: 98817
		[Token(Token = "0x4014C9B")]
		[FieldOffset(Offset = "0x1C")]
		private FieldItemSpawnDataTable Data;

		// Token: 0x04018202 RID: 98818
		[Token(Token = "0x4014C9C")]
		[FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181520", Offset = "0x181621")]
		private OnGroundItem <OnGroundItem>k__BackingField;

		// Token: 0x04018203 RID: 98819
		[Token(Token = "0x4014C9D")]
		[FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x181530", Offset = "0x181631")]
		private bool <IsInit>k__BackingField;
	}
}
