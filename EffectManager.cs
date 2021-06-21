using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000402 RID: 1026
[Token(Token = "0x2000323")]
public class EffectManager : SingletonMonoBehaviour<EffectManager>
{
	// Token: 0x17000421 RID: 1057
	// (get) Token: 0x060017AC RID: 6060 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060017AD RID: 6061 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170003B7")]
	public GameObject EffectRoot
	{
		[Token(Token = "0x600150F")]
		[Address(RVA = "0x22ACAC0", Offset = "0x22ACBC1", VA = "0x22ACAC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D520", Offset = "0x19D621")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001510")]
		[Address(RVA = "0x22ACAD0", Offset = "0x22ACBD1", VA = "0x22ACAD0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x19D530", Offset = "0x19D631")]
		private set
		{
		}
	}

	// Token: 0x060017AE RID: 6062 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001511")]
	[Address(RVA = "0x22ACAE0", Offset = "0x22ACBE1", VA = "0x22ACAE0", Slot = "4")]
	protected override void Awake()
	{
	}

	// Token: 0x060017AF RID: 6063 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001512")]
	[Address(RVA = "0x22ACD10", Offset = "0x22ACE11", VA = "0x22ACD10")]
	private void OnLoadEffectAsset(GameObject asset)
	{
	}

	// Token: 0x060017B0 RID: 6064 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001513")]
	[Address(RVA = "0x22ACDA0", Offset = "0x22ACEA1", VA = "0x22ACDA0")]
	private static void LateUpdate()
	{
	}

	// Token: 0x060017B1 RID: 6065 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001514")]
	[Address(RVA = "0x22AD0A0", Offset = "0x22AD1A1", VA = "0x22AD0A0")]
	private static ParticleSystem PlayEffect(EffectDataTable dataTable, bool noSE, ParticleSystem effect, float speed, Vector3 position, Quaternion rotation, Vector3 scale, [Optional] Transform parent)
	{
		return null;
	}

	// Token: 0x060017B2 RID: 6066 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001515")]
	[Address(RVA = "0x22AD370", Offset = "0x22AD471", VA = "0x22AD370")]
	private static void PlaySE(SoundID soundId, Vector3 position, Transform parent)
	{
	}

	// Token: 0x060017B3 RID: 6067 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001516")]
	[Address(RVA = "0x22ABA30", Offset = "0x22ABB31", VA = "0x22ABA30")]
	public static void Entry(EffectID id, [Optional] UnityAction<ParticleSystem> callback)
	{
	}

	// Token: 0x060017B4 RID: 6068 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001517")]
	[Address(RVA = "0x22AD490", Offset = "0x22AD591", VA = "0x22AD490")]
	public static void Play(EffectID id, float speed, [Optional] Transform parent, [Optional] UnityAction<ParticleSystem> callback)
	{
	}

	// Token: 0x060017B5 RID: 6069 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001518")]
	[Address(RVA = "0x22AD5E0", Offset = "0x22AD6E1", VA = "0x22AD5E0")]
	public static void Play(EffectID id, float speed, Vector3 position, Quaternion rotation, Vector3 scale, [Optional] Transform parent, [Optional] UnityAction<ParticleSystem> callback)
	{
	}

	// Token: 0x060017B6 RID: 6070 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001519")]
	[Address(RVA = "0x22AD860", Offset = "0x22AD961", VA = "0x22AD860")]
	public static void PlayNoSE(EffectID id, float speed, Vector3 position, Quaternion rotation, Vector3 scale, [Optional] Transform parent, [Optional] UnityAction<ParticleSystem> callback)
	{
	}

	// Token: 0x060017B7 RID: 6071 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600151A")]
	[Address(RVA = "0x22ADAE0", Offset = "0x22ADBE1", VA = "0x22ADAE0")]
	public static void DeleteAll()
	{
	}

	// Token: 0x060017B8 RID: 6072 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600151B")]
	[Address(RVA = "0x22ADCE0", Offset = "0x22ADDE1", VA = "0x22ADCE0")]
	public EffectManager()
	{
	}

	// Token: 0x04005BB7 RID: 23479
	[Token(Token = "0x4005852")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[SerializeField]
	private static List<ParticleSystem> m_PlayingList;

	// Token: 0x04005BB8 RID: 23480
	[Token(Token = "0x4005853")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[SerializeField]
	private static List<ParticleSystem> m_DeleteList;

	// Token: 0x04005BB9 RID: 23481
	[Token(Token = "0x4005854")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1627B0", Offset = "0x1628B1")]
	private GameObject <EffectRoot>k__BackingField;

	// Token: 0x04005BBA RID: 23482
	[Token(Token = "0x4005855")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static ResourceManager<GameObject> ResourceManager;

	// Token: 0x02000403 RID: 1027
	[Token(Token = "0x2001068")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1575A0", Offset = "0x1576A1")]
	private sealed class <>c__DisplayClass12_0
	{
		// Token: 0x060017BA RID: 6074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D88")]
		[Address(RVA = "0x22AD480", Offset = "0x22AD581", VA = "0x22AD480")]
		public <>c__DisplayClass12_0()
		{
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D89")]
		[Address(RVA = "0x22ADDE0", Offset = "0x22ADEE1", VA = "0x22ADDE0")]
		internal void <Entry>b__0(int backid, GameObject data)
		{
		}

		// Token: 0x04005BBB RID: 23483
		[Token(Token = "0x4018FD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityAction<ParticleSystem> callback;
	}

	// Token: 0x02000404 RID: 1028
	[Token(Token = "0x2001069")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1575B0", Offset = "0x1576B1")]
	private sealed class <>c__DisplayClass14_0
	{
		// Token: 0x060017BC RID: 6076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D8A")]
		[Address(RVA = "0x22AD850", Offset = "0x22AD951", VA = "0x22AD850")]
		public <>c__DisplayClass14_0()
		{
		}

		// Token: 0x060017BD RID: 6077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D8B")]
		[Address(RVA = "0x22ADEE0", Offset = "0x22ADFE1", VA = "0x22ADEE0")]
		internal void <Play>b__0(int backID, GameObject data)
		{
		}

		// Token: 0x04005BBC RID: 23484
		[Token(Token = "0x4018FD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parent;

		// Token: 0x04005BBD RID: 23485
		[Token(Token = "0x4018FDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 position;

		// Token: 0x04005BBE RID: 23486
		[Token(Token = "0x4018FDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion rotation;

		// Token: 0x04005BBF RID: 23487
		[Token(Token = "0x4018FDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public EffectDataTable dataTable;

		// Token: 0x04005BC0 RID: 23488
		[Token(Token = "0x4018FDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float speed;

		// Token: 0x04005BC1 RID: 23489
		[Token(Token = "0x4018FDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 scale;

		// Token: 0x04005BC2 RID: 23490
		[Token(Token = "0x4018FDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityAction<ParticleSystem> callback;
	}

	// Token: 0x02000405 RID: 1029
	[Token(Token = "0x200106A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1575C0", Offset = "0x1576C1")]
	private sealed class <>c__DisplayClass15_0
	{
		// Token: 0x060017BE RID: 6078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D8C")]
		[Address(RVA = "0x22ADAD0", Offset = "0x22ADBD1", VA = "0x22ADAD0")]
		public <>c__DisplayClass15_0()
		{
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D8D")]
		[Address(RVA = "0x22AE240", Offset = "0x22AE341", VA = "0x22AE240")]
		internal void <PlayNoSE>b__0(int backid, GameObject data)
		{
		}

		// Token: 0x04005BC3 RID: 23491
		[Token(Token = "0x4018FE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parent;

		// Token: 0x04005BC4 RID: 23492
		[Token(Token = "0x4018FE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 position;

		// Token: 0x04005BC5 RID: 23493
		[Token(Token = "0x4018FE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion rotation;

		// Token: 0x04005BC6 RID: 23494
		[Token(Token = "0x4018FE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public EffectDataTable dataTable;

		// Token: 0x04005BC7 RID: 23495
		[Token(Token = "0x4018FE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float speed;

		// Token: 0x04005BC8 RID: 23496
		[Token(Token = "0x4018FE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 scale;

		// Token: 0x04005BC9 RID: 23497
		[Token(Token = "0x4018FE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityAction<ParticleSystem> callback;
	}
}
