using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Field
{
	// Token: 0x0200111F RID: 4383
	[Token(Token = "0x2000B07")]
	public class FieldHideItemSpawner : MonoBehaviour
	{
		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x06006EBA RID: 28346 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006EBB RID: 28347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFD")]
		public OnGroundItem OnGroundItem
		{
			[Token(Token = "0x6005BC8")]
			[Address(RVA = "0x1F82570", Offset = "0x1F82671", VA = "0x1F82570")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEE00", Offset = "0x1AEF01")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005BC9")]
			[Address(RVA = "0x1F82580", Offset = "0x1F82681", VA = "0x1F82580")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEE10", Offset = "0x1AEF11")]
			private set
			{
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x06006EBC RID: 28348 RVA: 0x000260A0 File Offset: 0x000242A0
		// (set) Token: 0x06006EBD RID: 28349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000AFE")]
		public bool IsInit
		{
			[Token(Token = "0x6005BCA")]
			[Address(RVA = "0x1F82590", Offset = "0x1F82691", VA = "0x1F82590")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEE20", Offset = "0x1AEF21")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005BCB")]
			[Address(RVA = "0x1F825A0", Offset = "0x1F826A1", VA = "0x1F825A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AEE30", Offset = "0x1AEF31")]
			private set
			{
			}
		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x000260B8 File Offset: 0x000242B8
		[Token(Token = "0x6005BCC")]
		[Address(RVA = "0x1F825B0", Offset = "0x1F826B1", VA = "0x1F825B0")]
		public FieldHideItemSpawnID GetFieldHideItemSpawnID()
		{
			return FieldHideItemSpawnID.EMPTY;
		}

		// Token: 0x06006EBF RID: 28351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCD")]
		[Address(RVA = "0x1F825C0", Offset = "0x1F826C1", VA = "0x1F825C0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06006EC0 RID: 28352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCE")]
		[Address(RVA = "0x1F82760", Offset = "0x1F82861", VA = "0x1F82760")]
		public void DestroySpawnObject()
		{
		}

		// Token: 0x06006EC1 RID: 28353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BCF")]
		[Address(RVA = "0x1F82830", Offset = "0x1F82931", VA = "0x1F82830")]
		private void Start()
		{
		}

		// Token: 0x06006EC2 RID: 28354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD0")]
		[Address(RVA = "0x1F82970", Offset = "0x1F82A71", VA = "0x1F82970")]
		public void Spawn()
		{
		}

		// Token: 0x06006EC3 RID: 28355 RVA: 0x000260D0 File Offset: 0x000242D0
		[Token(Token = "0x6005BD1")]
		[Address(RVA = "0x1F83050", Offset = "0x1F83151", VA = "0x1F83050")]
		public bool UpdateDetectState(ref bool[] canDetectParties, ref bool[] IsDetectParties)
		{
			return default(bool);
		}

		// Token: 0x06006EC4 RID: 28356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD2")]
		[Address(RVA = "0x1F83390", Offset = "0x1F83491", VA = "0x1F83390")]
		public void OnChangeHideDetectFlag(bool setValue)
		{
		}

		// Token: 0x06006EC5 RID: 28357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005BD3")]
		[Address(RVA = "0x1F833A0", Offset = "0x1F834A1", VA = "0x1F833A0")]
		public FieldHideItemSpawner()
		{
		}

		// Token: 0x040181DA RID: 98778
		[Token(Token = "0x4014C7D")]
		private const float DetectRadius = 25f;

		// Token: 0x040181DB RID: 98779
		[Token(Token = "0x4014C7E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FieldHideItemSpawnID FieldHideItemSpawnID;

		// Token: 0x040181DC RID: 98780
		[Token(Token = "0x4014C7F")]
		[FieldOffset(Offset = "0x1C")]
		private FieldHideItemSpawnDataTable Data;

		// Token: 0x040181DD RID: 98781
		[Token(Token = "0x4014C80")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1814D0", Offset = "0x1815D1")]
		private OnGroundItem <OnGroundItem>k__BackingField;

		// Token: 0x040181DE RID: 98782
		[Token(Token = "0x4014C81")]
		[FieldOffset(Offset = "0x38")]
		private bool isPlayerDetect;

		// Token: 0x040181DF RID: 98783
		[Token(Token = "0x4014C82")]
		[FieldOffset(Offset = "0x39")]
		private bool isInDetectRadius;

		// Token: 0x040181E0 RID: 98784
		[Token(Token = "0x4014C83")]
		[FieldOffset(Offset = "0x3A")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1814E0", Offset = "0x1815E1")]
		private bool <IsInit>k__BackingField;
	}
}
