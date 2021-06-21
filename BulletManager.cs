using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Define;
using Il2CppDummyDll;
using Loader;
using Loader.ID;
using UnityEngine;

// Token: 0x0200026C RID: 620
[Token(Token = "0x20001EE")]
public class BulletManager : SingletonMonoBehaviour<BulletManager>
{
	// Token: 0x06000F6E RID: 3950 RVA: 0x00006F30 File Offset: 0x00005130
	[Token(Token = "0x6000DE9")]
	[Address(RVA = "0x218E8E0", Offset = "0x218E9E1", VA = "0x218E8E0")]
	public bool Regist(BulletBase bullet)
	{
		return default(bool);
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x00006F48 File Offset: 0x00005148
	[Token(Token = "0x6000DEA")]
	[Address(RVA = "0x218EAE0", Offset = "0x218EBE1", VA = "0x218EAE0")]
	public bool Remove(BulletBase bullet)
	{
		return default(bool);
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEB")]
	[Address(RVA = "0x2198090", Offset = "0x2198191", VA = "0x2198090")]
	public void Update()
	{
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEC")]
	[Address(RVA = "0x2198570", Offset = "0x2198671", VA = "0x2198570")]
	public void FixedUpdate()
	{
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x00006F60 File Offset: 0x00005160
	[Token(Token = "0x6000DED")]
	[Address(RVA = "0x2198680", Offset = "0x2198781", VA = "0x2198680")]
	public bool CreateBullet(BulletID bulletID, global::Character chara, Vector3 offset, Quaternion rotationOffset, Transform parent, [Optional] Action<BulletBase, BulletDataTable> complate)
	{
		return default(bool);
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEE")]
	[Address(RVA = "0x2198840", Offset = "0x2198941", VA = "0x2198840")]
	public void ForceDestroyAll()
	{
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DEF")]
	[Address(RVA = "0x2198280", Offset = "0x2198381", VA = "0x2198280")]
	private void InitBullet(int assetId, GameObject asset, Vector3 position, Quaternion rotation, BulletDataTable table, Action<BulletBase, BulletDataTable> complate)
	{
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF0")]
	[Address(RVA = "0x2198950", Offset = "0x2198A51", VA = "0x2198950")]
	public BulletManager()
	{
	}

	// Token: 0x040008D1 RID: 2257
	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<BulletBase> m_bullets;

	// Token: 0x040008D2 RID: 2258
	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<GameObject, Prefab> m_loadIdList;

	// Token: 0x040008D3 RID: 2259
	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Attribute(Name = "TupleElementNamesAttribute", RVA = "0x15E7D0", Offset = "0x15E8D1")]
	private List<ValueTuple<int, GameObject, Vector3, Quaternion, BulletDataTable, Action<BulletBase, BulletDataTable>>> m_InitList;

	// Token: 0x0200026D RID: 621
	[Token(Token = "0x2001007")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x157290", Offset = "0x157391")]
	private sealed class <>c__DisplayClass7_0
	{
		// Token: 0x06000F76 RID: 3958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C70")]
		[Address(RVA = "0x2198830", Offset = "0x2198931", VA = "0x2198830")]
		public <>c__DisplayClass7_0()
		{
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C71")]
		[Address(RVA = "0x2198A40", Offset = "0x2198B41", VA = "0x2198A40")]
		internal void <CreateBullet>b__0(AssetHandle<GameObject> handle)
		{
		}

		// Token: 0x040008D4 RID: 2260
		[Token(Token = "0x4018E45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parent;

		// Token: 0x040008D5 RID: 2261
		[Token(Token = "0x4018E46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 offset;

		// Token: 0x040008D6 RID: 2262
		[Token(Token = "0x4018E47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Quaternion rotationOffset;

		// Token: 0x040008D7 RID: 2263
		[Token(Token = "0x4018E48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BulletManager <>4__this;

		// Token: 0x040008D8 RID: 2264
		[Token(Token = "0x4018E49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BulletDataTable table;

		// Token: 0x040008D9 RID: 2265
		[Token(Token = "0x4018E4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action<BulletBase, BulletDataTable> complate;
	}
}
